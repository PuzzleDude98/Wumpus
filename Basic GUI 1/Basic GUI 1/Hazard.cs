using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public enum HazardType
    {
        None,
        BottomlessPit,  
        SuperBat,
        Wumpus
    }
    public class Hazard
    {
        private int wumpusRoom;
        private int batRoom;
        private int pitRoom;
        private int none;
        
        public List<Room> Connections { get; set; }
        public HazardType Type { get; private set; }
        public string HazardMessage { get; set; }

        public Hazard(HazardType type)
        {
            Type = type;
        }
        public string GetWarnings(Room room)   
        {

            for(int i = 0; i < room.Connections.Count; i++)
            {
                
                
                Room connection = Connections[i];
                
                if (connection.Id == wumpusRoom)
                {
                    HazardMessage += "Wumpus is close\n";
                }
                else if (connection.Id == batRoom)
                {
                    HazardMessage += "Bat is close\n";
                }
                else if (connection.Id == pitRoom)
                {
                    HazardMessage += "Pit is close\n";
                }
                else if (connection.Id == none)
                {
                    HazardMessage += "";
                }
                
                
                
            }
            return HazardMessage;
            
        }
    }
}
