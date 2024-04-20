using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task1
{
	internal class DeveloperFactory : IFactory
	{
		public IWorkOn Get()
		{
			return new Developer("developer one");
		}

	}
}
