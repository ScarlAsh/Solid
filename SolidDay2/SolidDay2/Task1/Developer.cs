namespace SolidDay2.Task1
{
	public class Developer : IWorkOn
	{
        public String Name { get; set; }
        public Developer(string name)
        {
            Name = name;
        }

		public void WorkOnTask()
		{
            Console.WriteLine("working on task..........");
        }
	}
}