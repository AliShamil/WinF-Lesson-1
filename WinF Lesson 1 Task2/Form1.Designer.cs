namespace WinF_Lesson_1_Task2
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
            this.funnyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // funnyLabel
            // 
            this.funnyLabel.AutoSize = true;
            this.funnyLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.funnyLabel.Location = new System.Drawing.Point(363, 140);
            this.funnyLabel.Name = "funnyLabel";
            this.funnyLabel.Size = new System.Drawing.Size(68, 15);
            this.funnyLabel.TabIndex = 0;
            this.funnyLabel.Text = "FunnyLable";
            this.funnyLabel.MouseHover += new System.EventHandler(this.funnyLabel_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.funnyLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label funnyLabel;
    }
}