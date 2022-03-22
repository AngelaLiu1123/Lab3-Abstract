using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract.Models
{
    public class Song : IMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public ICollection<Customer> Customers { get; set; }

        //The properties and method of Interface should all be implemented 
        public int Runtime { get; set; }

        void IMedia.Play()
        {
            Console.WriteLine($"Playing the song {this.Title} on your favourite music platform for {this.Runtime}.");
        }

        public Song(int id, string title, int artistId, int runTime)
        {
            this.Id = id;
            this.Title = title;
            this.ArtistId = artistId;
            this.Runtime = runTime;
        }
    }
}
