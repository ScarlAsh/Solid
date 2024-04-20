using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task2
{
	internal class SqlFile : ReadOnlySqlFile, ISavable
	{
		//the old design was violating the substitution principle
		public void SaveText()
		{
            Console.WriteLine("saving text to file");
        }
	}
}
