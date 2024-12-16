using CleanBlog.Core.Controllers;
using CleanBlog.Core.ViewModels;
using System.Net.Mail;
using Umbraco.Core.Logging;
namespace CleanBlog.Core.Services
{
    public class SmtpService : ISmtpServices
    {
        private readonly ILogger _logger;
        public SmtpService(ILogger logger)
        {
            _logger = logger;
        } 

        public bool SendEmail(ContactVM model)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                //string toAddress = WebConfigurationManager.AppSettings["EmailToAddress"];
                string toAddress = "to@test.com";
                string fromAddress = "from@test.com";
                message.Subject = $"Enquiry from:{model.Name} - {model.Email}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);
                client.Send(message);
                return true;
            }
            catch (SmtpException e)
            {
                _logger.Error(typeof(ContactSurfaceController), e, "Error sending contact from.");
                return false;
            }
        }
    }
}
