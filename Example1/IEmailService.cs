using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example1
{
    public interface IEmailService
    {
        bool SendMessage(Customer customer, MyMessage message);
    }
}