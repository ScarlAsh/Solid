using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task1
{
	internal interface IManager
	{
		//breaking the ilead iterface into two interfaces imanager and iworkon to avoid
		//violating the interface segregation principle (and single responsiblity) when adding manager to the system.
		Task CreateSubTask();
		void AssginTask();
	}
}
