using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay2.Task2
{
	internal class SqlFileManager
	{
		//the old manager class was violating the open/closed principle
		//adding parameter to each method to remove hidden dependencies and make it explicit instead 
		public string GetTextFromFiles(List<ReadOnlySqlFile> lstSqlFiles)
		{
			StringBuilder objStrBuilder = new StringBuilder();
			foreach (var objFile in lstSqlFiles)
			{
				objStrBuilder.Append(objFile.LoadText());
			}
			return objStrBuilder.ToString();
		}
		public void SaveTextIntoFiles(List<ISavable> lstSqlFiles)
		{
			foreach (var objFile in lstSqlFiles)
			{
				objFile.SaveText();
			}
		}
	}
}
