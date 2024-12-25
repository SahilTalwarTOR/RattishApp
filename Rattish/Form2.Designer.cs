namespace Rattish
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            confirmTrack = new Button();
            inputKey = new TextBox();
            SuspendLayout();
            // 
            // confirmTrack
            // 
            confirmTrack.Location = new Point(122, 57);
            confirmTrack.Name = "confirmTrack";
            confirmTrack.Size = new Size(128, 23);
            confirmTrack.TabIndex = 0;
            confirmTrack.Text = "Add Key To Track";
            confirmTrack.UseVisualStyleBackColor = true;
            confirmTrack.Click += getInput;
            // 
            // inputKey
            // 
            inputKey.Location = new Point(100, 28);
            inputKey.Name = "inputKey";
            inputKey.Size = new Size(185, 23);
            inputKey.TabIndex = 1;
            inputKey.Text = "Input Key (eg. \"N\")";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 92);
            Controls.Add(inputKey);
            Controls.Add(confirmTrack);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button confirmTrack;
        private TextBox inputKey;
    }
}