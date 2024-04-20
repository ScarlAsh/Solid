using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task1
{
	internal class Task
	{
        public string? Title { get; set; }
        public string Description { get; set; }
        public Task(string title , string description)
        {
            Title = title;
            Description = description;
        }

        //now assignto can take developer or teamlead since both work on tasks
        public void AssignTo(IWorkOn taskdoer)
        {
            Console.WriteLine("being assigned to taskdoer");
        }
    }
}
