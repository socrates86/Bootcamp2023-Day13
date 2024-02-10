using Example1;

ICustomerService customerService = new CustomerService();
List<Customer> customers = customerService.GetCustomers();

EmailSetting emailSetting = new EmailSetting();
emailSetting.Server = "smtp.gmail.com";
emailSetting.Username = "ikechukwumorrison86@gmail.com";
emailSetting.Password = "morrissocrates";

IEmailService emailService = new EmailService(emailSetting);

foreach (Customer customer in customers)
{
    MyMessage message = new MyMessage();
    message.From = emailSetting.Username;
    message.Body = $"Dear {customer.Name}, \n Our promo begins this month!";

    bool result = emailService.SendMessage( customer, message );

    if(result)
    {
        Console.WriteLine($"Message sent to { customer.Name } @{ customer.Email }");
    }
}