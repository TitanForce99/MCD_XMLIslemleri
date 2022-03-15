using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama1
{
    public class Rectangle : Shape
    {

        private float _height;

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private float _width;

        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(float height, float width)
        {
            _height = height;
            _width = width;
            //var random = new Random();
            //Console.BackgroundColor = (ConsoleColor)random.Next((int)ConsoleColor.Black, (int)ConsoleColor.Yellow);
        }


        public override void CalculateArea()
        {
            this.Area = _height * _width;
            Console.WriteLine("Rectangle Area:" + this.Area);
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = (_height * 2) + (_width * 2);
            Console.WriteLine("Rectangle Perimeter: " + this.Perimeter);
        }
    }
}
