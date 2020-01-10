using PriesuZaidimasSuKlasem.Game;
using System;
using System.Collections.Generic;

namespace PriesuZaidimasSuKlasem
{
    class Program
    {
        static void Main()
        {

              int enemyCount = 0;
               Random rnd = new Random();

         //   GameScreen game = new GameScreen(30, 30);
          //  game.SetHero(new Hero(8, 8, "Herojus"));

            //mano herojus
            Hero hero = new Hero(5, 8, "Herojus");
            hero.PrintInfo();

            //sukuriam priesu listą
            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            //atspaudinam priesu lista
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }


            //pajudinam heroju ir priesus visus
            hero.Moveleft();
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }
            
            // atspausdinam herojaus ir priesu naujas pozicijas
            hero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

          //  Console.ReadKey();


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
