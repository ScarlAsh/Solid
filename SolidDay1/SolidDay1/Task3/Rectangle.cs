using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.Task3
{
	//square class was violating the Substitution Principle
	internal class Rectangle
	{
		double width;
		double height;
        public Rectangle(double _width , double _height)
        {
            width = _width;
            height = _height;
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
    }

	



}
