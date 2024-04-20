using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.Task3
{
	internal class Square
	{
		double side;

        public Square(double _side)
        {
            side = _side;
        }

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
    }
}
