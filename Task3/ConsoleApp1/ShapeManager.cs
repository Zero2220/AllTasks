using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ShapeManager
    {

        public  Shapes[] shapes;



        public int GetCircleCount()
        {

            int count = 0;

            for (int i = 0; i < shapes.Length; i++)
            {

                if (shapes[i] is Circle)
                {
                    count++;

                }

            }
            return count;
        }

        public Circle[] GetCircles()
        {

            Circle[] circles = new Circle[0];

            for (int i = 0;i < shapes.Length;i++)
            {

                if (shapes[i] is Circle)
                {
                    Array.Resize(ref circles,circles.Length+1);

                    circles[circles.Length-1] = shapes[i] as Circle;

                }

            }
            return circles;

        }

        public double GetTotalSumOfAreas()
        {

            double sum = 0;
            for (int i = 0; i < shapes.Length; i++)
            {

                if (shapes[i] is Circle)
                {
                     sum +=shapes[i].CalculateArea();



                }

            }

            return sum;


        }

        public int GetSquareCount()
        {
            int count = 0;
            for (int i = 0; i < shapes.Length; i++)
            {

                if (shapes[i] is Rectangle)
                {
                    Rectangle rec = shapes[i] as Rectangle;
                    if (rec.Width == rec.Height)
                    {
                        count++;

                    }



                }

            }
            return count;

        }

        public void AddShape(Shapes shape)
        {

            if (!shapes.Contains(shape) && shape != null && shapes.Length<=10)
            {
                Array.Resize(ref shapes,shapes.Length+1);

                shapes[shapes.Length-1] = shape;


            }



        }
    }
}
