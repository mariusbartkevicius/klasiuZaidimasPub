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
            GameScreen game = new GameScreen(30, 20);
            game.SetHero(new Hero(8, 8, "Herojus"));

            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                game.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            game.Render();
            game.MoveHeroLeft();
            game.MoveAllEnemiesDown();

            Enemy secondEnemy = game.GetEnemyById(1);
            if (secondEnemy != null)
            {
                secondEnemy.MoveDown();
            }

            game.Render();


            Console.ReadKey();

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

                myGame.Render();

                // padarom pause. (parodom ekrana).
                System.Threading.Thread.Sleep(250);
            } while (needToRender);
        }

    }
}
