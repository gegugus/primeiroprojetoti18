using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroprojetoti48
{
    public class Clientes
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasct { get; set; }
        public DateTime DataRegistro { get; set; }
    }

    public class Contatos
    {
        public int ContatoID { get; set; }
        public int ClienteID { get; set; }  
        public string Telefone { get; set; } 
        public string Email { get; set; }
    }

    public class Endereco
    {
        public int EnderecoID { get; set; }
        public int ClienteID { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; } 
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }

    public class Observacoes
    {
        public int ObservacoesID { get; set; }
        public int ClienteID { get; set; }
        public string Situacao { get; set; }
        public string Observacao { get; set; }
    }

    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public int Estoque { get; set; }
        public string Categoria { get; set; }
    }
}
