using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract.Models
{
    public class Artist: User
    {
        public Artist(int id, string name) : base(id, name)
        {
        }

        public override String GenerateEmail()
        {
            this.Email = "A" + base.GenerateEmail();
            return this.Email;
        }
    }
}
