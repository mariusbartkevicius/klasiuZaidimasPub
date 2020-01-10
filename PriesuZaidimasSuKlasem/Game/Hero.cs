using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.Game
{
    class Hero
    {
        private int x;
        private int y;
        private string name;


            public Hero(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }


        public void MoveRight()
        {
            x++;
        }

        public void Moveleft()
        {
            x--;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Hero position:{x},{y}");
        
        }
    }
}
