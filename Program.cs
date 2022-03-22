using Lab3_Abstract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist artist = new Artist(1,"Jay Zhou");
            
            IMedia song = new Song(1,"Song1", 1, 186);
            Customer customer = new Customer(2, "Angela Liu");
            customer.Medias.Add(song);
            customer.Binge();
        }
    }

}
