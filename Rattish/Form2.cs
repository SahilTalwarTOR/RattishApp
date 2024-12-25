using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rattish
{
    public partial class Form2 : Form
    {

        private string userKey;
        public Form2()
        {
            InitializeComponent();
            this.userKey = "";
        }

        private void getInput(object sender, EventArgs e)
        {
            if (!(inputKey.Text.Length == 1))
            {
                MessageBox.Show("The value you have provided is not a key, please remove any extra spaces and characters, enter keys in the style of singular letters", "Not a Key");
            }
            else
            {
                this.userKey += inputKey.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public string returnInput()
        {
            if (this.userKey.Length <= 0)
            {
                MessageBox.Show("An error occurred returning the key value");
            }
            else
            {
                return this.userKey;
            }
            return this.userKey;
        }
    }

}
