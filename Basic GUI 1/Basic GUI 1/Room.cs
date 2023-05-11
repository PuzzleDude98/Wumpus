using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public class Room
    {
        public int Id { get; set; }
        public List<Room> Connections { get; set; }
        public Hazard Hazard { get; set; }
        public Wumpus Wumpus { get; set; }
        
        public Room(int id)
        {
            Id = id;
            Connections = new List<Room>(id);
            
        }
        public void AddConnection(Room room)
        {
            if (!Connections.Contains(room))
            {
                Connections.Add(room);
            }
        }

        public void RemoveConnection(Room room)
        {
            Connections.Remove(room);
        }

        public bool IsConnected(Room room)
        {
            return Connections.Contains(room);
        }



    }
}
