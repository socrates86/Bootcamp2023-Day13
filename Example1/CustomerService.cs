using System;
using System.Collections.Generic;
using System.IO;

namespace Example1
{
    public class CustomerService : ICustomerService
    {
        public const string path = @"C:\Projects\EmailRecipient.txt";   

        public List<Customer> GetCustomers()
        {
            List<Customer> customerList = new(); // new List<Cutomer>();
            string customerCSV = File.ReadAllText(path);
            string[] customerRecords = customerCSV.Split("\r\n");
            foreach (string customerItems in customerRecords)
            {
                if(!string.IsNullOrEmpty(customerItems))
                {
                    string[] customers = customerItems.Split(",");
                

                Customer customer = new Customer();
                customer.Code = customers[0];
                customer.Name = customers[1];
                customer.Email = customers[2];
                customerList.Add(customer);
                }
            }
            return customerList;
        }
    }
}