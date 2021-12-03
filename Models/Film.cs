using serwis_z_filmami.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace serwis_z_filmami.Models
{
    public class Film
    {
        [Key]
        public int id { get; set; }
        public string nazwa { get; set; }
        public string opis { get; set; }
        public double cena{ get; set; }
        public string urlGrafiki { get; set; }
        public DateTime dataRozpoczecia { get; set; }
        public DateTime dataZakonczenia { get; set; }

        public KategoriaFilmowa KategoriaFilmowa { get; set; }

        //Relacje
        public List<Aktor_Film> Aktorzy_Filmy { get; set; }

        //Kino
        public int kinoId { get; set; }
        [ForeingKey("kinoId")]
        public Kino Kino{ get; set; }
        
        //Producent
        public int producentId { get; set; }
        [ForeingKey("kinoId")]
        public Producent Producent { get; set; }


    }
}
