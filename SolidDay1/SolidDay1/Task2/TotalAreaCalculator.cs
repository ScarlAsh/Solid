using SolidDay1.TaskTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.Task2
{
	//the areacalculator class was violating the open/closed principle
	internal class TotalAreaCalculator
	{
		public static double CalculateTotalArea(List<IAreaCalculator> shapes)
		{
			double totalArea = 0;
			foreach (var shape in shapes)
			{
				totalArea += shape.CalCulateArea();
			}
			return totalArea;
		}
	}
}
