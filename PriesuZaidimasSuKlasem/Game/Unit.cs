using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.Game
{
    abstract class Unit
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        private string Name;
        private readonly char representSymbol;

        public Unit(int x, int y, string name, char representSymbol)
        {
            X = x;
            Y = y;
            Name = name;
            this.representSymbol = representSymbol;
        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(representSymbol);
        }
    }

      //  public void PrintInfo()
      //  {
     //       Console.WriteLine($" Unit {Name} is at {X}:{Y}");
    //    }


    }

