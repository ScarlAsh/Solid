using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay3
{
	public class VisaCard : ICreditCard
	{
		public void Charge()
		{
			Console.WriteLine("Charging using Visa Card........");
		}
	}
}
