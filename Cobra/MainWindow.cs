namespace Cobra
{
    public partial class MainWindow : Form
    {
        private List<Circle> _Cobra = new List<Circle>();
        private Cobra _snake = new Cobra();
        private Circle _foodItem = new Circle();
        private int _maxWidth;
        private int _maxHeight;
        public int score;
        private bool goLeft, goRight, goUp, goDown;
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

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && _snake.currentDirection != "right")
            {
                goLeft = true;
            }
            else if (e.KeyCode == Keys.Right && _snake.currentDirection != "left")
            {
                goRight = true;
            }
            else if (e.KeyCode == Keys.Down && _snake.currentDirection != "up")
            {
                goDown = true;
            }
            else if (e.KeyCode == Keys.Up && _snake.currentDirection != "down")
            {
                goUp = true;
            }
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}