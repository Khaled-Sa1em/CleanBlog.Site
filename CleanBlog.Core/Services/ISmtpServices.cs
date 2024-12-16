using CleanBlog.Core.ViewModels;

namespace CleanBlog.Core.Services
{
    public interface ISmtpServices
    {
        bool SendEmail(ContactVM model);
    }
}
