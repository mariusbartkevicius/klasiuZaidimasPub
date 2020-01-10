using PriesuZaidimasSuKlasem.Game;
using System;
using System.Collections.Generic;

namespace PriesuZaidimasSuKlasem
{
    class Program
    {
        static void Main()
        {
            GameScreen game = new GameScreen(30, 30);
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


         //   GameScreen gameScreen = new GameScreen();
          //  gameScreen.SetHero()


        /*

            Hero hero = new Hero(5, 8);
            hero.PrintInfo();

            hero.Moveleft();
            hero.MoveRight();
            hero.PrintInfo();

            List<Enemy> allEnemies = sugeneruotiPriesus(10);
            Enemy enemy = new Enemy(1, 4, 4);
            enemy.PrintInfo();

            enemy.MoveDown();
            enemy.PrintInfo();
        }

        static List<Enemy> sugeneruotiPriesus(int EnemyCount)
        {
            List<Enemy> id, x, y = new List<Enemy>();

            for (int i = 1; i < 11; i++)
            {
                Random r = new Random();
                Enemy.Ge.Add(i);
                x.Add(r.Next(0, 30));
                y.Add(r.Next(0, 30));
            }
            return List<Enemy>;


        }



    */
    }
}
