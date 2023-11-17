using Harjoitus9Radio_kt_;

internal class Program
{
    private static void Main(string[] args)
    {
        var radio = new Radio();
        radio.LisääKanava(new Kanava("Yle Puhe", 93.7));
        radio.LisääKanava(new Kanava("NRJ", 96.4));

        while (true)
        { //Käyttäjä kayttää komento ja vie sen paikalle
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1. Päälle");
            Console.WriteLine("2. Pois");
            Console.WriteLine("3. Säädä äänenvoimakkuutta");
            Console.WriteLine("4. Vaihda kanavaa");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    radio.Päälle();
                    break;
                case "2":
                    radio.Pois();
                    break;
                case "3":
                    Console.WriteLine("Anna äänenvoimakkuus (0-9):");
                    var volume = int.Parse(Console.ReadLine());
                    radio.SäädäÄänenvoimakkuus(volume);
                    break;
                case "4":
                    Console.WriteLine("Anna taajuus (88.0-107.9):");
                    var frequency = double.Parse(Console.ReadLine());
                    radio.VaihdaKanava(frequency);
                    break;
                default:
                    Console.WriteLine("Virheellinen syöte");
                    break;
            }
        }
    }
}