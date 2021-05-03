
//Dedicated with love to my dear daughter, for better days
//تقدیم با عشق به دختر عزیزم نیایش ، برای روزهای بهتر

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Nationality_Recognition_Game
{
    public partial class Main : Form
    {
        private int _windowHeight, _windowWidth;
        private bool _isDragging;
        private int _currentX, _currentY;
        private int _pictureBoxLeft, _pictureBoxTop;
        private const int TimeToDropThePhoto = 3000;
        private int _rangeOfMotion = 20;
        private int _numberOfRepetitionsPerGame;
        private int _numberOfGames;
        private int _score = 0;
        private readonly Random _random = new Random();
        private operators Operators { get; }
        private PictureBox _myPictureBox;
        private List<PersonNationality> _personNationalities;
        private PersonNationality selectedNationality;

        public Main()
        {
            InitializeComponent();

            CenterToScreen();

            Operators = new operators();

            _personNationalities = new List<PersonNationality>
            {
                new PersonNationality{Id = 1,Nationality = Nationality.Japanese,Image = @"\Picture\1-Japanese.jpg"},
                new PersonNationality{Id = 2,Nationality = Nationality.Chinese,Image = @"\Picture\2-Chinese.jpg"},
                new PersonNationality{Id = 3,Nationality = Nationality.Korean,Image = @"\Picture\3-Korean.jpg"},
                new PersonNationality{Id = 4,Nationality = Nationality.Thai,Image = @"\Picture\4-Thai.jpg"},
                new PersonNationality{Id = 5,Nationality = Nationality.Korean,Image = @"\Picture\5-Korean.jpg"},
                new PersonNationality{Id = 6,Nationality = Nationality.Japanese,Image = @"\Picture\6-Japanese.jpg"},
                new PersonNationality{Id = 7,Nationality = Nationality.Thai,Image = @"\Picture\7-Thai.jpg"},
                new PersonNationality{Id = 8,Nationality = Nationality.Chinese,Image = @"\Picture\8-Chinese.jpg"}
            };

        }

        private void Main_Load(object sender, EventArgs e)
        {
            GetFromSize();
            _numberOfRepetitionsPerGame = _personNationalities.Count;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            GetFromSize();
        }


        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Initialization();
            StartGame();
        }


        private void Initialization()
        {
            this.btnStartGame.Visible = false;
            this.RulesBox.Visible = false;
            JapaneseBox.Visible = true;
            ChineseBox.Visible = true;
            KoreanBox.Visible = true;
            ThaiBox.Visible = true;
            _score = 0;
            lblScore.Text = _score.ToString();
            RefreshFromUI();
            Thread.Sleep(1000);
        }

        private void StartGame()
        {
            _numberOfGames++;
            if (_numberOfGames > _numberOfRepetitionsPerGame)
            {
                AvengersEndGame();
                return;
            }

            selectedNationality = _personNationalities[_random.Next(0, _personNationalities.Count)];

            _myPictureBox = new PictureBox
            {
                Name = "myPictureBox",
                Size = new Size(123, 147),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Image = Image.FromFile($"{Application.StartupPath}{selectedNationality.Image}"),

            };

            _myPictureBox.Location = new Point((_windowWidth / 2) - (_myPictureBox.Width / 2), 0);
            _myPictureBox.MouseDown += new MouseEventHandler(MyPictureBox_MouseDown);
            _myPictureBox.MouseUp += new MouseEventHandler(MyPictureBox_MouseUp);
            _myPictureBox.MouseMove += new MouseEventHandler(MyPictureBox_MouseMove);
            _myPictureBox.MouseHover += new EventHandler(MyPictureBox_MouseEnter);


            Controls.Add(_myPictureBox);
            _myPictureBox.BringToFront();
            PanelScore.BringToFront();
            MovingTimer.Enabled = true;

        }

        private void AvengersEndGame()
        {
            JapaneseBox.Visible = false;
            ChineseBox.Visible = false;
            KoreanBox.Visible = false;
            ThaiBox.Visible = false;

            _numberOfGames = 0;
            this.RulesBox.Visible = true;
            this.btnStartGame.Visible = true;
        }

        private void MyPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            _myPictureBox.AllowDrop = false;

            if (_myPictureBox.Top <= _pictureBoxTop - _rangeOfMotion && _myPictureBox.Left <= _pictureBoxLeft - _rangeOfMotion)
            {
                MoveToBox(JapaneseBox, Operators._opGreaterThan, Operators._opGreaterThan, Operators.opMinus, Operators.opMinus);
            }
            else if (_myPictureBox.Top <= _pictureBoxTop - _rangeOfMotion && _myPictureBox.Left >= _pictureBoxLeft - _rangeOfMotion)
            {
                MoveToBox(ChineseBox, Operators._opLessThan, Operators._opGreaterThan, Operators.opPlus, Operators.opMinus);
            }
            else if (_myPictureBox.Top >= _pictureBoxTop - _rangeOfMotion && _myPictureBox.Left >= _pictureBoxLeft - _rangeOfMotion)
            {
                MoveToBox(ThaiBox, Operators._opLessThan, Operators._opLessThan, Operators.opPlus, Operators.opPlus);
            }
            else if (_myPictureBox.Top >= _pictureBoxTop - _rangeOfMotion && _myPictureBox.Left <= _pictureBoxLeft - _rangeOfMotion)
            {
                MoveToBox(KoreanBox, Operators._opGreaterThan, Operators._opLessThan, Operators.opMinus, Operators.opPlus);
            }
        }
        private void MyPictureBox_MouseEnter(object sender, EventArgs e)
        {
            _myPictureBox.Cursor = Cursors.Hand;
        }
        private void MyPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _currentX = e.X;
            _currentY = e.Y;

            _pictureBoxTop = _myPictureBox.Top;
            _pictureBoxLeft = _myPictureBox.Left;
        }
        private void MyPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                _myPictureBox.Top = _myPictureBox.Top + (e.Y - _currentY);
                _myPictureBox.Left = _myPictureBox.Left + (e.X - _currentX);
            }

        }

        private void MoveToBox(GroupBox box, Func<int, int, bool> operatorX, Func<int, int, bool> operatorY,
            Func<int, int, int> opAddOrSubtractX, Func<int, int, int> opAddOrSubtractY)
        {
            var boxLocationX = box.Location.X + 25;
            var boxLocationY = box.Location.Y + 25;

            while (operatorX(_myPictureBox.Location.X, boxLocationX) || operatorY(_myPictureBox.Location.Y, boxLocationY))
            {
                if (operatorX(_myPictureBox.Location.X, boxLocationX))
                    _myPictureBox.Location = new Point(opAddOrSubtractX(_myPictureBox.Location.X, 1), _myPictureBox.Location.Y);

                if (operatorY(_myPictureBox.Location.Y, boxLocationY))
                    _myPictureBox.Location = new Point(_myPictureBox.Location.X, opAddOrSubtractY(_myPictureBox.Location.Y, 1));

                RefreshFromUI();
            }

            GetResult(box);

        }

        private void GetResult(GroupBox box)
        {
            for (int i = 100; i > 10; i -= 2)
            {
                Thread.Sleep(1);
                _myPictureBox.Image = ImageUtils.ImageTransparency.ChangeOpacity(_myPictureBox.Image, (float)i / 100);  
                RefreshFromUI();
            }

            switch (box.Name)
            {
                case "JapaneseBox" when selectedNationality.Nationality == Nationality.Japanese:
                    ShowResult(box, ResultType.success, 20);
                    break;
                case "ChineseBox" when selectedNationality.Nationality == Nationality.Chinese:
                    ShowResult(box, ResultType.success, 20);
                    break;
                case "KoreanBox" when selectedNationality.Nationality == Nationality.Korean:
                    ShowResult(box, ResultType.success, 20);
                    break;
                case "ThaiBox" when selectedNationality.Nationality == Nationality.Thai:
                    ShowResult(box, ResultType.success, 20);
                    break;
                default:
                    {
                        ShowResult(box, ResultType.fail, -5);
                        break;
                    }
            }

            lblScore.Text = _score.ToString();
            this.Controls.Remove(_myPictureBox);
            _myPictureBox.Dispose();
            RefreshFromUI();
            StartGame();
        }

        private void ShowResult(GroupBox box, ResultType resultType, int score)
        {
            _score += score;

            string resultImageName = string.Empty;

            if (resultType == ResultType.fail)
                resultImageName = "\\img\\fail.jpg";
            else if (resultType == ResultType.success)
                resultImageName = "\\img\\pass.jpg";


            var resultPictureBox = new PictureBox
            {
                Name = "resultPictureBox",
                Size = new Size(146, 112),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile($"{Application.StartupPath}{resultImageName}"),
                Location = new Point(box.Location.X + 5, box.Location.Y + 40)
            };

            Controls.Add(resultPictureBox);
            resultPictureBox.BringToFront();
            for (int i = 100; i > 10; i -= 2)
            {
                resultPictureBox.Image = ImageUtils.ImageTransparency.ChangeOpacity(resultPictureBox.Image, (float)i / 100);    
                RefreshFromUI();
                Thread.Sleep(10);
            }

            this.Controls.Remove(resultPictureBox);
            resultPictureBox.Dispose();
        }

        private void MovingTimer_Tick(object sender, EventArgs e)
        {
            int step = (int)Math.Ceiling(Convert.ToDecimal(_windowHeight) / (TimeToDropThePhoto / 10));

            if (_isDragging)
                MovingTimer.Enabled = false;

            if (_myPictureBox.Location.Y < this.Height - 100)
            {
                _myPictureBox.Location = new Point((_windowWidth / 2) - (_myPictureBox.Width / 2), _myPictureBox.Location.Y + step);
                RefreshFromUI();
                Thread.Sleep(10);

            }
            else
            {
                MovingTimer.Enabled = false;
                this.Controls.Remove(_myPictureBox);
                _myPictureBox.Dispose();
                StartGame();
            }

        }

        private void RefreshFromUI()
        {
            this.Invalidate();
            Application.DoEvents();
        }


        private void GetFromSize()
        {
            _windowHeight = this.Height;
            _windowWidth = this.Width;
        }

    }
}
