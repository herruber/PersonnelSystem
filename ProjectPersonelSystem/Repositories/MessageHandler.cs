using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet;
using ProjectPersonelSystem.Models;
using System.Net.Mail;

namespace ProjectPersonelSystem.Repositories
{
    public class MessageHandler
    {

        public void SendMessage(Mail mail)
        {
            MailMessage msg = new MailMessage();


            msg.From = new MailAddress(mail.From);
            msg.To.Add(new MailAddress(mail.To));

            msg.IsBodyHtml = true;
            msg.Subject = mail.Subject;
            msg.Body = mail.Msg;
            
            System.Net.Mail.SmtpClient mailclient = new System.Net.Mail.SmtpClient();
            mailclient.Host = "smtp.live.com";
            mailclient.Port = 587;
            mailclient.UseDefaultCredentials = false;
            mailclient.Credentials = new System.Net.NetworkCredential("personnelsystemm@hotmail.com", "psys1000");
            mailclient.EnableSsl = true;


            mailclient.Send(msg);

        }

    }
}