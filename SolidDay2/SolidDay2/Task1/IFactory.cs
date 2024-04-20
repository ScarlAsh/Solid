using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task1
{
	internal interface IFactory
	{
		//creates developer or teamlead
		IWorkOn Get();
	}
}
