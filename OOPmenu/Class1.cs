using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPmenu
{
    public class Menu
    {
        public string Nadpis = "";
        public ConsoleColor barvaokraje = ConsoleColor.Green;
        public ConsoleColor barvapozadi = ConsoleColor.Black;
        public ConsoleColor barvatextu = ConsoleColor.Yellow;
        public ConsoleColor barvaokurzoru = ConsoleColor.Blue;
        public int sirka = 25;
        public string[] polozky = new string[100];

        public void zobraz()
        {
            zobrazokraj();
            zobraznadpis();
            //zobrazkurzor();
            zobrazpolozky();
        }
        private void zobraznadpis()
        {
            Console.BackgroundColor = barvapozadi;
            Console.ForegroundColor = barvatextu;
            Console.SetCursorPosition(3, 1);
            Console.Write(Nadpis);
        }
        private void zobrazpolozky()
        {
            Console.BackgroundColor = barvapozadi;
            Console.ForegroundColor = barvatextu;
            //Console.SetCursorPosition(3, 3);
            //Console.Write(polozky[0]);
            //Console.SetCursorPosition(3, 4);
            //Console.Write(polozky[1]);
            //Console.SetCursorPosition(3, 5);
            //Console.Write(polozky[2]);
            //Console.SetCursorPosition(3, 6);
            //Console.Write(polozky[3]);
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(3, i + 3);
                Console.Write(polozky[i]);
            }
        }

        private void zobrazokraj()
        {
            Console.BackgroundColor = barvapozadi;
            Console.ForegroundColor = barvaokraje;
            Console.Write("╔");
            
            Console.Write(new String('═',sirka));

            Console.WriteLine("╗");
            Console.Write("║");
            Console.Write(new String(' ', sirka));
            Console.WriteLine("║");
            Console.Write("╠");
            Console.Write(new String('═', sirka));
            Console.WriteLine("╣");
            for (int i = 0; i < polozky.Length; i++)
            {
                Console.Write("║");
                Console.Write(new String(' ', sirka));
                Console.WriteLine("║");
            }
            Console.Write("╚");
            
            Console.Write(new String('═', sirka));
            Console.WriteLine("╝");





        }
    }
}