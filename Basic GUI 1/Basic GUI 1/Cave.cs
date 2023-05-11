using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public class Cave
    {
        private const int RoomCount = 30;
        private readonly Room[] rooms;
        private int playerLocation;
        private int wumpusLocation;
        private readonly List<int> hazardLocations;

        public List<Room> Rooms { get; private set; }

        public Cave()
        {
            //random = new Random();
            //rooms = new Room[RoomCount];
            //hazaedLocations = new List<int>();

            //InitializeRooms();
            //PlaceHazards();
            //PlaceWumpus();
            //PlacePlayer();
            Rooms = new List<Room>();
        }
        public void GenerateCave(int roomCount)
        {
            // Create rooms
            for (int i = 0; i < roomCount; i++)
            {
                Rooms.Add(new Room(i + 1));
            }

            // Connect rooms (you need to implement the logic to connect rooms)
            // Example: ConnectRooms(Rooms[0], Rooms[1]);
        }

        public void ConnectRooms(Room roomA, Room roomB)
        {
            roomA.AddConnection(roomB);
            roomB.AddConnection(roomA);
        }

        public List<Room> GetAdjacentRooms(int roomId)
        {
            Room room = Rooms.Find(r => r.Id == roomId);
            return room?.Connections;
        }

        //public string GetHint()
        //{
        //    // Provide hints to the player
        //}
        public void ShootArrow(int room)
        {
            // implement arrow shooting logic
        }
        //public string CheckWarnings()
        //{
        //    // Check for any warning in the neighboring rooms
        //}
        public void MoveWumpus()
        {
            // Move the Wumpus to a neighboring room
        }
        public void MovePlayer()
        {
            // Move the player to the specified room and check for hazards or the Wumpus
        }
        public void PlacePlayer()
        {
            // place the player in a random room that doesn't contain hazards or the Wumpus
        }
        private void PlaceHazards()
        {
            // Place hazards in random rooms
        }
        private void InitializeRooms()
        {
            //Create rooms and set their neighbors
        }


    }
}
