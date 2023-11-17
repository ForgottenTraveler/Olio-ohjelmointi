using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9Radio_kt_
{
    internal class Radio
    {
        private bool _isOn;
        private int _volume;
        private double _frequency;
        private List<Kanava> _kanavat = new List<Kanava>();

        public void Päälle()
        { //laittaa radio päälle
            _isOn = true;
            Console.WriteLine("Radio päällä");
        }

        public void Pois()
        { //laittaa radion poist päältä
            _isOn = false;
            Console.WriteLine("Radio pois päältä");
        }

        public void SäädäÄänenvoimakkuus(int volume)
        { //Säädää radion äänivoimakkuus
            if (volume >= 0 && volume <= 9)
            {
                _volume = volume;
                Console.WriteLine($"Äänenvoimakkuus asetettu {_volume}");
            }
            else
            {
                Console.WriteLine("Virheellinen äänenvoimakkuus");
            }
        }

        public void VaihdaKanava(double frequency)
        { //Vaihdaa radion kanava
            if (frequency >= 88.0 && frequency <= 107.9)
            {
                foreach (var kanava in _kanavat)
                {
                    if (kanava.Taajuus == frequency)
                    {
                        Console.WriteLine($"Kanava {kanava.Nimi} löytyi taajuudella {frequency}");
                        break;
                    }
                }

                _frequency = frequency;
                Console.WriteLine($"Taajuus vaihdettu {_frequency}");
            }
            else
            {
                Console.WriteLine("Virheellinen taajuus");
            }
        }

        public void LisääKanava(Kanava kanava)
        {
            _kanavat.Add(kanava);
        }

    }
}
