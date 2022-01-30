using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Janelinha
{
    public partial class uclCadastroCliente : UserControl
    {
        public uclCadastroCliente()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        #region Métodos internos
        private void GuardarCampo(TextBox campo, String nomeDoCampo)
        {
            if (String.IsNullOrEmpty(campo.Text))
            {
                MessageBox.Show("\""+ nomeDoCampo + "\" é campo obrigatório!", "Campo obrigatório faltando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception("Campo obrigatório faltando");
            }
            else
            {
                string ClienteNome = campo.Text;
            }
        }
        private void LimparCampo(TextBox campo)
        {
            campo.Text = "";
        }
        private void LimparCamposTodos()
        {
            LimparCampo(varNome);
            varCod.Text = "";
        }
        private void GerarCodigo()
        {
            varCod.Text = "1";
        }
        private void IncluirOuAtualizar()
        {
            if(String.IsNullOrEmpty(varCod.Text))
            {
                GerarCodigo();
                //incluir
            }
            else
            {
                //atualizar
            }
        }
        #endregion
        #region Botões do menu interno
        private void btnSalvar_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                GuardarCampo(varNome, "Nome");
                IncluirOuAtualizar();
            }
            catch { }
        }
        private void btnLimpar_MouseUp(object sender, MouseEventArgs e)
        {
            LimparCamposTodos();
        }
        private void btnDup_MouseUp(object sender, MouseEventArgs e)
        {
            LimparCampo(varCod);
            //a ideia é limpar o código para permitir salvar os mesmos dados como novo registro
        }
        private void btnEditar_MouseUp(object sender, MouseEventArgs e)
        {
            string ClienteCodigo = Interaction.InputBox("Informe o código do Cliente", "CODIGO", "", -1, -1);
            //caixa de diálogo para digitar o código
            //carrega o cliente com o código digitado
        }
        private void btnExcluir_MouseUp(object sender, MouseEventArgs e)
        {
            //caixa de diálogo para digitar o código
            //carrega o cliente com o código digitado
            if (Equals(DialogResult.Yes, MessageBox.Show("Quer realmennte excluir esse cliente?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)))
                System.Media.SystemSounds.Asterisk.Play();//excluir o dito cujo
        }
        #endregion
    }
}
