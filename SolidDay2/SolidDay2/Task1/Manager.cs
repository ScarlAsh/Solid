using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task1
{
	internal class Manager : IManager
	{
		public void AssginTask()
		{
			//using the createtask and factoy pattern to avoid using the new keyword/remove hidden dependencies.
			Task task = CreateSubTask();
			IFactory Factory = new TeamLeadFactory();
			task.AssignTo(Factory.Get());
			
		}

		public Task CreateSubTask()
		{
			return new Task("new Task" , "this is a new task....");
		}
	}
}
