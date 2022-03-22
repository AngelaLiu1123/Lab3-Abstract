using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract.Models
{
    public class Customer : User
    {
        public Customer(int id, string name) : base(id, name)
        {
        }
    }
}
