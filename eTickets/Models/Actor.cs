using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string FullNmae { get; set; }

        public string Bio { get; set; }

        //Relationships

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
