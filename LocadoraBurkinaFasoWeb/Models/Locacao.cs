using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraBurkinaFasoWeb.Models
{
    public class Locacao
    {
        public DateTime data_locacao;
        public DateTime data_entrega;
        // public listatitulo , considerar que nao estamos utilizando a classe titulo.
        public Cliente lista_cliente; // validar melhor forma de exibir o cliente para locar.
    }
}