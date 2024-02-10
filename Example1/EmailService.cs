using System.Net;
using System.Net.Mail;

namespace Example1
{
    public class EmailService : IEmailService
    {
        private readonly EmailSetting _emailSetting;

        public EmailService (EmailSetting emailSetting)
        {
            _emailSetting = emailSetting;
        }
        public bool SendMessage(Customer customer, MyMessage message)
        {
            bool result = false;
            try
            {
                var SmtpClient = new SmtpClient(_emailSetting.Server) // Constructor
                {
                    // Properties and their values
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(_emailSetting.Username, _emailSetting.Password),
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                if (customer != null )
                {
                    Console.WriteLine(customer.ToString());
                    SmtpClient.Send(message.From, customer.Email, message.Subject, message.Body);
                    return true;
                }

            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Message sending failed! :" + ex.Message);
            }
                
            return result;
        }
    }
}