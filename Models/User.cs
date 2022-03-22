using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<IMedia> Medias { get; set; }

        public User(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public virtual string GenerateEmail()
        {
            this.Email = this.Name+ this.Id.ToString()+ "gmail.com";
            return this.Email;
        }

        public void Binge() 
        { 
            foreach (IMedia media in Medias)
            {
                media.Play();
            }
        }

        public User()
        {
            Medias = new HashSet<IMedia>();
        }
    }
}
