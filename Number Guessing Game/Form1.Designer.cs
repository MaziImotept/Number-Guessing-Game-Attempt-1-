

namespace Number_Guessing_Game
{
    partial class Form1
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
            this.button_guess = new System.Windows.Forms.Button();
            this.textbox_guess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_guess
            // 
            this.button_guess.Location = new System.Drawing.Point(12, 107);
            this.button_guess.Name = "button_guess";
            this.button_guess.Size = new System.Drawing.Size(282, 47);
            this.button_guess.TabIndex = 0;
            this.button_guess.Text = "Guess!";
            this.button_guess.UseVisualStyleBackColor = true;
            this.button_guess.Click += new System.EventHandler(this.button_guess_Click);
            // 
            // textbox_guess
            // 
            this.textbox_guess.Location = new System.Drawing.Point(12, 81);
            this.textbox_guess.Name = "textbox_guess";
            this.textbox_guess.Size = new System.Drawing.Size(282, 20);
            this.textbox_guess.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 166);
            this.Controls.Add(this.textbox_guess);
            this.Controls.Add(this.button_guess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_guess;
        private System.Windows.Forms.TextBox textbox_guess;
    }
}

