using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Customer
    {
        public string Code { set; get; } = string.Empty;

        public string Name { set; get; } = string.Empty;

        public string Email { set; get; } = string.Empty;


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Name : " + Name);
            builder.Append("Code : " + Code);
            builder.Append("Email : " + Email);

            return builder.ToString();
        }
    }

}
