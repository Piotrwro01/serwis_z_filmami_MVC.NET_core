using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace serwis_z_filmami.Models
{
    public class Kino
    {
        [Key]
        public int id { get; set; }
        public string logo { get; set; }
        public string nazwa { get; set; }
        public string opis { get; set; }
    }
}
