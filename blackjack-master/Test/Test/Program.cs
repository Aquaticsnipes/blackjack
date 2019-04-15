using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestBtn());

            CardGroup deck = new CardGroup();

            deck.MakeWholeDeck();
            Console.WriteLine(deck.ToString());
            deck.Shuffle();
            Console.WriteLine("======================");
            Console.WriteLine(deck.ToString());
            Card tmp = deck.DealTopCard();
            Console.WriteLine("======================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine("======================");
            deck.AddToDeck(tmp);
            Console.WriteLine(deck.ToString());
        }
    }
}
