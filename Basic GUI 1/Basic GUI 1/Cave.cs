using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace _2023975_Mejia_CaveSystem
{
    public class Cave
    {

        public byte[,] CaveRoute { get; set; }


        public Cave(byte RouteNum)
        {
            CaveRoute = (byte[,])Deserialize("CaveRoute" + RouteNum.ToString() + ".txt");
        }

        byte[,] CavePath = new byte[31, 3];

        public static object Deserialize(string path)
        {
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                return bformatter.Deserialize(stream);
            }
        }

        public byte[] GetExits(int index)
        {
            byte[] exits = new byte[3];
            exits[0] = CavePath[index, 0];
            exits[1] = CavePath[index, 1];
            exits[2] = CavePath[index, 2];  
            return exits;
        }

       
    }
}

       