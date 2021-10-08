using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula19Projetofinal_6320048
{
    public partial class CadastroQuartos : Form
    {
        public CadastroQuartos()
        {
            InitializeComponent();
        }

        private void btnCadastrarQuarto_Click(object sender, EventArgs e)
        {
            Quarto reserva = new Quarto(int.Parse(txtNQuarto.Text), txtTipoQuarto.Text, rtxtDescricao.Text);
            reserva.Gravar();
            limpar();
            carrega_gridQuarto();
        }

        private void btnVoltarQuarto_Click(object sender, EventArgs e)
        {
            ReservarQuarto reserva = new ReservarQuarto();
            this.Hide();
            reserva.Show();
        }

        public void limpar()
        {
            txtNQuarto.Text = null;
            txtTipoQuarto.Text = null;
            rtxtDescricao.Text = null;
        }

        private void CadastroQuartos_Load(object sender, EventArgs e)
        {
            
            
            carrega_gridQuarto();
        }

        public void carrega_gridQuarto()
        {
            Quarto q = new Quarto();
            dtaGridQuarto.DataSource = q.LerQuarto();
        }

        private void btnAtualizarQuarto_Click(object sender, EventArgs e)
        {
                Quarto a = new Quarto(int.Parse(txtNQuarto.Text), txtTipoQuarto.Text, rtxtDescricao.Text);
                a.AtualizarQuarto();
                limpar();
                carrega_gridQuarto();
        }

        private void dtaGridQuarto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Quarto q = (Quarto)dtaGridQuarto.Rows[e.RowIndex].DataBoundItem;
            txtNQuarto.Text = q.Numero.ToString();
            txtTipoQuarto.Text = q.TipoQuarto;
            rtxtDescricao.Text = q.Descricao;
        }

        private void btnExcluirQuarto_Click(object sender, EventArgs e)
        {

            Quarto excluir = new Quarto();
            excluir.Numero = int.Parse(txtNQuarto.Text);
            excluir.ExcluirQuarto();

            limpar();
            carrega_gridQuarto();

        }

        private void txtNQuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Quarto quarto = new Quarto();
                quarto.Numero = int.Parse(txtNQuarto.Text); 
                quarto.Buscar();

                if (quarto.TipoQuarto != "")
                {
                    txtTipoQuarto.Text = quarto.TipoQuarto;
                }
                else
                {
                    txtNQuarto.Text = null;
                    rtxtDescricao.Text = null;
                }
                rtxtDescricao.Text = quarto.Descricao;
                txtTipoQuarto.Text = quarto.TipoQuarto;
            }
        }
    }
}
