namespace WindowsFormsApp1
{
    partial class Agenda
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.NOME = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lbDados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(65, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(65, 51);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(188, 20);
            this.txtNOME.TabIndex = 3;
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Location = new System.Drawing.Point(12, 51);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(39, 13);
            this.NOME.TabIndex = 2;
            this.NOME.Text = "NOME";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(331, 51);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(180, 20);
            this.txtEMAIL.TabIndex = 5;
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Location = new System.Drawing.Point(286, 51);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(39, 13);
            this.EMAIL.TabIndex = 4;
            this.EMAIL.Text = "EMAIL";
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(193, 77);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 6;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(274, 77);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 7;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(355, 77);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btLocalizar.TabIndex = 8;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(436, 77);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(15, 110);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(496, 157);
            this.dgvDados.TabIndex = 10;
            // 
            // lbDados
            // 
            this.lbDados.AutoSize = true;
            this.lbDados.Location = new System.Drawing.Point(16, 272);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(201, 13);
            this.lbDados.TabIndex = 11;
            this.lbDados.Text = "Local onde os dados estão armazenados";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 294);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ID);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lbDados;
    }
}

