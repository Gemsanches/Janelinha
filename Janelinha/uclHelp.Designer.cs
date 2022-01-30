
namespace Janelinha
{
    partial class uclHelp
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
            System.Windows.Forms.TextBox titleAjuda;
            System.Windows.Forms.TextBox descNome;
            this.varNome = new System.Windows.Forms.TextBox();
            this.panelNome = new System.Windows.Forms.Panel();
            titleAjuda = new System.Windows.Forms.TextBox();
            descNome = new System.Windows.Forms.TextBox();
            this.panelNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleAjuda
            // 
            titleAjuda.BackColor = System.Drawing.SystemColors.Control;
            titleAjuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            titleAjuda.CausesValidation = false;
            titleAjuda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            titleAjuda.Cursor = System.Windows.Forms.Cursors.Default;
            titleAjuda.Dock = System.Windows.Forms.DockStyle.Top;
            titleAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleAjuda.Location = new System.Drawing.Point(0, 0);
            titleAjuda.Name = "titleAjuda";
            titleAjuda.ReadOnly = true;
            titleAjuda.ShortcutsEnabled = false;
            titleAjuda.Size = new System.Drawing.Size(503, 37);
            titleAjuda.TabIndex = 0;
            titleAjuda.TabStop = false;
            titleAjuda.Text = "AJUDA";
            titleAjuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descNome
            // 
            descNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            descNome.Cursor = System.Windows.Forms.Cursors.Default;
            descNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descNome.ForeColor = System.Drawing.SystemColors.InfoText;
            descNome.Location = new System.Drawing.Point(3, 3);
            descNome.Name = "descNome";
            descNome.ReadOnly = true;
            descNome.ShortcutsEnabled = false;
            descNome.Size = new System.Drawing.Size(42, 24);
            descNome.TabIndex = 0;
            descNome.TabStop = false;
            descNome.Text = "F1 -";
            // 
            // varNome
            // 
            this.varNome.AllowDrop = true;
            this.varNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varNome.BackColor = System.Drawing.SystemColors.Control;
            this.varNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.varNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varNome.Location = new System.Drawing.Point(51, 7);
            this.varNome.Multiline = true;
            this.varNome.Name = "varNome";
            this.varNome.Size = new System.Drawing.Size(443, 26);
            this.varNome.TabIndex = 0;
            this.varNome.TabStop = false;
            this.varNome.Text = "Cadastro de clientes";
            // 
            // panelNome
            // 
            this.panelNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNome.Controls.Add(this.varNome);
            this.panelNome.Controls.Add(descNome);
            this.panelNome.Location = new System.Drawing.Point(3, 43);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(497, 35);
            this.panelNome.TabIndex = 2;
            // 
            // uclHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelNome);
            this.Controls.Add(titleAjuda);
            this.Name = "uclHelp";
            this.Size = new System.Drawing.Size(503, 400);
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox varNome;
        private System.Windows.Forms.Panel panelNome;
    }
}
