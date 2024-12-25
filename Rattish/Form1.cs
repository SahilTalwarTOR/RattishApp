using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using System.Web;
using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace Rattish
{
    public partial class Form1 : Form
    {
        Stopwatch timer = new Stopwatch();
        private static System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        TimeSpan baseTimeSpan = TimeSpan.FromMinutes(5);
        bool clicked = false;
        BindingList<string> keyPair;
        ArrayList stupidFuckingArray = new ArrayList();
        int counter = 0; // I genuinely FUCKING hate this implementation
        bool ready = false; // Is the program ready?
        private string AnimalName;
        bool nameFocused;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.keyPair = new BindingList<string>(); // We'll use this for setting up the key-pairs
            PreviewBox.DataSource = this.keyPair;
            saveData.Enabled = false;
            getNextAnimal.Enabled = false;
            this.nameFocused = false;

            lettersList.AutoSize = false; // Disable AutoSize to control dimensions
            lettersList.MaximumSize = new Size(643, 0); // Maintain the current width, allow height expansion
            lettersList.Size = new Size(643, 50); // Adjust height to fit wrapped text (50 is a rough estimate)
        }

        private void videoTag_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.ExpandEnvironmentVariables(@"%userprofile%\downloads\");
            ofd.Filter = "MP4 Files (*.mp4)|*.mp4|All Files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = ofd.FileName;
                videoTag.Text = selectedFile;
                axWindowsMediaPlayer1.URL = selectedFile;
                saveData.Enabled = true;
            }

        }


        /*Just for my own personal note, this comment will probably take up a good portion of the code
         * R = Rearing
         * G = Grooming
         * F = Freezing
         * L/W = Locomation/Walking
         * T = Thigomotaxis
         * 
         * 
        */


        HashSet<Keys> letters = new HashSet<Keys> { Keys.R, Keys.G, Keys.F, Keys.W, Keys.T, Keys.E, Keys.C, Keys.S, Keys.D };
        Keys savedKey;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.nameFocused) // Check if name input is focused
            {
                return;
            }

            if (this.AnimalName == "" || this.AnimalName == " " || this.AnimalName == null)
            {
                MessageBox.Show("No animal name has been entered. Enter an animal name & click Set Animal Name to begin");
                return;
            }


            if (letters.Contains(e.KeyCode)) // Ensure it's a valid key
            {
                if (!clicked || e.KeyCode != savedKey) // New key pressed or no active key
                {
                    if (clicked) // If tracking is already active for another key
                    {
                        // Stop tracking the previous key
                        timer.Stop();
                        updateTimer.Stop();
                        TimeSpan ts = timer.Elapsed;
                        string totalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                        timeSince.Text = "Key Held For: " + totalTime;
                        double endStamp = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                        this.keyPair.Add(savedKey.ToString() + " | " + DateTime.Now.ToString() + " | " + totalTime + " | " + stupidFuckingArray[counter] + " | " + endStamp + " | " + this.AnimalName);
                        counter++;
                    }

                    // Start tracking the new key
                    keyWarning.Text = "No warnings.";
                    savedKey = e.KeyCode;
                    timer.Reset();
                    clicked = true;
                    double timestamp = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                    recentKey.Text = "Recent Key: " + e.KeyCode + " at " + timestamp;
                    timer.Start();
                    quote.Text = "Recording Time..";
                    updateTimer.Interval = 10;
                    updateTimer.Tick += new EventHandler(UpdateTimer);
                    updateTimer.Start();
                    stupidFuckingArray.Add(timestamp);
                }
                else if (e.KeyCode == savedKey) // Same key pressed again
                {
                    // Stop tracking and save data, but don't continue
                    timer.Stop();
                    updateTimer.Stop();
                    TimeSpan ts = timer.Elapsed;
                    string totalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    timeSince.Text = "Key Held For: " + totalTime;
                    double endStamp = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                    this.keyPair.Add(savedKey.ToString() + " | " + DateTime.Now.ToString() + " | " + totalTime + " | " + stupidFuckingArray[counter] + " | " + endStamp + " | " + this.AnimalName);
                    counter++;

                    // Indicate stopped state
                    clicked = false;
                    quote.Text = "Stopped Recording.";
                }
            }
            else
            {
                // Key is not valid for tracking
                keyWarning.Text = "Invalid key: " + e.KeyCode;
            }
        }



        private void UpdateTimer(object sender, EventArgs e)
        {
            TimeSpan ts = timer.Elapsed;
            string totalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            timeSince.Text = "Key Holding For: " + totalTime;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void createExcel(object sender, EventArgs e)
        {
            using var newWorkbook = new ClosedXML.Excel.XLWorkbook();
            var worksheet = newWorkbook.AddWorksheet("Rat Data");
            string filePath = Environment.ExpandEnvironmentVariables(@"%userprofile%\downloads\");
            worksheet.Cell("A1").Value = "Time (s)";
            worksheet.Cell("A2").Value = textBox1.Text;
            int row = 2;
            // Header filling
            for (int i = 0; i <= 1800; i++)
            {
                worksheet.Cell(1, i + 2).Value = i;
                worksheet.Cell(1, i + 2).Style.Fill.BackgroundColor = XLColor.FromHtml("fbe2d5");
            }

            for (int i = 0; i < keyPair.Count; i++)
            {
                if (i >= 1)
                {
                    if (!returnAnimalName(keyPair[i - 1]).Equals(returnAnimalName(keyPair[i])))
                    {
                        row++; // Increment for diff name
                    }
                }
                for (int col = returnTimeStamp(keyPair[i]); col <= returnEndStamp(keyPair[i]); col++)
                {
                    worksheet.Cell(row, 1).Value = returnAnimalName(keyPair[i]);
                    worksheet.Cell(row, col + 2).Value = returnKey(keyPair[i]);
                }
            }

            var otherSheet = newWorkbook.AddWorksheet("Timings");
            otherSheet.Cell(1, 1).Value = "Key";
            otherSheet.Cell(1, 2).Value = "Start";
            otherSheet.Cell(1, 3).Value = "End";
            otherSheet.Cell(1, 4).Value = "Name";
            for (int i = 1; i <= 4; i++) // Just some colouring
            {
                otherSheet.Cell(1, i).Style.Fill.BackgroundColor = XLColor.FromHtml("fbe2d5");
            }

            for (int i = 0; i < keyPair.Count; i++)
            {
                otherSheet.Cell(i + 2, 1).Value = returnKey(keyPair[i]);
                otherSheet.Cell(i + 2, 2).Value = rawTimeStamp(keyPair[i]);
                otherSheet.Cell(i + 2, 3).Value = rawEndStamp(keyPair[i]);
                otherSheet.Cell(i + 2, 4).Value = returnAnimalName(keyPair[i]);
            }


            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = filePath;
            save.FilterIndex = 2;
            save.RestoreDirectory = true;
            save.Filter = "Excel Files|(*.xlsx;";
            System.Windows.Forms.DialogResult result = save.ShowDialog();
            if (result == DialogResult.OK)
            {
                newWorkbook.SaveAs(filePath + Path.GetFileName(save.FileName));
                MessageBox.Show("Saved as " + filePath + save.FileName);
            }


        }


        private string returnKey(String pairString)
        {
            string[] stringParts = pairString.Split('|');
            string key = stringParts[0].Trim();
            return key;
        }

        private string returnTimeHeld(String pairString)
        {
            string[] stringParts = pairString.Split('|');
            string key = stringParts[2].Trim();
            return key;
        }

        private int returnTimeStamp(String pairString)
        {
            string[] stringParts = pairString.Split('|');
            string key = stringParts[3].Trim();
            float timeKey = float.Parse(key);
            return quickRound(timeKey);
        }

        private int returnEndStamp(String pairString)
        {
            string[] stringParts = pairString.Split('|');
            string key = stringParts[4].Trim();
            float timeKey = float.Parse(key);
            return quickRound(timeKey);
        }

        private double rawTimeStamp(String pairString)
        {
            string[] stringParts = pairString.Split('|');
            string key = stringParts[3].Trim();
            double timeKey = double.Parse(key);
            return timeKey;
        }

        private double rawEndStamp(String pairString)
        {
            string[] stringParts = pairString.Split('|');
            string key = stringParts[4].Trim();
            double timeKey = double.Parse(key);
            return timeKey;
        }

        private string returnAnimalName(String pairString)
        {
            string[] stringParts = pairString.Split('|');
            string name = stringParts[5].Trim();
            return name;
        }

        private void setAnimalName(object sender, EventArgs e)
        {
            this.AnimalName = textBox1.Text;
            this.textBox1.Enabled = false;
            this.keyWarning.Text = "Saved Name";
            this.textBox1.Enabled = true;
        }

        private int quickRound(float value)
        {
            int integerPart = (int)value;
            double decimalPart = value - integerPart;
            if (decimalPart >= 0.5)
            {
                return integerPart + 1;
            }
            else
            {
                return integerPart;
            }
        }

        private void nextAnimal(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            setName.Enabled = true;
        }

        private void nameEnter(object sender, EventArgs e)
        {
            this.nameFocused = true;
        }

        private void nameLeave(object sender, EventArgs e)
        {
            this.nameFocused = false;
            setName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addTrack(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                // Our dialog for stuff
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    string key = form2.returnInput();
                    char cKey = char.Parse(key);
                    try
                    {
                        Keys k = (Keys)char.ToUpper(cKey);
                        addToList(k);
                    }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show("An error occued while casting your given character to a key. Did you enter a character or special character/number?");
                    }
                }
            }
        }

        private void addToList(Keys input)
        {
            if (!letters.Contains(input))
            {
                letters.Add(input);
                lettersList.Text += " | Custom Key: " + input.ToString();
            }
            else
            {
                MessageBox.Show("The character you have attempted to add already exists");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
