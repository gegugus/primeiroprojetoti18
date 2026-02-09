using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class TB_Vendas : Form
    {
        public TB_Vendas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += LblLink_LinkClicked;
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void CarregarDados()
        {
            try
            {
                using (SqlConnection conn = ConnBD.GetConnection())
                {
                    string query = @"
                        SELECT 
                            C.ClienteID AS 'CLIENTE ID', 
                            C.Nome AS 'NOME CLIENTE' , 
                            V.VendaID AS 'VENDA ID', 
                            V.DataVenda AS 'DATA VENDA', 
                            VI.ProdutoID AS 'PRODUTO ID', 
                            VI.Quantidade AS QUANTIDADE, 
                            VI.PrecoUnitario AS 'PREÇO UNITÁRIO',
                            V.ValorTotal AS 'VALOR TOTAL (R$) - VENDA'
                        FROM VENDAS V
                        INNER JOIN CLIENTES C ON V.ClienteID = C.ClienteID
                        INNER JOIN VENDAS_ITENS VI ON V.VendaID = VI.VendaID
                        ORDER BY V.VendaID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DTG_View.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void ConfigurarGrid()
        {
            DTG_View.ReadOnly = true;
            DTG_View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTG_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DTG_View.MultiSelect = false;
        }

        private void TB_Vendas_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarDados();
        }

        private void DTG_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
