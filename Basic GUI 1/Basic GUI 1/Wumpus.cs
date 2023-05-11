using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public enum WumpusState
    {
        Asleep,
        Awake
    }
    public class Wumpus
    {
        public WumpusState State { get; private set; }

        public Wumpus()
        {
            State = WumpusState.Asleep;
        }

        public void WakeUp()
        {
            State = WumpusState.Awake;
        }

        public void FallAsleep()
        {
            State = WumpusState.Asleep;
        }
    }
}
