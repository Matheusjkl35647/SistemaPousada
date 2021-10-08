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
    public partial class ReservarQuarto : Form
    {
        public ReservarQuarto()
        {
            InitializeComponent();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if((txtNomePasseioTurismo.Text == "" || mskDataPasseioReserva.Text == "") && (txtLocalCongresso.Text == "" || txtValorCongresso.Text == ""))
            {

                Reservar reserva = new Reservar(txtNomeReserva.Text, mskCpf.Text, cbxTipoQuarto.Text, mskDataEntradaReserva.Text, mskdataSaidaReserva.Text);
                reserva.Gravar();
                limpar();
                carrega3_grid();
            } 
            else if (txtLocalCongresso.Text == "" || txtValorCongresso.Text == "")
            {
                Turismo turismo = new Turismo(txtNomeReserva.Text, mskCpf.Text, cbxTipoQuarto.Text, mskDataEntradaReserva.Text, mskdataSaidaReserva.Text, txtNomePasseioTurismo.Text, mskDataPasseioReserva.Text);
                turismo.Gravar();
                limpar();
                carrega2_grid();
            }
            else if (txtNomePasseioTurismo.Text == "" || mskDataPasseioReserva.Text == "")
            {
                Congresso congresso = new Congresso(txtNomeReserva.Text, mskCpf.Text, cbxTipoQuarto.Text, mskDataEntradaReserva.Text, mskdataSaidaReserva.Text, txtLocalCongresso.Text, int.Parse(txtValorCongresso.Text));
                congresso.Gravar();
                limpar();
                carrega_grid();
            }
        }

        private void limpar()
        {
            txtLocalCongresso.Text = null;
            txtNomePasseioTurismo.Text = null;
            txtNomeReserva.Text = null;
            txtValorCongresso.Text = null;
            mskCpf.Text = null;
            mskDataEntradaReserva.Text = null;
            mskDataPasseioReserva.Text = null;
            mskdataSaidaReserva.Text = null;
            cbxNumQuartoReserva.Text = null;
            cbxTipoQuarto.Text = null;            
        }

        private void ReservarQuarto_Load(object sender, EventArgs e)
        {
            carrega_grid();
            carrega2_grid();
            carrega3_grid();
        }

        private void carrega_grid()
        {
            Congresso congresso = new Congresso();
            dtgridReserva.DataSource = congresso.Ler();

        }

        private void carrega2_grid()
        {
            Turismo turismo = new Turismo();
            dtagridTurismo.DataSource = turismo.Ler();

        }

        private void carrega3_grid()
        {
            Reservar reserva = new Reservar();
            dtagridReservaComum.DataSource = reserva.Ler();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (mskCpf.Text == "")
            {
                Reservar reserva = new Reservar(txtNomeReserva.Text, mskCpf.Text, cbxTipoQuarto.Text, mskDataEntradaReserva.Text, mskdataSaidaReserva.Text);
                reserva.Atualizar();
                limpar();
                carrega3_grid();
            } 
            else if (txtValorCongresso.Text == "")
            {
                Turismo turismo = new Turismo(txtNomeReserva.Text, mskCpf.Text, cbxTipoQuarto.Text, mskDataEntradaReserva.Text, mskdataSaidaReserva.Text, txtNomePasseioTurismo.Text, mskDataPasseioReserva.Text);
                turismo.Atualizar();
                limpar();
                carrega2_grid();
            }
            else if (txtNomePasseioTurismo.Text == "")
            {
                Congresso congresso = new Congresso(txtNomeReserva.Text, mskCpf.Text, cbxTipoQuarto.Text, mskDataEntradaReserva.Text, mskdataSaidaReserva.Text, txtLocalCongresso.Text, int.Parse(txtValorCongresso.Text));
                congresso.Atualizar();
                limpar();
                carrega_grid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                if((txtNomePasseioTurismo.Text == "" || mskDataPasseioReserva.Text == "") && (txtLocalCongresso.Text == "" || txtValorCongresso.Text == ""))
                {
                    Reservar reserva = new Reservar();
                    reserva.NomeReserva = txtNomeReserva.Text;
                    reserva.Excluir();

                    limpar();
                    carrega3_grid();
                } 
                else if (txtLocalCongresso.Text == "" || txtValorCongresso.Text == "")
                {
                    Turismo turismo = new Turismo();
                    turismo.NomePasseio = txtNomePasseioTurismo.Text;
                    turismo.Excluir();
                    limpar();
                    carrega2_grid();
                }
                else if (txtNomePasseioTurismo.Text == "" || mskDataPasseioReserva.Text == "")
                {
                    Congresso congresso = new Congresso();
                    congresso.LocalCongresso = txtLocalCongresso.Text;
                    congresso.Excluir();
                    limpar();
                    carrega_grid();
                } 
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                Reservar reserva = new Reservar();
                reserva.CpfReserva = mskCpf.Text;
                reserva.Busca2();

                if (reserva.NomeReserva != "")
                {
                    txtNomeReserva.Text = reserva.NomeReserva;
                }
                else
                {
                    mskCpf.Text = null;
                    cbxTipoQuarto.Text = null;
                    mskDataEntradaReserva.Text = null;
                    mskdataSaidaReserva.Text = null;
                }
                cbxTipoQuarto.Text = reserva.TipoQuartoReserva;
                mskDataEntradaReserva.Text = reserva.DataEntradaReserva;
                mskdataSaidaReserva.Text = reserva.DataSaidaReserva;


            }
        }


        private void txtNomePasseioTurismo_KeyPress(object sender, KeyPressEventArgs e)
        {

            Turismo tur = new Turismo();
            tur.NomePasseio = txtNomePasseioTurismo.Text;
            tur.Busca1();

            if (tur.DataPasseio != "")
            {
                mskDataPasseioReserva.Text = tur.DataPasseio;
            }
            else
            {
                mskCpf.Text = null;
                txtNomeReserva = null;
                cbxTipoQuarto.Text = null;
                mskDataEntradaReserva.Text = null;
                mskdataSaidaReserva.Text = null;
            }
            txtNomeReserva.Text = tur.NomeReserva;
            mskCpf.Text = tur.CpfReserva;
            cbxTipoQuarto.Text = tur.TipoQuartoReserva;
            mskDataEntradaReserva.Text = tur.DataEntradaReserva;
            mskdataSaidaReserva.Text = tur.DataSaidaReserva;
            mskDataPasseioReserva.Text = tur.DataPasseio;



        }

        private void txtLocalCongresso_KeyPress(object sender, KeyPressEventArgs e)
        {

            Congresso cong = new Congresso();
            cong.LocalCongresso = txtLocalCongresso.Text;
            cong.Busca();

            if (cong.ValorCongresso != 0)
            {
                txtValorCongresso.Text = cong.ValorCongresso.ToString();
            }
            else
            {
                mskCpf.Text = null;
                cbxTipoQuarto.Text = null;
                mskDataEntradaReserva.Text = null;
                mskdataSaidaReserva.Text = null;
            }
            txtNomeReserva.Text = cong.NomeReserva;
            mskCpf.Text = cong.CpfReserva;
            cbxTipoQuarto.Text = cong.TipoQuartoReserva;
            mskDataEntradaReserva.Text = cong.DataEntradaReserva;
            mskdataSaidaReserva.Text = cong.DataSaidaReserva;
            txtValorCongresso.Text = cong.ValorCongresso.ToString();

        }


        private void btnCadatrarQuarto_Click(object sender, EventArgs e)
        {
            CadastroQuartos quarto = new CadastroQuartos();
            this.Hide();
            quarto.Show();
        }

        private void dtagridReservaComum_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            limpar();
            Reservar reserva = (Reservar)dtagridReservaComum.Rows[e.RowIndex].DataBoundItem;

            txtNomeReserva.Text = reserva.NomeReserva;
            mskCpf.Text = reserva.CpfReserva;
            cbxTipoQuarto.Text = reserva.TipoQuartoReserva;
            mskDataEntradaReserva.Text = reserva.DataEntradaReserva;
            mskdataSaidaReserva.Text = reserva.DataSaidaReserva;
        }

        private void dtagridTurismo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar();

            Turismo turismo = (Turismo)dtagridTurismo.Rows[e.RowIndex].DataBoundItem;

            txtNomePasseioTurismo.Text = turismo.NomePasseio;
            mskDataPasseioReserva.Text = turismo.DataPasseio;
            txtNomeReserva.Text = turismo.NomeReserva;
            mskCpf.Text = turismo.CpfReserva;
            cbxTipoQuarto.Text = turismo.TipoQuartoReserva;
            mskDataEntradaReserva.Text = turismo.DataEntradaReserva;
            mskdataSaidaReserva.Text = turismo.DataSaidaReserva;
        }

        private void dtgridReserva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            limpar();
            Congresso congresso = (Congresso)dtgridReserva.Rows[e.RowIndex].DataBoundItem;

            txtLocalCongresso.Text = congresso.LocalCongresso;
            txtValorCongresso.Text = congresso.ValorCongresso.ToString();
            txtNomeReserva.Text = congresso.NomeReserva;
            mskCpf.Text = congresso.CpfReserva;
            cbxTipoQuarto.Text = congresso.TipoQuartoReserva;
            mskDataEntradaReserva.Text = congresso.DataEntradaReserva;
            mskdataSaidaReserva.Text = congresso.DataSaidaReserva;
        }

       
    }
}
