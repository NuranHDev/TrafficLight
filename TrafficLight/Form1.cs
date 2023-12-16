namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RedLight.Visible = true;
            YellowLight.Visible = false;
            GreenLight.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RedLight.Visible == true)
            {
                RedLight.Visible = false;
                YellowLight.Visible = false;
                GreenLight.Visible = true;
            }
            else if (GreenLight.Visible == true)
            {
                RedLight.Visible = false;
                YellowLight.Visible = true;
                GreenLight.Visible = false;

            }
            else if (YellowLight.Visible == true)
            {
                RedLight.Visible = true;
                YellowLight.Visible = false;
                GreenLight.Visible = false;
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}