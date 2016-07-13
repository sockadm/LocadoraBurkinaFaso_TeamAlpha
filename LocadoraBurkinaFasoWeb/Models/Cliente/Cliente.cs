using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraBurkinaFasoWeb.Models
{
    public class Cliente
    {
        public int matricula;
        public string nome;
        public string sobrenome;
        public string cpf;
        public enum sexo
        {
            Masculino,
            Feminino
        }
        public DateTime datanascimento;
        public Endereco endereco_cliente;
        public Contato contato_cliente;
        

    }
}