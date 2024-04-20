using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.TaskTwo
{
	internal class Cube : IVolumeCalCulator
	{
		public double Side { get; set; }

        public Cube(double side)
        {
            Side = side;
        }

		public double CalculateVolume()
		{
			return Side * Side * Side;
		}
	}
}
