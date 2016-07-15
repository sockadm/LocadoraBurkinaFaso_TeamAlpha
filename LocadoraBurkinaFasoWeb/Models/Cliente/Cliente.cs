using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LocadoraBurkinaFasoWeb.Models
{
    public class Cliente
    {
        public int matricula { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        [DisplayName("Sexo :")]
        public sexo sexo_variavel { get; set; }
        public enum sexo
        {
            Masculino,
            Feminino
        }
        public DateTime datanascimento { get; set; }
        public Endereco endereco_cliente { get; set; }
        public Contato contato_cliente { get; set; }


    }
}