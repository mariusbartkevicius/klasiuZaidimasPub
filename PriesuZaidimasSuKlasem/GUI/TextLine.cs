using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.GUI
{
    class TextLine : GuiObject
    {
        //  private string data;
        public string label;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 0)
        {
            Label = data;
        }

        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
                Render();
            }
        }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            if (Width > Label.Length)
            {
                int offset = (Width - Label.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write(Label);

        }
    }
}
