using PriesuZaidimasSuKlasem.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.Contorler
{
    class GameController
    {
        private GameScreen myGame;

        public void StartGame()
        {

            // init game
            InitGame();

            // render loop
            StartGameLoop();
        }

        public void InitGame()
        {
            int gameWidth = 120;
            int gameHeight = 30;

            myGame = new GameScreen(gameWidth, gameHeight); 

            myGame.SetHero(new Hero(gameWidth / 2, gameHeight - 5 , "Herojus"));

            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, gameWidth), rnd.Next(0, 5), "enemy" + enemyCount));
                enemyCount++;
            }


        }


        private void StartGameLoop()
        {
            bool needToRender = true;

            do
            {
                // isvalom ekrana
                Console.Clear();

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            break;
                    }
                }

                myGame.ActivateEnemies();
                
                myGame.Render();

                // padarom pause. (parodom ekrana).
                System.Threading.Thread.Sleep(250);
            } while (needToRender);
        }

    }
}
