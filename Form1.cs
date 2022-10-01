using System.Drawing.Text;

namespace AISHackathon
{
    public partial class Form1 : Form
    {
        DateTime pomodoro_time = new DateTime();
        DateTime break_time = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "On DND"){
                //Switch on DND
                button5.Text = "Off DND";
            }
            else {
                //Switch off DND
                button5.Text = "On DND";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "Start") {                
                timer1.Start();               
            }
            else {
                timer1.Stop();
                pomodoro_time = new DateTime();
                timer2.Stop();
                break_time = new DateTime();
                button9.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pomodoro_time = pomodoro_time.AddSeconds(1);
            button9.Text = pomodoro_time.ToString("mm:ss");
            if (pomodoro_time.Equals(new DateTime().AddMinutes(25)))
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            break_time.AddSeconds(1);
            button9.Text = "Break: " + break_time.ToString("mm:ss");
            if (break_time.Equals(new DateTime().AddMinutes(5)))
            {
                timer2.Stop();
                button9.Text = "Start";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form2 form2 = 
        }
    }
}