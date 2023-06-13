namespace Cobra
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            lblGameOver.Visible = false;
        }
        private void GameTimerEvent(object sender, EventArgs e)
        { 

        }
        private void Restart()
        {

        }
        private void EatItem()
        {

        }
        private void GameOver()
        {
            lblGameOver.Visible = true;
        }
    }
}