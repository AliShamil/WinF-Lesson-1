namespace WinF_Lesson_1_Task3
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
            this.cityTimeLabel = new System.Windows.Forms.Label();
            this.changeCityBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityTimeLabel
            // 
            this.cityTimeLabel.AutoSize = true;
            this.cityTimeLabel.Location = new System.Drawing.Point(21, 17);
            this.cityTimeLabel.Name = "cityTimeLabel";
            this.cityTimeLabel.Size = new System.Drawing.Size(37, 15);
            this.cityTimeLabel.TabIndex = 0;
            this.cityTimeLabel.Text = "Timer";
            // 
            // changeCityBtn
            // 
            this.changeCityBtn.AutoSize = true;
            this.changeCityBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeCityBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeCityBtn.Location = new System.Drawing.Point(329, 192);
            this.changeCityBtn.Name = "changeCityBtn";
            this.changeCityBtn.Size = new System.Drawing.Size(121, 44);
            this.changeCityBtn.TabIndex = 1;
            this.changeCityBtn.Text = "Change City";
            this.changeCityBtn.UseVisualStyleBackColor = false;
            this.changeCityBtn.Click += new System.EventHandler(this.changeCityBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinF_Lesson_1_Task3.Properties.Resources.Baku_City;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeCityBtn);
            this.Controls.Add(this.cityTimeLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cityTimeLabel;
        private Button changeCityBtn;
    }
}