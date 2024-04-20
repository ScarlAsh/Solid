using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.TaskTwo
{
	internal class Rectangle : IAreaCalculator
	{
		public double Height { get; set; }
		public double Width { get; set; }

        public Rectangle(double width , double height)
        {
			Height = height;
			Width = width;
        }

        public double CalCulateArea()
		{
			return Height * Width;
		}
	}	
		

	
}
