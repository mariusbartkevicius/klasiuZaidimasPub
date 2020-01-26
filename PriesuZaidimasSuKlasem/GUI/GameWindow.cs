using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.GUI
{
    class GameWindow : Window
    {
        private Button startButton { get; set; }
        private Button creditsButton { get; set; }
        private Button quitButton { get; set; }
        private TextBlock titleTextBlock;




        //private List<Button> GameWindowButtons = new List<Button>();


        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            

            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super zaidimas", "Marius Bartkevicius kuryba!", "Made in Vilnius Coding School!" });

                        
            startButton = new Button(20, 13, 18, 5, "Start");
            startButton.SetActive();
        //    GameWindowButtons.Add(startButton);

            creditsButton = new Button(50, 13, 18, 5, "Credits");
        //    GameWindowButtons.Add(creditsButton);

            quitButton = new Button(80, 13, 18, 5, "Quit");
        //    GameWindowButtons.Add(quitButton);

        }

        public override void Render()
        {
            base.Render();

          //  GameWindowButtons.Find(quitButton(20, 13, 18, 5, "Quit")).Render();

            titleTextBlock.Render();

            startButton.Render();
            creditsButton.Render();
            quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
    }

