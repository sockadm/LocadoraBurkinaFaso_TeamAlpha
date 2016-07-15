using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraBurkinaFasoWeb.Models
{
    public class Estado
    {
        public enum Estados
        {
            AC,
            AL,
            AM,
            AP,
            BA,
            CE,
            DF,
            ES,
            GO,
            MA,
            MG,
            MS,
            MT,
            PA,
            PB,
            PE,
            PI,
            PR,
            RJ,
            RN,
            RO,
            RR,
            RS,
            SC,
            SE,
            SP,
            TO
        }
        public Estados UF { get; set; }
        public string nome_estado { get; set; }

    }
}