using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Player
    {
        public int Arrows { get; private set; }
        public int Room { get; private set; }

        public Player(int startingArrows, int startingRoom)
        {
            Arrows = startingArrows;
            Room = startingRoom;
        }

        public void Move(int newRoom)
        {
            Room = newRoom;
        }

        public void UseArrow()
        {
            Arrows--;
        }
    }
}
