using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.Game
{
    class GameScreen
    {
        private int width;
        private int height;
        Hero hero;
        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public void MoveHeroRight()
        {
            if (hero.GetX() < width)
            {
                hero.MoveRight();
            }
        }

        public void MoveHeroLeft()
        {
            if (hero.GetX() > 0)
            {
                hero.Moveleft();
            }
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }                  
        }

        public Enemy GetEnemyById(int id)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }

        public void Render()
        {
            
            foreach (Enemy enemy in enemies)
            {
                enemy.Render();
            }
            hero.Render();
        }

       internal void ActivateEnemies()
        {
           MoveAllEnemiesDown();
           RemoveEnemiesOutOfScreen();
        }

        private void RemoveEnemiesOutOfScreen()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].Y > height)
                {
                    RemoveEnemy(enemies[i]);
                    i--;
                }
            }
        }

        private void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        /*
        private void RemoveEnemyByID(int id)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].GetId == id)
                {
                    enemies.RemoveAt(i);
                }
            }
        }
        */
    }
}
