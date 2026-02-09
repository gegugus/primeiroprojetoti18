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
    public partial class TB_Auditoria : Form
    {
        public TB_Auditoria()
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

        private void CarregarTodosOsDados()
        {
            CarregarGridEspecifico(DTG_ViewCliente, "CLIENTES");
            CarregarGridEspecifico(DTG_ViewProduto, "PRODUTOS");
            CarregarGridEspecifico(DTG_ViewVendas, "VENDAS");
        }
        private void CarregarGridEspecifico(DataGridView dtg, string nomeTabelaNoBanco)
        {
            try
            {
                using (SqlConnection conn = ConnBD.GetConnection())
                {
                    string query = $@"
                        SELECT 
                            TipoOperacao AS 'OPERAÇÃO', 
                            DescricaoRegistro AS 'DETALHES',
                            DataEvento AS 'DATA REGISTRO'
                        FROM AUDITORIA
                        WHERE TabelaAfetada = '{nomeTabelaNoBanco}'
                        ORDER BY DataEvento DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtg.DataSource = dt;

                    FormatarCoresOperacao(dtg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void FormatarCoresOperacao(DataGridView dtg)
        {
            foreach (DataGridViewRow row in dtg.Rows)
            {
                if (row.Cells["OPERAÇÃO"].Value != null)
                {
                    string op = row.Cells["OPERAÇÃO"].Value.ToString();
                    if (op == "EXCLUÍDO")
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    else if (op == "ALTERADO")
                        row.DefaultCellStyle.ForeColor = Color.Blue;
                }
            }
        }

        private void ConfigurarGridsVisual()
        {
            DataGridView[] grids = { DTG_ViewCliente, DTG_ViewProduto, DTG_ViewVendas };

            foreach (var dtg in grids)
            {
                dtg.ReadOnly = true;
                dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtg.MultiSelect = false;
                dtg.AllowUserToAddRows = false;
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dtg.Columns.Count >= 2)
                {
                    dtg.Columns[0].FillWeight = 50;
                    dtg.Columns[1].FillWeight = 180;
                    dtg.Columns[2].FillWeight = 70;
                }
            }
        }

        private void TB_Auditoria_Load(object sender, EventArgs e)
        {
            ConfigurarGridsVisual();
            CarregarTodosOsDados();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarTodosOsDados();
        }
    }
}

