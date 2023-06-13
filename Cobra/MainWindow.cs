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
        private Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
            lblGameOver.Visible = false;
        }
        private void StartGame()
        {
            Restart();
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            
        }
        private void Restart()
        {
            _maxWidth = pnlGameArea.Width / _snake.Width - 1;
            _maxHeight = pnlGameArea.Height / _snake.Height - 1;
            _Cobra.Clear();
            score = 0;
            lblScore.Text = "Score :" + score;
            Circle head = new Circle { X = 10, Y = 5 };
            _Cobra.Add(head);
            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                _Cobra.Add(body);
            }
            _foodItem = new Circle { X = r.Next(2, _maxWidth), Y = r.Next(2, _maxHeight) };
            tmrTimer.Start();
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
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }
        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush cobraColour;
            for (int i = 0; i < _Cobra.Count; i++)
            {
                if (i == 0)
                {
                    cobraColour = Brushes.Black;
                }
                else
                {
                    cobraColour = Brushes.Olive;
                }
                canvas.FillEllipse(cobraColour, new Rectangle
                    (
                        _Cobra[i].X * _snake.Width,
                        _Cobra[i].Y * _snake.Height,
                        _snake.Width,
                        _snake.Height
                    ));
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                    (
                        _foodItem.X * _snake.Width,
                        _foodItem.Y * _snake.Height,
                        _snake.Width,
                        _snake.Height
                    ));
        }
    }
}