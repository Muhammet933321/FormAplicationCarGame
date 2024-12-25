using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCarGame
{
    public partial class GameScene : Form
    {
        System.Timers.Timer timer;

        PlayerClass player1;
        PlayerClass player2;

        float CountDownTime = 0f;
        float TriggerTimer = 1;

        bool isGameEnd;
        public GameScene()
        {
            
            InitializeComponent();

            player1 = new PlayerClass("Player1");
            player2 = new PlayerClass("Player2");

            player1.car = new CarClass(player1);
            player2.car = new CarClass(player2);

            Player1label.Text = "";
            Player2label.Text = "";

            isGameEnd = false;
        }


        private void TimerEvent(object sender, EventArgs e)
        {
            CountDownTime ++;
            if (TriggerTimer < CountDownTime && !isGameEnd)
            {
                CountDownTime = 0;
                Player1label.Text = player1.car.MoveCar();
                Player2label.Text = player2.car.MoveCar();

                Player1Slide.Value = player1.car.position;
                Player2Slide.Value = player2.car.position;

                Player1label.ForeColor = player1.car.DidWhatColor;
                Player2label.ForeColor = player2.car.DidWhatColor;

                if (player1.isWinGame)
                {
                    if (player2.isWinGame)
                    {
                        isGameEnd = true;
                        MessageBox.Show("DRAW !!");
                        
                        return;
                    }
                    isGameEnd = true;
                    MessageBox.Show(player2.name + " WIN !!!");
                    return;
                }
                else if (player2.isWinGame)
                {
                    isGameEnd = true;
                    MessageBox.Show(player1.name + " WIN !!!");
                    return;
                }

            }
            
        }
        
        private void GameScene_Load(object sender, EventArgs e)
        { 
            gameTimer.Start();
        }
    }
}
