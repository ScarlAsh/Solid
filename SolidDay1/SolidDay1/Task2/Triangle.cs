using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.TaskTwo
{
	internal class Triangle  :IAreaCalculator
	{
        public double Base { get; set; }

        public double Height { get; set; }

        public Triangle(double Base , double height)
        {
            this.Base = Base;
            Height = height;
        }

		public double CalCulateArea()
		{
			return .5 * Base * Height;
		}
	}
}
