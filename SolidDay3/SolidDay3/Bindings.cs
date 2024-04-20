using System;
using Ninject.Modules;
using Ninject;


namespace SolidDay3
{
	public class Bindings : NinjectModule
	{
		public override void Load()
		{
			Bind<ICreditCard>().To<MasterCard>();
			Bind<Shopper>().To<Shopper>();
		}
	}
}
