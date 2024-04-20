using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.Task1
{
	internal class EmailServices
	{
		public virtual bool ValidateEmail(string Email)
		{
			return Email.Contains("@");
		}
		public bool SendEmail(MailMessage message)
		{
			SmtpClient smtpClient = new SmtpClient();
			try
			{
				smtpClient.Send(message);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
