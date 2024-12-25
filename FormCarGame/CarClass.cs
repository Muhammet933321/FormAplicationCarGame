using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCarGame
{
    internal class CarClass
    {
        private static readonly Random rnd = new Random();

        CarCanDo carDoingWhat;
        public int position = 0;
        int possibility;
        public Color DidWhatColor;
        public bool IsGameEnd;
        public PlayerClass ownerPlayer;

        public CarClass(PlayerClass player)
        {
            position = 0;
            IsGameEnd = false;

            ownerPlayer = player;
        }

        public string MoveCar()
        {
            possibility = rnd.Next(0, 100);
            int carDoingWhat = rnd.Next(0, 4);
            if (carDoingWhat == 0 || carDoingWhat == 1 || carDoingWhat == 2)
            {
                if (possibility >= 66)
                {
                    position += 15;
                    if (position >= 100)
                    {
                        position = 100;
                        ownerPlayer.isWinGame = true;
                    }
                    DidWhatColor = Color.Green;
                    return GreateDo(carDoingWhat);
                    


                }
                else if (possibility >= 33)
                {
                    position += 10;
                    if (position >= 100)
                    {
                        position = 100;
                        ownerPlayer.isWinGame = true;
                    }
                    DidWhatColor = Color.FromArgb(128, 255, 0);
                    return NiceDo(carDoingWhat);
                }
                else
                {
                    position += 5;
                    if (position >= 100)
                    {
                        position = 100;
                        ownerPlayer.isWinGame = true;
                    }
                    DidWhatColor = Color.FromArgb(255, 128, 0);
                    return BadDo(carDoingWhat);
                }

            }
            else
            {
                if (position -5 < 0)
                {
                    position = 0;
                    return "Crash !!";
                }
                position -= 5;
                DidWhatColor = Color.Red;
                return "Crash !!";
            }

        }

        private string BadDo(int carDoingWhat)
        {
            if (carDoingWhat == 0)
            {
                return "Bad Nitro !!";
            }
            else if (carDoingWhat == 1)
            {
                return "Bad Rotate !!";
            }
            else if (carDoingWhat == 2)
            {
                return "Bad Breake !!";
            }
            return "What The ***";
        }
        private string NiceDo(int carDoingWhat)
        {
            if (carDoingWhat == 0)
            {
                return "Nice Nitro !!";
            }
            else if (carDoingWhat == 1)
            {
                return "Nice Rotate !!";
            }
            else if (carDoingWhat == 2)
            {
                return "Nice Breake !!";
            }
            return "What The ***";
        }
        private string GreateDo(int carDoingWhat)
        {
            if (carDoingWhat == 0)
            {
                return "Greate Nitro !!";
            }
            else if (carDoingWhat == 1)
            {
                return "Greate Rotate !!";
            }
            else if (carDoingWhat == 2)
            {
                return "Greate Breake !!";
            }
            return "What The ***";
        }



    }
}
