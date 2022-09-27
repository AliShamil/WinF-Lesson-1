using System.Globalization;
using WinF_Lesson_1_Task3.Properties;
using static System.Windows.Forms.AxHost;

namespace WinF_Lesson_1_Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool state = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            var ukTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime ukTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ukTimeZone);

            System.Windows.Forms.Timer timer = new();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += (s, e) => cityTimeLabel.Text = state ? DateTime.Now.ToLongTimeString() : ukTime.ToLongTimeString();
            

        }

        private void changeCityBtn_Click(object sender, EventArgs e)
        {
            state = !state;
            BackgroundImage = state ? Resources.Baku_City : Resources.London_City;
        }
    }
}