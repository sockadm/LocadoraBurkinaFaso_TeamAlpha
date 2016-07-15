using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LocadoraBurkinaFasoWeb.Models
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public string complemento { get; set; }
        [DisplayName("Bairro")]
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public Estado estado_do_endereco { get; set; }


    }
}