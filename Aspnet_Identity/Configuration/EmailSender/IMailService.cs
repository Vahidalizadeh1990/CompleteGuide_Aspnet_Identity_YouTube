namespace Aspnet_Identity.Configuration.EmailSender
{
    // This interface is responsible for sending email
    public interface IMailService
    {
        bool Send(string sender, string subject, string body, bool isBodyHTML);
    }
}
