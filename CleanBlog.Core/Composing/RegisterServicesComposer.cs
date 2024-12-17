using CleanBlog.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace CleanBlog.Core.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISmtpServices, SmtpService>(Lifetime.Transient);
            composition.Register<IArticleService, ArticleService>(Lifetime.Request);
        }
    }
}
