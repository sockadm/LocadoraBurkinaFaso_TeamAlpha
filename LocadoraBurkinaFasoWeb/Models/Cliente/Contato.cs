using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraBurkinaFasoWeb.Models
{
    public class Contato
    {
        public long telefone_residencial { get; set; }
        public long telefone_celular { get; set; }
        public long telefone_comercial { get; set; }
        public string email { get; set; }

    }
}