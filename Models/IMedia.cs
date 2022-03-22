using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract.Models
{
    public interface IMedia
    {
        int Id { get; set; }
        string Title { get; set; }
        int Runtime { get; set; }

        void Play();
    }
}
