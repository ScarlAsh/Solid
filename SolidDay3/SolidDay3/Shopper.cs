using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay3
{
	public class Shopper
	{
		internal void Checkout(ICreditCard card)
		{
			//  code to handle check out process
			//  charging with card for checkout 
			card.Charge();
		}
	}
}
