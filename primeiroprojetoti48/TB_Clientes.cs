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
    public partial class TB_Clientes : Form
    {
        public TB_Clientes()
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
                            C.ClienteID,
                            C.Nome AS NomeCliente,
                            C.CPF,
                            C.DataNasct,
                            CT.Telefone,
                            CT.Email,
                            E.Logradouro,
                            E.Numero,        
                            E.Bairro,
                            E.Cidade,    
                            E.Estado,
                            E.Cep,
                            O.Situacao,
                            O.Observacao,
                            C.DataRegistro
                        FROM CLIENTES C
                        LEFT JOIN CONTATOS CT ON C.ClienteID = CT.ClienteID
                        LEFT JOIN ENDERECO E ON C.ClienteID = E.ClienteID
                        LEFT JOIN OBSERVACOES O ON C.ClienteID = O.ClienteID
                        ORDER BY C.Nome ASC";

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

        private void DTG_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TB_Clientes_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarDados();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
