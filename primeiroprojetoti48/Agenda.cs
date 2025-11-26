using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class Agenda : Form
    {
        List<Contato> lista = new List<Contato>();
        int proximoId = 1;

        public Agenda()
        {
            InitializeComponent();

            //Link Rodapé
            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");

            LblLink.LinkClicked += LblLink_LinkClicked;

            //Corrige evento do DataGridView
            DataGridVisu.CellClick += DataGrid_Click;
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            TxtNome.Focus();
        }

        private void LimparCampos()
        {
            TxtID.Clear();
            TxtNome.Clear();   
            TxtIdade.Clear();
            TxtEmail.Clear();
            TxtTelefone.Clear();
            DtpData.Value = DateTime.Now;
            TxtNome.Focus();
        }

        private void AtualizarGrid()
        {
            DataGridVisu.DataSource = null;
            DataGridVisu.DataSource = lista;
        }

        private void DataGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var contato = lista[e.RowIndex];

                TxtID.Text = contato.ID.ToString();
                TxtNome.Text = contato.Nome;
                TxtIdade.Text = contato.Idade.ToString();
                TxtEmail.Text = contato.Email;
                TxtTelefone.Text = contato.Telefone;
                DtpData.Value = contato.DataRegistro;
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            {
                if (TxtNome.Text == "")
                {
                    MessageBox.Show("Informe o nome");
                    return;
                }
                
                if (!Regex.IsMatch(TxtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("E-mail inválido");
                    return;
                }

                Contato c = new Contato();
                c.ID = proximoId++;
                c.Nome = TxtNome.Text.ToUpper();
                c.Idade = int.Parse(TxtIdade.Text);
                c.Email = TxtEmail.Text.ToLower();
                c.Telefone = TxtTelefone.Text;
                c.DataRegistro = DtpData.Value;

                lista.Add(c);
                AtualizarGrid();
                LimparCampos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if(TxtID.Text == "")
            {
                MessageBox.Show("Selecione um registro para alterar");
                return;
            }

            int id = int.Parse(TxtID.Text);

            Contato contato = lista.FirstOrDefault(c => c.ID == id);

            if (contato == null)
            {
                MessageBox.Show("Registro não encontrado");
                return; 
            }

            //Atualizar Dados
            contato.Nome = TxtNome.Text;
            contato.Idade = int.Parse(TxtIdade.Text);
            contato.Email = TxtEmail.Text;
            contato.Telefone = TxtTelefone.Text;    
            contato.DataRegistro = DtpData.Value;

            AtualizarGrid();
            MessageBox.Show("Registro alterado com sucesso");
            LimparCampos();

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir");
                return;
            }

            if (MessageBox.Show("Deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = int.Parse(TxtID.Text);

            Contato contato = lista.FirstOrDefault(c => c.ID == id);

            if (contato != null)
            {
                lista.Remove(contato);
                AtualizarGrid();
                LimparCampos();

                MessageBox.Show("Registro excluído com sucesso");
            }
        }

        private void BtnMostrarDados_Click(object sender, EventArgs e)
        {
            DataGridVisu.DataSource = null;
            DataGridVisu.DataSource = lista;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = TxtID.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(pesquisa))
            {
                DataGridVisu.DataSource = null;
                DataGridVisu.DataSource = lista;
                return;
            }

            var listaFiltrada = lista
                .Where(c => c.Nome.ToLower().Contains(pesquisa))
                .ToList();

            DataGridVisu.DataSource = null;
            DataGridVisu.DataSource = listaFiltrada;
        }
    }
}
