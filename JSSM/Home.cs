using JSSM.Commands;

namespace JSSM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SetMsgStatus();
        }

        public void SetMsgStatus()
        {
            var msg = GetStatusService.StatusService;

            labelStatus.Text = msg;
            labelStatus.ForeColor = Color.White;
            if (msg == "Running")
            {
                labelStatus.BackColor = Color.Green;
            }
            else
            {
                labelStatus.BackColor = Color.Red;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartService.Start();
            SetMsgStatus();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StopService.Stop();
            SetMsgStatus();
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            RestartService.Restart();
            SetMsgStatus();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SetMsgStatus();
        }
    }
}