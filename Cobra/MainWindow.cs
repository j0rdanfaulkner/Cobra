namespace Cobra
{
    public partial class MainWindow : Form
    {
        private List<Circle> _Cobra = new List<Circle>();
        private Cobra _snake = new Cobra();
        private Circle _item = new Circle();
        private int _maxWidth;
        private int _maxHeight;
        public int score;
        private bool goLeft, goRight, goUp, goDown;
        private Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
            lblGameOver.Visible = false;
            StartGame();
        }
        private void StartGame()
        {
            Restart();
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft == true)
            {
                _snake.currentDirection = "left";
            }
            else if (goRight == true)
            {
                _snake.currentDirection = "right";
            }
            else if (goUp == true)
            {
                _snake.currentDirection = "up";
            }
            else if (goDown == true)
            {
                _snake.currentDirection = "down";
            }
            for (int i = _Cobra.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (_snake.currentDirection)
                    {
                        case "left":
                            _Cobra[i].X--;
                            break;
                        case "right":
                            _Cobra[i].X++;
                            break;
                        case "up":
                            _Cobra[i].Y--;
                            break;
                        case "down":
                            _Cobra[i].Y++;
                            break;
                        default:
                            break;
                    }
                    if (_Cobra[i].X < 0)
                    {
                        _Cobra[i].X = _maxWidth;
                    }
                    else if (_Cobra[i].X > _maxWidth)
                    {
                        _Cobra[i].X = 0;
                    }
                    else if (_Cobra[i].Y < 0)
                    {
                        _Cobra[i].Y = _maxHeight;
                    }
                    else if (_Cobra[i].Y > _maxHeight)
                    {
                        _Cobra[i].Y = 0;
                    }
                    else if (_Cobra[i].X == _item.X && _Cobra[i].Y == _item.Y)
                    {
                        EatItem();
                    }
                }
                else
                {
                    _Cobra[i].X = _Cobra[i - 1].X;
                    _Cobra[i].Y = _Cobra[i - 1].Y;
                }
                pbxCanvas.Invalidate();
            }
        }
        private void Restart()
        {
            _maxWidth = pbxCanvas.Width / _snake.Width - 1;
            _maxHeight = pbxCanvas.Height / _snake.Height - 1;
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
            _item = new Circle { X = r.Next(2, _maxWidth), Y = r.Next(2, _maxHeight) };
            tmrTimer.Start();
        }
        private void EatItem()
        {
            score += 100;
            lblScore.Text = "Score: " + score;
            Circle body = new Circle
            {
                X = _Cobra[_Cobra.Count - 1].X,
                Y = _Cobra[_Cobra.Count - 1].Y
            };
            _Cobra.Add(body);
            _item = new Circle { X = r.Next(2, _maxWidth), Y = r.Next(2, _maxHeight) };
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
                        _item.X * _snake.Width,
                        _item.Y * _snake.Height,
                        _snake.Width,
                        _snake.Height
                    ));
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            _maxWidth = pbxCanvas.Width / _snake.Width - 1;
            _maxHeight = pbxCanvas.Height / _snake.Height - 1;
        }
    }
}