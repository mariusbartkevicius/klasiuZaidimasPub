using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.Game
{
    class Hero : Unit
    {
     //   private int x;
     //   private int y;
     //   private string name;


            public Hero(int x, int y, string name) : base (x, y, name)
        {
         //   this.x = x;
         //   this.y = y;
         //   this.name = name;
        }


        public void MoveRight()
        {
            X++;
        }

        public void Moveleft()
        {
            X--;
        }

       // public void PrintInfo()
     //   {
     //       Console.WriteLine($"Hero position:{x},{y}");
     //   
     //   }
    }
}
