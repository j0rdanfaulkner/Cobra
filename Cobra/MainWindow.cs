using System.DirectoryServices.ActiveDirectory;
using static System.Runtime.CompilerServices.RuntimeHelpers;

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
        private const int _SLOW = 45;
        private const int _DEFAULT = 30;
        private const int _FAST = 15;
        public MainWindow()
        {
            InitializeComponent();
            lblGameOver.Visible = false;
            btnRestart.Text = "START";
            tmrTimer.Interval = _DEFAULT;
            tbrSpeed.Value = _DEFAULT;
        }
        /// <summary>
        /// method used to start the first instance of the game by calling the 'Restart' method
        /// </summary>
        private void StartGame()
        {
            Restart();
        }
        /// <summary>
        /// updates the game canvas every interval of the timer, showing when a food item is eaten or when the snake changes direction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    for (int j = 1; j < _Cobra.Count; j++)
                    {
                        if (_Cobra[i].X == _Cobra[j].X && _Cobra[i].Y == _Cobra[j].Y)
                        {
                            GameOver();
                        }
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
        /// <summary>
        /// resets the game area back to original settings (e.g. resets the score to 0 and the body length of the snake to 10)
        /// </summary>
        private void Restart()
        {
            lblGameOver.Visible = false;
            _maxWidth = pbxCanvas.Width / _snake.Width - 1;
            _maxHeight = pbxCanvas.Height / _snake.Height - 1;
            _Cobra.Clear();
            score = 0;
            lblScore.Text = "SCORE: " + score;
            Circle head = new Circle { X = 10, Y = 5 };
            _Cobra.Add(head);
            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                _Cobra.Add(body);
            }
            _item = new Circle { X = r.Next(2, _maxWidth), Y = r.Next(2, _maxHeight) };
            tmrTimer.Start();
            btnRestart.Enabled = false;
        }
        /// <summary>
        /// adds 100 to the current score and a new body section to the snake for each food item that is eaten
        /// </summary>
        private void EatItem()
        {
            score += 100;
            lblScore.Text = "SCORE: " + score;
            Circle body = new Circle
            {
                X = _Cobra[_Cobra.Count - 1].X,
                Y = _Cobra[_Cobra.Count - 1].Y
            };
            _Cobra.Add(body);
            _item = new Circle { X = r.Next(2, _maxWidth), Y = r.Next(2, _maxHeight) };
        }
        /// <summary>
        ///  ends the current game by stopping the timer and sets the start/restart button text to 'restart'
        /// </summary>
        private void GameOver()
        {
            tmrTimer.Stop();
            lblGameOver.Visible = true;
            btnRestart.Enabled = true;
            btnRestart.Text = "RESTART";
        }
        /// <summary>
        /// checks to see which arrow key was pressed and what direction the current direction needs to be changed to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            CheckArrowKeysPressed(sender, e);
        }
        /// <summary>
        /// resets the direction variable depending on the last arrow key that was released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            CheckArrowKeysRelease(sender, e);
        }
        /// <summary>
        /// draws the snake and food item to the game canvas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// resets the max width and height of the game area when the main window is resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Resize(object sender, EventArgs e)
        {
            _maxWidth = pbxCanvas.Width / _snake.Width - 1;
            _maxHeight = pbxCanvas.Height / _snake.Height - 1;
        }
        /// <summary>
        /// trigger event for the start/restart game button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (btnRestart.Text == "START")
            {
                StartGame();
            }
            else if (btnRestart.Text == "RESTART")
            {
                Restart();
            }
        }
        /// <summary>
        /// sets the speed of the cobra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbrSpeed_Scroll(object sender, EventArgs e)
        {
            tmrTimer.Interval = tbrSpeed.Value;
        }
        private void tbrSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            CheckArrowKeysPressed(sender, e);
        }
        private void tbrSpeed_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            CheckArrowKeysRelease(sender, e);
        }
        private void CheckArrowKeysPressed(object sender, KeyEventArgs e)
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
        private void CheckArrowKeysRelease(object sender, KeyEventArgs e)
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
    }
}