using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaAPI.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dt_nasc { get; set; }
        public int cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string logradouro { get; set; }
    }
}
