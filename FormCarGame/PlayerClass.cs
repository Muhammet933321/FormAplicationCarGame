using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCarGame
{
    internal class PlayerClass
    {
        public string name;
        public CarClass car;
        public bool isWinGame;

        public PlayerClass(string name)
        {
            this.name = name;
        }
        public PlayerClass()
        {

        }
    }
}
