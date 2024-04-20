using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.TaskTwo
{
	internal class Circle : IAreaCalculator
	{
		public double Radius { get; set; }

        public Circle(double radius)
        {
			Radius = radius;
        }

        public double CalCulateArea()
		{
			return Math.PI * Radius * Radius;
		}
	}
}
