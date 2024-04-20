using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task2
{
	internal class ReadOnlySqlFile 
	{
		public string? FilePath { get; set; }
		public string? FileText { get; set; }
		public string LoadText()
		{
			return "loaded text";
		}
	}
}
