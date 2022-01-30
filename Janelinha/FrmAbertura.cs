using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janelinha
{
    public partial class FrmAbertura : Form
    {
        public FrmAbertura() { InitializeComponent(); }

        #region Métodos internos
        private void Sair()
        {
            if (Equals(DialogResult.Yes, MessageBox.Show("Quer realmennte sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question)))
                Application.Exit();
        }
        private void AbreNoPainelPrincpal(Type type) =>
            ControladorDeTelas.AbrirFormulario(PNLPrincipal, type);
        
        #endregion
        #region Invocação das teclas
        private void InvocaEscape() => AbreNoPainelPrincpal(typeof(uclHelp));
        private void InvocaF1() => AbreNoPainelPrincpal(typeof(uclCadastroCliente));
        private void InvocaF2() => MessageBox.Show("Função 2 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF3() => MessageBox.Show("Função 3 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF4() => MessageBox.Show("Função 4 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF5() => MessageBox.Show("Função 5 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF6() => MessageBox.Show("Função 6 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF7() => MessageBox.Show("Função 7 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF8() => MessageBox.Show("Função 8 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF9() => MessageBox.Show("Função 9 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF10() => MessageBox.Show("Função 10 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF11() => MessageBox.Show("Função 11 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void InvocaF12() => MessageBox.Show("Função 12 ainda não implementado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        #endregion
        #region Comandos ao apertar os botões do menu superior
        private void BTNsair_Click(object sender, EventArgs e) => Sair();
        private void BTNAjuda_MouseUp(object sender, MouseEventArgs e) => InvocaEscape();
        private void BTNF1_MouseUp(object sender, MouseEventArgs e) => InvocaF1();
        private void BTNF2_MouseUp(object sender, MouseEventArgs e) => InvocaF2();
        private void BTNF3_MouseUp(object sender, MouseEventArgs e) => InvocaF3();
        private void BTNF4_MouseUp(object sender, MouseEventArgs e) => InvocaF4();
        private void BTNF5_MouseUp(object sender, MouseEventArgs e) => InvocaF5();
        private void BTNF6_MouseUp(object sender, MouseEventArgs e) => InvocaF6();
        private void BTNF7_MouseUp(object sender, MouseEventArgs e) => InvocaF7();
        private void BTNF8_MouseUp(object sender, MouseEventArgs e) => InvocaF8();
        private void BTNF9_MouseUp(object sender, MouseEventArgs e) => InvocaF9();
        private void BTNF10_MouseUp(object sender, MouseEventArgs e) => InvocaF10();
        private void BTNF11_MouseUp(object sender, MouseEventArgs e) => InvocaF11();
        private void BTNF12_MouseUp(object sender, MouseEventArgs e) => InvocaF12();
        #endregion
        #region Comandos por teclas
        private void FrmAbertura_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    InvocaEscape();
                    break;
                case Keys.F1:
                    InvocaF1();
                    break;
                case Keys.F2:
                    InvocaF2();
                    break;
                case Keys.F3:
                    InvocaF3();
                    break;
                case Keys.F4:
                    InvocaF4();
                    break;
                case Keys.F5:
                    InvocaF5();
                    break;
                case Keys.F6:
                    InvocaF6();
                    break;
                case Keys.F7:
                    InvocaF7();
                    break;
                case Keys.F8:
                    InvocaF8();
                    break;
                case Keys.F9:
                    InvocaF9();
                    break;
                case Keys.F10:
                    InvocaF10();
                    break;
                case Keys.F11:
                    InvocaF11();
                    break;
                case Keys.F12:
                    InvocaF12();
                    break;
                default:
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
            }
        }

        #endregion
    }
}