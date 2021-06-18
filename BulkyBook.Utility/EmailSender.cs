using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailOptions emailOptions;
        public EmailSender(IOptions<EmailOptions> options)
        {
            emailOptions = options.Value;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(emailOptions.SendGridKey, subject, htmlMessage, email);
        }
        private async Task Execute(string sendGridKey,string subject,string message , string email )
        {
            var client = new SendGridClient(sendGridKey);
            var from = new EmailAddress("test@example.com", "Example User");
            var to = new EmailAddress(email, "Example User");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "",message);
            await  client.SendEmailAsync(msg);
        }
    }
}
