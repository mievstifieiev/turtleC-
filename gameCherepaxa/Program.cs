using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace gameCherepaxa
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            Shapes.Move(eat, 200, 200);
            int eatX = 200;
            int eatY = 200;
            Random rnd = new Random();
            int count = 0;
            double step = 3;
            GraphicsWindow.DrawText(0, 0, "Очки: " + Convert.ToString(count));
            while (true)
            {
                Turtle.Move(step);
                if ((Turtle.X <= eatX + 10 )&& (Turtle.X >= eatX)&&(Turtle.Y <= eatY + 10)&&(Turtle.Y >= eatY))
                {
                    GraphicsWindow.BrushColor = "White";
                    GraphicsWindow.DrawText(0, 0, "Очки: " + Convert.ToString(count));
                    eatX = rnd.Next(10, GraphicsWindow.Width);
                    eatY = rnd.Next(10, GraphicsWindow.Height);
                    Shapes.Move(eat, eatX, eatY);
                    count++;
                    Turtle.Speed = Turtle.Speed + 0.01;
                    step = step + 0.1;
                    GraphicsWindow.BrushColor = "Red";
                    GraphicsWindow.DrawText(0, 0, "Очки: " + Convert.ToString(count));
                }
                //GraphicsWindow.DrawText(10, 10, "Очки: " + Convert.ToString(count));
            }
        }



        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
            //throw new NotImplementedException();
        }

    }
}
