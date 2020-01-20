using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.GUI
{
    abstract class GuiObject
    {
      //  protected int X;
       // protected int Y;
      //  protected int Width;
       // protected int Height;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        abstract public void Render();
    }
}
