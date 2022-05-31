using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_20_The_Properties_of_Arrows
{ 

    class Dialoge
    {
        static public void Greeting()
        {
            Console.Write("Good day, fine sir. Thank you for choosing Vin Fletches' Arrows for your arrow needs. " +
                "\nHow many arrows will you be requiring today? ");
        }

        static public void FirstMenuIntroduction()
        {
            Console.WriteLine("\nHere at Vin Fletches' we only build custom ordered arrows. Here is our menu of arrow components.\nYou can select the arrowhead, fletching, and length that you prefer.");
        }

        static public void ShaftOrder()
        {
            string[] superlatives = { "amazing", "awesome", "marvelous", "stunning", "incredible", "wonderful", "stupendous" };
            Random rnd = new Random();
            int RandomNumber = rnd.Next(6);
            Console.Write($"\nOh my, I can tell this is going to be one of my {superlatives[RandomNumber]} What type of shaft would you like on this arrow? ");
        }

        static public void ArrowheadOrder()
        {
            Console.Write("\n What type of arrow head would you like on this arrow? ");
        }

        static public void ArrowHeadError()
        {
            Console.WriteLine("\nI'm sorry, sir, but that material is not available to us. Please select anoter from the menu.");
        }

        static public void FletchingOrder()
        {
            string[] superlatives = { "amazing", "awesome", "marvelous", "stunning", "incredible", "wonderful", "stupendous" };
            Random rnd = new Random();
            int RandomNumber = rnd.Next(6);
            Console.Write($"\nWow, {superlatives[RandomNumber]} arrowhead choice! What type of fletching would you like on this arrow? ");
        }

        static public void AnotherArrow()
        {
            Console.WriteLine("Let's get to work selecting your next arrow.");
        }

        static public void dashedLine()
        {

            Console.WriteLine("------------------------------------------------------------------------------------------------");
        }



    }

}