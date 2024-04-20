using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidDay1.Task1
{
	//userservices class was violating the single responsiblity principle 
	internal class UserServices
	{
		User? user { get; set; }
		readonly EmailServices emailServices = new EmailServices();

		public void Register(string email, string password)
		{
			if (!emailServices.ValidateEmail(email))
				throw new ValidationException("not a valid email");

			user = new User(email, password);
		}
		public void SendEmail(string ToEmail)
		{
			if(user != null)
			{
				emailServices.SendEmail(new MailMessage(user.Email, ToEmail)
				{ Subject = "HEllo foo" });
			}
		}
	}
}
