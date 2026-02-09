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
    public partial class TB_Produtos : Form
    {
        public TB_Produtos()
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
                            P.ProdutoID AS 'PRODUTO ID',   
                            P.Nome AS 'NOME PRODUTO',
                            P.Descricao AS DESCRIÇÃO,
                            P.Preco AS PREÇO,
                            P.Estoque AS ESTOQUE,
                            P.Categoria AS CATEGORIA,
                            P.DataRegistro AS 'DATA REGISTRO'
                        FROM PRODUTOS P
                        ORDER BY P.Nome ASC";

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

        private void TB_Produtos_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarDados();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void DTG_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
