using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10eläimetjarajapinnat
{
    public class Lintu : Animal, ICanFly
    {
        protected int wingSize;

        public Lintu(string name, int wingSize) : base(name)
        {
            this.wingSize = wingSize;
        }

        public int WingSize
        {
            get { return wingSize; }
            set { wingSize = value; }
        }

        public int Fly()
        {
            return wingSize * 10;
        }
    }
}
