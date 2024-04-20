using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task1
{
	internal class TeamLead : IManager , IWorkOn
	{
        public string Name { get; set; }

        public TeamLead(string name)
        {
			Name = name;
        }
        public void AssginTask()
		{
			//removing the hidden dependencies by using the createtask method instead of using the new key word
			Task task = CreateSubTask();
			//using factory pattern to get a developer object instead of new key word to remove hidden dependencies again
			IFactory Factory = new DeveloperFactory();
			task.AssignTo(Factory.Get());
		}

		public Task CreateSubTask()
		{
			return new Task("task one" , "this is the first task......");
        }

		public void WorkOnTask()
		{
            Console.WriteLine("working on task....");
        }
	}
}
