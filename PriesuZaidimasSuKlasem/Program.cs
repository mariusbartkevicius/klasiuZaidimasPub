using PriesuZaidimasSuKlasem.Contorler;
using PriesuZaidimasSuKlasem.Game;
using PriesuZaidimasSuKlasem.GUI;
using System;
using System.Collections.Generic;

namespace PriesuZaidimasSuKlasem
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;

            GuiController guiController = new GuiController();
            guiController.ShowMenu();


            Console.ReadKey();

           GameController myGame = new GameController();
           myGame.StartGame();

        }

    }
}
