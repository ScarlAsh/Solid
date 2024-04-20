using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task1
{
	internal class TeamLeadFactory : IFactory
	{
		public IWorkOn Get()
		{
			return new TeamLead("team lead name");
		}
	}
}
