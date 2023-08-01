using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Software_de_taquilla.Helpers
{
    public class EmailSender
    {
        public static void sendEmail(string dest)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("megacinemagt@outlook.com"));
            email.To.Add(MailboxAddress.Parse(dest));
            email.Subject = "testing";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = "" };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.office365.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("megacinemagt@outlook.com", "adminmega1");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
