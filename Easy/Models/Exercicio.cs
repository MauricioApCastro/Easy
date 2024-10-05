using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Models
{
    public class Exercicio
    {
        public int Id { get; set; } // Identificador único
        public string Codigo { get; set; }
        public string TextoEn { get; set; }
        public string TextoPt { get; set; }
        public string Gif { get; set; }
        public string Mp3 { get; set; }
    }

}
