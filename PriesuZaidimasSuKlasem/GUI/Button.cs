using System;
using System.Collections.Generic;
using System.Text;

namespace PriesuZaidimasSuKlasem.GUI
{
    class Button : GuiObject
    {
        private Frame notActiveFrame;
        private Frame activeFrame;
     //   private bool isActive = false;
        private TextLine textLine;

        public bool IsActive { get; set; } = false;

        public string Label  //<-kam cia sitas??
        {
            get { return textLine.Label; }
            set { textLine.Label = value; }
        }

        private string label = ""; //<-kam cia sitas??

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');

            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }

        public override void Render()
        {
            if (IsActive)
            {
              activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }

            textLine.Render();
        }

        public void SetActive()
        {
            IsActive = true;
        }

    }
}
