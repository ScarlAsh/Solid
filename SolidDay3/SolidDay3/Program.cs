using Ninject;
using System.Reflection;

namespace SolidDay3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			StandardKernel kernel = new StandardKernel();
			
			kernel.Load(Assembly.GetExecutingAssembly());

			ICreditCard card = kernel.Get<ICreditCard>();

			Shopper shopper = kernel.Get<Shopper>();

			shopper.Checkout(card);

			

		}
	}
}
