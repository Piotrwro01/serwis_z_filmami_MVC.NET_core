using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace serwis_z_filmami.Models
{
    public class Producent
    {
        [Key]
        public int id { get; set; }
        public string profilePictureURL { get; set; }
        public string fullName { get; set; }
        public string bio { get; set; }


        //relacje
        public List<Film> Filmy { get; set; }
    }
}
