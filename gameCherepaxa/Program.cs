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
            GraphicsWindow.MouseDown += GraphicsWindow_MouseDown;
            GraphicsWindow.MouseUp += GraphicsWindow_MouseUp;
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
                if ((Turtle.X <= eatX + 15 )&& (Turtle.X >= eatX - 5)&&(Turtle.Y <= eatY + 15)&&(Turtle.Y >= eatY - 5))
                {
                    GraphicsWindow.BrushColor = "White";
                    GraphicsWindow.DrawText(0, 0, "Очки: " + Convert.ToString(count));
                    eatX = rnd.Next(10, GraphicsWindow.Width);
                    eatY = rnd.Next(10, GraphicsWindow.Height);
                    Shapes.Move(eat, eatX, eatY);
                    count++;
                    Turtle.Speed = Turtle.Speed + 0.1;
                    step = step + 0.1;
                    GraphicsWindow.BrushColor = "Red";
                    GraphicsWindow.DrawText(0, 0, "Очки: " + Convert.ToString(count));
                }
                if (Turtle.X < 0)
                {
                    break;
                }
                else if (Turtle.X > GraphicsWindow.Width)
                {
                    break;
                }
                else if (Turtle.Y < 0)
                {
                    break;
                }
                else if (Turtle.Y > GraphicsWindow.Height)
                {
                    break;
                }
                //GraphicsWindow.DrawText(10, 10, "Очки: " + Convert.ToString(count));
            }
            GraphicsWindow.ShowMessage("Ваши очки: " + Convert.ToString(count), "Игра окончена!");
        }

        private static void GraphicsWindow_MouseUp()
        {
            Turtle.PenUp();
            //throw new NotImplementedException();
        }

        private static void GraphicsWindow_MouseDown()
        {
            Turtle.PenDown();
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
