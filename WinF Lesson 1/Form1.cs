namespace WinF_Lesson_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
        }
        int locationStartX, locationStartY, locationEndX, locationEndY;
        int labelSize = 0;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                locationEndX = e.Location.X;
                locationEndY = e.Location.Y;

                if (Math.Abs(locationEndX - locationStartX) < 10 || Math.Abs(locationEndY - locationStartY) < 10)
                    MessageBox.Show("Minimal size is 10x10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {

                    Color randomColor = Color.FromArgb(Random.Shared.Next(256), Random.Shared.Next(256), Random.Shared.Next(256));

                    Label label = new Label
                    {
                        Size = new Size(locationEndX - locationStartX, locationEndY-locationStartY),
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = randomColor

                    };

                    label.Text  = (++labelSize).ToString();


                    var locationPoint = new Point(locationStartX < locationEndX ? locationStartX : locationEndY, locationStartY <locationEndY ? locationStartY : locationEndY);

                    label.Location = locationPoint;

                    label.MouseClick +=(s, e) =>
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            info_label.Text = $@"Location: {label.Location}
Area: {label.Location.X * label.Location.Y}";
                        }
                    };

                    label.MouseDoubleClick += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        (s as Label)?.Dispose();
                        --labelSize;
                    }
                };

                    Controls.Add(label);

                }
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                locationStartX = e.Location.X;
                locationStartY = e.Location.Y;

            }
        }
    }
}