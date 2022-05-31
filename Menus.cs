using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_20_The_Properties_of_Arrows
{
    class Menus
    {
        //menu
        static private string _menu = "------------------------------------------------------------------------------------------------" +
                               "\n|      Arrow Heads          |          Arrow Fletchings          |          Shaft Lenth        |" +
                               "\n|______________________________________________________________________________________________|" +
                               "\n|      Steel - 10 Gold      |           Plastic - 10 Gold        |                             |" +
                               "\n|     Obsidian - 5 Gold     |        Turkey Feathers - 5 Gold    |        0.05 Gold per cm     |" +
                               "\n|       Wood - 3 Gold       |         Goose Feathers - 3 Gold    |                             |" +
                               "\n------------------------------------------------------------------------------------------------";


        //calls menu
        static public void MenuPrint()
        {
            Console.WriteLine(_menu);
        }



    }
}
