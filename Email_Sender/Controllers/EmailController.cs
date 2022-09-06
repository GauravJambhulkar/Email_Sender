using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace Email_Sender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }



        [HttpPost]
        public IActionResult SendMail(EmailDTO request)
        {
            _emailService.SendEmail(request);
            //var email = new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("myah.hills73@ethereal.email"));
            //email.To.Add(MailboxAddress.Parse("myah.hills73@ethereal.email"));
            //email.Subject = "Test email subject";
            //email.Body = new TextPart(TextFormat.Html) { Text = body };

            //using var smtp = new SmtpClient();
            //smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            //smtp.Authenticate("myah.hills73@ethereal.email", "y8V4WBxXWK4RhA1QhM");
            //smtp.Send(email);
            //smtp.Disconnect(true);


            return Ok();
        }
    }
}
