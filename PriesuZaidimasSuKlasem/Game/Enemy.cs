using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.Game
{
    class Enemy : Unit
    {

        int id;
       // int x;
      //  int y;
      //  string name;

        public Enemy(int id, int x, int y, string name) : base (x, y, name, '$')
        {
            this.id = id;
        }

        public void MoveDown()
        {
            Y++;
        }

        public int GetId()
        {
            return this.id;
        }


        //  public void PrintInfo()
        //  {
        //    Console.WriteLine($"Enemy position:{x},{y}");
        //
        //  }



    }
}
