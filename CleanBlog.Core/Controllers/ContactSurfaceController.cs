using CleanBlog.Core.Services;
using CleanBlog.Core.ViewModels;
using System;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Umbraco.Core.Logging;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace CleanBlog.Core.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        private readonly ISmtpServices _smtpServices;
        public ContactSurfaceController(ISmtpServices smtpServices)
        {
            _smtpServices = smtpServices;
        }

        //Get 
        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactVM model = new ContactVM() { ContactFormId = CurrentPage.Id };
            return PartialView("~/Views/Partials/Contact/_contactForm.cshtml", model);
        }
        //Post
        [HttpPost]
        public ActionResult RenderForm(ContactVM model)
        {
            return PartialView("~/Views/Partials/Contact/_contactForm.cshtml", model);
        }

        public ActionResult SubmitForm(ContactVM model)
        {
            if (!ModelState.IsValid)
            {
                // Re-render the form with validation errors
                return PartialView("~/Views/Partials/Contact/_contactForm.cshtml", model);
            }
            bool success = false;
            if (ModelState.IsValid)
            {
                success = _smtpServices.SendEmail(model);
            }

            var contactPage = UmbracoContext.Content.GetById(false, model.ContactFormId);

            var successMessage = contactPage.Value<IHtmlString>("successMessage");
            var errorMessage = contactPage.Value<IHtmlString>("errorMessage");
            return PartialView("~/Views/Partials/Contact/_result.cshtml", success ? successMessage : errorMessage);
        }


    }
}
