using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace Aspnet_Identity.Configuration.EmailSender
{
    // This is an implementation of the IMailService
    // This class is responsible for sending email through the SMTP
    // Mailgun or SendGrid or any other email services provider are useful
    public class MailService : IMailService
    {
        private readonly EmailSettings _emailSettings;
        
        // Constructor
        public MailService(IOptions<EmailSettings> emailOptions)
        {
            _emailSettings = emailOptions.Value;
        }

        // Send email
        public bool Send(string sender, string subject, string body, bool isBodyHTML)
        {
            try
            {
                // Create an object based on the MailMessage class
                MailMessage mailMessage = new MailMessage();

                // Assign properties that are required for sending an email
                mailMessage.From = new MailAddress(_emailSettings.Email);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = isBodyHTML;
                // Send email to ...
                mailMessage.To.Add(new MailAddress(sender));

                // Generate a SmtpClient object
                SmtpClient smtp = new SmtpClient();

                // smtp.Host = smtp.gmail.com;
                smtp.Host = "mail.vahidalizadeh7070.ir";

                // If using gmail, set it true
                smtp.EnableSsl = false;
                
                // Set username and password of our email 
                NetworkCredential networkCredential = new NetworkCredential();
                networkCredential.UserName = mailMessage.From.Address;
                networkCredential.Password = _emailSettings.Password;

                // If using gmail, set it true
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = networkCredential;
                
                // If using google set it 587
                smtp.Port = 25;

                // Send 
                smtp.Send(mailMessage);
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
