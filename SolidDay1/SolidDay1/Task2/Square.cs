using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.TaskTwo
{
	internal class Square : IAreaCalculator
	{
		public double Side { get; set; }

        public Square(double side)
        {
			Side = side;
        }

        public double CalCulateArea()
		{
			return Side * Side;
		}
	}
}
