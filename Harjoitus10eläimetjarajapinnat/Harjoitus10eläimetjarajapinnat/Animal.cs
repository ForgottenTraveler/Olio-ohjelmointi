using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10eläimetjarajapinnat
{
    public abstract class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public virtual string MakeASound()
        {
            return "Ääni";
        }
    }

    // ICanFly-rajapinta
    public interface ICanFly
    {
        int WingSize { get; set; }
        int Fly();
    }

    // ICanSwim-rajapinta
    public interface ICanSwim
    {
        int SwimSpeed { get; set; }
        int Swim();
    }
}
