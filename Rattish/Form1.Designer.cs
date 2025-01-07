namespace Rattish
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            videoSelect = new Button();
            videoTag = new Label();
            panel1 = new Panel();
            SpeedLabel = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            addTrackBtn = new Button();
            keyWarning = new Label();
            setName = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            timeSince = new Label();
            saveData = new Button();
            recentKey = new Label();
            toolTag = new Label();
            quote = new Label();
            bindingSource1 = new BindingSource(components);
            PreviewBox = new ListBox();
            lettersList = new Label();
            panel2 = new Panel();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            versionLabel = new Label();
            timeLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // videoSelect
            // 
            videoSelect.Location = new Point(17, 52);
            videoSelect.Name = "videoSelect";
            videoSelect.Size = new Size(170, 23);
            videoSelect.TabIndex = 1;
            videoSelect.Text = "Select Video";
            videoSelect.UseVisualStyleBackColor = true;
            videoSelect.Click += videoTag_Click;
            // 
            // videoTag
            // 
            videoTag.AutoSize = true;
            videoTag.Location = new Point(48, 78);
            videoTag.MaximumSize = new Size(103, 15);
            videoTag.Name = "videoTag";
            videoTag.Size = new Size(103, 15);
            videoTag.TabIndex = 2;
            videoTag.Text = "No Video Selected";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(SpeedLabel);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(addTrackBtn);
            panel1.Controls.Add(keyWarning);
            panel1.Controls.Add(setName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(timeSince);
            panel1.Controls.Add(saveData);
            panel1.Controls.Add(recentKey);
            panel1.Controls.Add(toolTag);
            panel1.Controls.Add(videoSelect);
            panel1.Controls.Add(videoTag);
            panel1.Location = new Point(1001, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 474);
            panel1.TabIndex = 3;
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(69, 195);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(72, 15);
            SpeedLabel.TabIndex = 16;
            SpeedLabel.Text = "Video Speed";
            // 
            // button3
            // 
            button3.Location = new Point(17, 242);
            button3.Name = "button3";
            button3.Size = new Size(170, 23);
            button3.TabIndex = 15;
            button3.Text = "1x (NORMAL SPEED)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += regularSpeed;
            // 
            // button2
            // 
            button2.Location = new Point(106, 213);
            button2.Name = "button2";
            button2.Size = new Size(81, 23);
            button2.TabIndex = 14;
            button2.Text = "1.5x (Fast)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += speedUp;
            // 
            // button1
            // 
            button1.Location = new Point(17, 213);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 11;
            button1.Text = "0.5x (Slow)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addTrackBtn
            // 
            addTrackBtn.Location = new Point(17, 383);
            addTrackBtn.Name = "addTrackBtn";
            addTrackBtn.Size = new Size(170, 23);
            addTrackBtn.TabIndex = 13;
            addTrackBtn.Text = "Add Tracker";
            addTrackBtn.UseVisualStyleBackColor = true;
            addTrackBtn.Click += addTrack;
            // 
            // keyWarning
            // 
            keyWarning.ForeColor = Color.Red;
            keyWarning.Location = new Point(0, 286);
            keyWarning.MaximumSize = new Size(0, 100);
            keyWarning.Name = "keyWarning";
            keyWarning.Size = new Size(194, 82);
            keyWarning.TabIndex = 5;
            keyWarning.Text = "No warnings.";
            // 
            // setName
            // 
            setName.Location = new Point(17, 158);
            setName.Name = "setName";
            setName.Size = new Size(170, 23);
            setName.TabIndex = 11;
            setName.Text = "Set Animal Name";
            setName.UseVisualStyleBackColor = true;
            setName.Click += setAnimalName;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 111);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 8;
            label1.Text = "Animal Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "Enter Animal Name..";
            textBox1.MouseEnter += nameEnter;
            textBox1.MouseLeave += nameLeave;
            // 
            // timeSince
            // 
            timeSince.AutoSize = true;
            timeSince.Font = new Font("Segoe UI", 7F);
            timeSince.Location = new Point(0, 447);
            timeSince.Name = "timeSince";
            timeSince.Size = new Size(51, 12);
            timeSince.TabIndex = 6;
            timeSince.Text = "Time Held:";
            // 
            // saveData
            // 
            saveData.Location = new Point(17, 412);
            saveData.Name = "saveData";
            saveData.Size = new Size(170, 23);
            saveData.TabIndex = 5;
            saveData.Text = "Save Data .xlsl";
            saveData.UseVisualStyleBackColor = true;
            saveData.Click += createExcel;
            // 
            // recentKey
            // 
            recentKey.AutoSize = true;
            recentKey.Font = new Font("Segoe UI", 9F);
            recentKey.Location = new Point(0, 459);
            recentKey.Name = "recentKey";
            recentKey.Size = new Size(100, 15);
            recentKey.TabIndex = 4;
            recentKey.Text = "RECENT KEY: N/A";
            // 
            // toolTag
            // 
            toolTag.AutoSize = true;
            toolTag.BackColor = Color.Gainsboro;
            toolTag.Font = new Font("Segoe UI Semibold", 16F);
            toolTag.ForeColor = SystemColors.GrayText;
            toolTag.Location = new Point(54, 9);
            toolTag.Name = "toolTag";
            toolTag.Size = new Size(97, 30);
            toolTag.TabIndex = 3;
            toolTag.Text = "Controls";
            // 
            // quote
            // 
            quote.AutoSize = true;
            quote.Location = new Point(12, 616);
            quote.Name = "quote";
            quote.Size = new Size(56, 15);
            quote.TabIndex = 4;
            quote.Text = "State Log";
            // 
            // PreviewBox
            // 
            PreviewBox.FormattingEnabled = true;
            PreviewBox.ItemHeight = 15;
            PreviewBox.Location = new Point(12, 504);
            PreviewBox.Name = "PreviewBox";
            PreviewBox.Size = new Size(376, 109);
            PreviewBox.TabIndex = 6;
            // 
            // lettersList
            // 
            lettersList.AutoSize = true;
            lettersList.Location = new Point(2, 5);
            lettersList.Name = "lettersList";
            lettersList.Size = new Size(643, 15);
            lettersList.TabIndex = 7;
            lettersList.Text = "Rearing: R | Grooming: G |Freezing: F | Walking: W | Thigmotaxis: T | Examining: E | Consuming: C | Survey: S | Digging: D  ";
            lettersList.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(lettersList);
            panel2.Location = new Point(394, 504);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 109);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(-7, -3);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1002, 489);
            axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(1135, 617);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(66, 15);
            versionLabel.TabIndex = 10;
            versionLabel.Text = "Version: 1.1";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(877, 486);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(118, 15);
            timeLabel.TabIndex = 11;
            timeLabel.Text = "Video Speed: Regular";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 641);
            Controls.Add(timeLabel);
            Controls.Add(versionLabel);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(panel2);
            Controls.Add(PreviewBox);
            Controls.Add(quote);
            Controls.Add(panel1);
            HelpButton = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button videoSelect;
        private Label videoTag;
        private Panel panel1;
        private Label toolTag;
        private Label recentKey;
        private Button saveData;
        private Label quote;
        private Label timeSince;
        private Label label1;
        private TextBox textBox1;
        private BindingSource bindingSource1;
        private Label keyWarning;
        private ListBox PreviewBox;
        private Button viewArray;
        private Button setName;
        private Label lettersList;
        private Button addTrackBtn;
        private Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Label versionLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label SpeedLabel;
        private Label timeLabel;
    }
}
