﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace RepositoryLayer.Services
{
    public class EmailService
    {
        public static void SendEmail(string Email, string token)
        {
            using (SmtpClient Client = new SmtpClient("smtp.gmail.com", 587))
            {
                Client.EnableSsl = true;
                Client.DeliveryMethod = SmtpDeliveryMethod.Network;
                Client.UseDefaultCredentials = true;
                Client.Credentials = new NetworkCredential("vaib.manapure9@gmail.com", "rwjwcozadxzaufur ");

                MailMessage msgObj = new MailMessage();
                msgObj.To.Add(Email);
                msgObj.IsBodyHtml = true;
                msgObj.From = new MailAddress("vaib.manapure9@gmail.com");
                msgObj.Subject = "Password Reset Link";
                msgObj.Body = "<html><body><p><b>Hi User </b>,<br/>Please click the below link for reset password.<br/>" +
                              $"{token}" +
                              "<br/><br/><br/><b>Thanks&Regards </b><br/><b>Mail Team(donot - reply to this)</b></p></body></html>";


            }

        }
    }
}
