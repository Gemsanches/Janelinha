
namespace Janelinha
{
    partial class uclCadastroCliente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TextBox titleClienteCadastro;
            System.Windows.Forms.Label obsNome;
            this.varNome = new System.Windows.Forms.TextBox();
            this.panelNome = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Panel();
            this.DescCod = new System.Windows.Forms.Label();
            this.varCod = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDup = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            titleClienteCadastro = new System.Windows.Forms.TextBox();
            obsNome = new System.Windows.Forms.Label();
            this.panelNome.SuspendLayout();
            this.Codigo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleClienteCadastro
            // 
            titleClienteCadastro.BackColor = System.Drawing.SystemColors.Control;
            titleClienteCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            titleClienteCadastro.CausesValidation = false;
            titleClienteCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            titleClienteCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            titleClienteCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            titleClienteCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleClienteCadastro.Location = new System.Drawing.Point(0, 0);
            titleClienteCadastro.Name = "titleClienteCadastro";
            titleClienteCadastro.ReadOnly = true;
            titleClienteCadastro.ShortcutsEnabled = false;
            titleClienteCadastro.Size = new System.Drawing.Size(503, 37);
            titleClienteCadastro.TabIndex = 0;
            titleClienteCadastro.TabStop = false;
            titleClienteCadastro.Text = "CLIENTE (CADASTRO)";
            titleClienteCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // obsNome
            // 
            obsNome.AutoSize = true;
            obsNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            obsNome.Location = new System.Drawing.Point(67, 26);
            obsNome.Name = "obsNome";
            obsNome.Size = new System.Drawing.Size(68, 9);
            obsNome.TabIndex = 2;
            obsNome.Text = "Campo obrigatório";
            // 
            // varNome
            // 
            this.varNome.AllowDrop = true;
            this.varNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.varNome.Location = new System.Drawing.Point(69, 3);
            this.varNome.Multiline = true;
            this.varNome.Name = "varNome";
            this.varNome.Size = new System.Drawing.Size(425, 20);
            this.varNome.TabIndex = 1;
            // 
            // panelNome
            // 
            this.panelNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNome.Controls.Add(this.labelNome);
            this.panelNome.Controls.Add(obsNome);
            this.panelNome.Controls.Add(this.varNome);
            this.panelNome.Location = new System.Drawing.Point(3, 73);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(497, 42);
            this.panelNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(3, 3);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(60, 20);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome:";
            // 
            // Codigo
            // 
            this.Codigo.Controls.Add(this.DescCod);
            this.Codigo.Controls.Add(this.varCod);
            this.Codigo.Dock = System.Windows.Forms.DockStyle.Right;
            this.Codigo.Location = new System.Drawing.Point(365, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(138, 30);
            this.Codigo.TabIndex = 4;
            // 
            // DescCod
            // 
            this.DescCod.AutoSize = true;
            this.DescCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescCod.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DescCod.Location = new System.Drawing.Point(3, 6);
            this.DescCod.Name = "DescCod";
            this.DescCod.Size = new System.Drawing.Size(50, 13);
            this.DescCod.TabIndex = 3;
            this.DescCod.Text = "Código:";
            // 
            // varCod
            // 
            this.varCod.AllowDrop = true;
            this.varCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varCod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.varCod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.varCod.ForeColor = System.Drawing.SystemColors.MenuText;
            this.varCod.Location = new System.Drawing.Point(59, 3);
            this.varCod.Multiline = true;
            this.varCod.Name = "varCod";
            this.varCod.Size = new System.Drawing.Size(76, 22);
            this.varCod.TabIndex = 1;
            this.varCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpar.Location = new System.Drawing.Point(0, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 30);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLimpar_MouseUp);
            // 
            // btnDup
            // 
            this.btnDup.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDup.Location = new System.Drawing.Point(110, 0);
            this.btnDup.Name = "btnDup";
            this.btnDup.Size = new System.Drawing.Size(55, 30);
            this.btnDup.TabIndex = 6;
            this.btnDup.Text = "Replicar";
            this.btnDup.UseVisualStyleBackColor = true;
            this.btnDup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDup_MouseUp);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.Codigo);
            this.pnlBotoes.Controls.Add(this.btnEditar);
            this.pnlBotoes.Controls.Add(this.btnDup);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 37);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(503, 30);
            this.pnlBotoes.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.Location = new System.Drawing.Point(55, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(55, 30);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSalvar_MouseUp);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditar.Location = new System.Drawing.Point(165, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(55, 30);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEditar_MouseUp);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.Location = new System.Drawing.Point(220, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(55, 30);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnExcluir_MouseUp);
            // 
            // uclCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(titleClienteCadastro);
            this.Controls.Add(this.panelNome);
            this.Name = "uclCadastroCliente";
            this.Size = new System.Drawing.Size(503, 400);
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.Codigo.ResumeLayout(false);
            this.Codigo.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox varNome;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel Codigo;
        private System.Windows.Forms.Label DescCod;
        public System.Windows.Forms.TextBox varCod;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDup;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}
