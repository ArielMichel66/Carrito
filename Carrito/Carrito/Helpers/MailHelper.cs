using Carrito.Common;
using System.Net.Mail;

namespace Carrito.Helpers
{
    public class MailHelper : IMailHelper
    {
        private readonly IConfiguration _configuration;

        public MailHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Response SendMail(string toName, string toEmail, string subject, string body)
        {
            try
            {
                string from = _configuration["Mail:From"];
                string name = _configuration["Mail:Name"];
                string smtp = _configuration["Mail:Smtp"];
                string port = _configuration["Mail:Port"];
                string password = _configuration["Mail:Password"];


                using (SmtpClient SmtpServer = new SmtpClient("smtp.Gmail.com"))
                {
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress("carritodepruebas@gmail.com")
                    };
                    mail.To.Add(toEmail);
                    mail.Subject = subject;
                    mail.IsBodyHtml = true;
                    string htmlBody;
                    htmlBody = body;
                    mail.Body = htmlBody;
                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("carritodepruebas@gmail.com", "carritodepruebas123");
                    SmtpServer.EnableSsl = true;
                    try
                    {
                        SmtpServer.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        string erroremail = "ERROR: " + ex.Message;
                    }
                }
                return new Response { IsSuccess = true };

            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Result = ex
                };
            }
        }

    }
}

