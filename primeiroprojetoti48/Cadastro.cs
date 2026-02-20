using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroprojetoti48
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string NomeFunc { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public byte[] FotoFunc { get; set; }
    }

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
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }

    public class Observacoes
    {
        public int ObservacaoID { get; set; }
        public int ClienteID { get; set; }
        public string Situacao { get; set; }
        public string Observacao { get; set; }
    }

    public class Produto
    {
        public int ProdutoID { get; set; }
        public string CodigoBarras { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Categoria { get; set; }
        public DateTime DataRegistro { get; set; }
        public byte[] Imagem { get; set; }
    }

    public class Venda
    {
        public int VendaID { get; set; }
        public int ClienteID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }
        public string TipoEntrega { get; set; }
        public string EnderecoEntrega { get; set; }
        public string FormaPagamento { get; set; }
        public string BandeiraCartao { get; set; }
        public int Parcelas { get; set; }
        public string ValorParcelado_Texto { get; set; } 
    }

    public class ItemCarrinho
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal => Quantidade * PrecoUnitario;
    }
}
