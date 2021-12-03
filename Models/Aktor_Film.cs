using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serwis_z_filmami.Models
{
    public class Aktor_Film
    {
        public int filmId { get; set; }
        public Film Film { get; set; }
        public int aktorId { get; set; }
        public Aktor Aktor { get; set; }
    }
}
