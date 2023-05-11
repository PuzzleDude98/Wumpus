using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Game
    {
        private Player player;
        private int wumpusRoom;

        public Game(int startingArrows, int startingRoom, int wumpusRoom)
        {
            player = new Player(startingArrows, startingRoom);
            this.wumpusRoom = wumpusRoom;
        }

        // Other game properties and methods...

        public bool ShootArrow(int targetRoom)
        {
            // Check if the player has arrows
            if (player.Arrows <= 0)
            {
                // Handle the case where the player is out of arrows
                return false;
            }

            player.UseArrow();

            // Check if the target room is the Wumpus room
            if (targetRoom == wumpusRoom)
            {
                // Handle the case where the Wumpus is killed
                return true;
            }
            else
            {
                // Handle the case where the arrow misses
                
                return false;
            }
        }
        // Other game properties and methods...
        public int GetPlayerRoom()
        {
            return player.Room;
        }

        public void MovePlayer(int newRoom)
        {
           //can add validation here to make sure the newRoom is valid and adjacent to the player's current room
            player.Move(newRoom);
        }
    }
}
