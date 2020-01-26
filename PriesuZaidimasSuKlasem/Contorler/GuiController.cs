using System;
using System.Collections.Generic;
using System.Text;
using PriesuZaidimasSuKlasem.Contorler;
using PriesuZaidimasSuKlasem.Game;
using PriesuZaidimasSuKlasem.GUI;

namespace PriesuZaidimasSuKlasem.Contorler
{
    class GuiController
    {
       // private bool needToRender;

        public GuiController()
        {
          
        }

        public void ShowMenu()
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Render();
        }

        public void ShowCreditWindow()
        {
            CreditWindow creditWindow = new CreditWindow();
            creditWindow.Render();
        }




    }
}
