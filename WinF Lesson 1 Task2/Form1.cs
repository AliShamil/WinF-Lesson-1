namespace WinF_Lesson_1_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void funnyLabel_MouseHover(object sender, EventArgs e)
        {
            (sender as Label)!.Location = new Point(Random.Shared.Next(Size.Width - 100), Random.Shared.Next(Size.Height - 100));
        }
    }
}