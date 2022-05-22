namespace WinFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.textBoxCapitalizedString = new System.Windows.Forms.TextBox();
            this.textBoxVowels = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a String";
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(197, 73);
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(192, 27);
            this.textBoxUserInput.TabIndex = 1;
            // 
            // textBoxCapitalizedString
            // 
            this.textBoxCapitalizedString.Location = new System.Drawing.Point(195, 174);
            this.textBoxCapitalizedString.Name = "textBoxCapitalizedString";
            this.textBoxCapitalizedString.Size = new System.Drawing.Size(194, 27);
            this.textBoxCapitalizedString.TabIndex = 2;
            // 
            // textBoxVowels
            // 
            this.textBoxVowels.Location = new System.Drawing.Point(195, 231);
            this.textBoxVowels.Name = "textBoxVowels";
            this.textBoxVowels.Size = new System.Drawing.Size(194, 27);
            this.textBoxVowels.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Formatted String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vowels in the string";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVowels);
            this.Controls.Add(this.textBoxCapitalizedString);
            this.Controls.Add(this.textBoxUserInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxUserInput;
        private TextBox textBoxCapitalizedString;
        private TextBox textBoxVowels;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}