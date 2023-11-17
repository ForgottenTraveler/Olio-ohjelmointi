using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10eläimetjarajapinnat
{
    public class Kala : Animal, ICanSwim
    {
        protected int swimSpeed;
        //Kala tiedot
        public Kala(string name, int swimSpeed) : base(name)
        {
            this.swimSpeed = swimSpeed;
        }

        public int SwimSpeed
        {
            get { return swimSpeed; }
            set { swimSpeed = value; }
        }

        public int Swim()
        {
            return swimSpeed;
        }
    }
}
