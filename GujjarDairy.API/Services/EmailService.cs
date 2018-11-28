using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace GujjarDairy.API.Services
{
    public class EmailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            await ConfigureAndSendEmail(message);
        }

        // configure and send email 
        private async Task ConfigureAndSendEmail(IdentityMessage message)
        {
            SmtpClient smtpClient = new SmtpClient(ConfigurationManager.AppSettings["gdf:SMTPHost"], Int32.Parse(ConfigurationManager.AppSettings["gdf:SMTPHostPort"]));

            //SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["gdf:SMTPAccountUserId"], ConfigurationManager.AppSettings["gdf:SMTPAccountPassword"]);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = Boolean.Parse(ConfigurationManager.AppSettings["gdf:SMTPEnableSSL"]);

            MailMessage mail = new MailMessage();

            mail.IsBodyHtml = true;
            mail.Subject = message.Subject;
            mail.From = new MailAddress(ConfigurationManager.AppSettings["gdf:SMTPAccountEmail"], message.Subject);
            mail.To.Add(new MailAddress(message.Destination));
            mail.Body = message.Body;

            await smtpClient.SendMailAsync(mail);
        }
    }
}