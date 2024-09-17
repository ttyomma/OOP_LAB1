using System;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class MainForm : Form
    {
        private Timer gameTimer;
        private int timeCount;
        private int clickCount;
        private bool gameStarted = false;

        public MainForm()
        {
            InitializeComponent();
            buttonClick.Enabled = true;
        }

        private void UpdateUI()
        {
            time.Text = $"{timeCount}";
            clicks.Text = $"Кількість кліків: {clickCount}";
            buttonClick.Enabled = timeCount > 0;
        }

        private void StartGame()
        {
            timeCount = 15;
            clickCount = 0;
            UpdateUI();

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += (sender, e) =>
            {
                timeCount--;
                UpdateUI();

                if (timeCount == 0) 
                {
                    EndGame();
                }
            };

            gameTimer.Start();
            buttonClick.Enabled = true;
        }

        private void EndGame()
        {
            gameTimer.Stop();
            MessageBox.Show($"Час вийшов!\nВаш результат: {clickCount}.", "Гра закінчена");
            gameStarted = false;
            buttonClick.Enabled = true;
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                gameStarted = true;
                StartGame();
            }
            clickCount++;
            UpdateUI();
        }
    }
}