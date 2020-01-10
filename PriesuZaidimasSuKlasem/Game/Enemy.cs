using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.Game
{
    class Enemy
    {

        int id;
        int x;
        int y;
        string name;

        public Enemy(int id, int x, int y, string name)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void MoveDown()
        {
            y++;
        }

        public int GetId()
        {
            return this.id;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Enemy position:{x},{y}");

        }
    }
}
