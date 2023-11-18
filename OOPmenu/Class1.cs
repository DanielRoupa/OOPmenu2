using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPmenu
{
    public enum barvy
    {
        ZLUTA,
        MODRA,
        CERVENA,
        BILA,
        CERNA,
        ZELENA
    }


    public class Menu
    {
        public string Nadpis = "";
        public int sirka = 25;
        public List<(string polozka, barvy barva)> polozky = new List<(string, barvy)>();

        public ConsoleColor barvaokraje = ConsoleColor.Green;
        public ConsoleColor barvapozadi = ConsoleColor.Black;
        public ConsoleColor barvatextu = ConsoleColor.Yellow;
        public ConsoleColor barvaokurzoru = ConsoleColor.Blue;

        private static readonly Dictionary<barvy, ConsoleColor> mapaBarev = new Dictionary<barvy, ConsoleColor>
        {
            { barvy.CERVENA, ConsoleColor.Red },
            { barvy.ZELENA, ConsoleColor.Green },
            { barvy.MODRA, ConsoleColor.Blue },
            { barvy.CERNA, ConsoleColor.Black },
            { barvy.ZLUTA, ConsoleColor.Yellow },
            { barvy.BILA, ConsoleColor.White }
        };


        public void zobraz()
        {
            zobrazOkraj();
            zobrazNadpis();
            zobrazPolozky();
        }
        private void zobrazNadpis()
        {
            Console.BackgroundColor = barvapozadi;
            Console.ForegroundColor = barvatextu;
            Console.SetCursorPosition(3, 1);
            Console.Write(Nadpis);
        }
        private void zobrazPolozky()
        {
            for (int i = 0; i < polozky.Count; i++)
            {
                Console.SetCursorPosition(3, i + 3);
                Console.ForegroundColor = PrevodDoConsoleBarvy(polozky[i].barva);
                Console.Write(polozky[i].polozka);
            }

        }
        private void zobrazOkraj()
        {
            Console.BackgroundColor = barvapozadi;
            Console.ForegroundColor = barvaokraje;
            // Záhlaví
            Console.WriteLine($"╔{new string('═', sirka)}╗");
            Console.WriteLine($"║{new string(' ', sirka)}║");
            Console.WriteLine($"╠{new string('═', sirka)}╣");

            // Okraj mění délku podle počtu položek v polozky
            for (int i = 0; i < polozky.Count; i++) Console.WriteLine($"║{new string(' ', sirka)}║");

            // Zápatí
            Console.WriteLine($"╚{new string('═', sirka)}╝");
        }

        public static ConsoleColor PrevodDoConsoleBarvy(barvy color)
        {
            if (mapaBarev.TryGetValue(color, out ConsoleColor consoleColor))return consoleColor;
            throw new ArgumentException("Barva neexistuje", nameof(color));
        }

    }


}