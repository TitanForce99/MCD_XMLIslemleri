using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama1
{
    public abstract class Shape
    {
        public float _area;
        private string _color;
        private float _perimeter;
        public float Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public float Perimeter
        {
            get
            {
                return _perimeter;
            }

            set
            {
                _perimeter = value;
            }
        }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();


    }

}
