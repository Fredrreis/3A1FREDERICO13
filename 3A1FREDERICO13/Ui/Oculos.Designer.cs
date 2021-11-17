namespace _3A1FREDERICO13.Ui
{
    partial class Oculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oculos));
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.dtgListarOculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarOculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(23, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 28;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(189, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 20);
            this.txtNome.TabIndex = 27;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(23, 102);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 26;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 84);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(98, 13);
            this.lblTipo.TabIndex = 25;
            this.lblTipo.Text = "TIPO(GRAU/SOL):";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.Location = new System.Drawing.Point(405, 150);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(178, 52);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(222, 150);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(177, 51);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(23, 150);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 51);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(452, 37);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(131, 20);
            this.txtCor.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(186, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "NOME:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(449, 18);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(33, 13);
            this.lblCor.TabIndex = 19;
            this.lblCor.Text = "COR:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(189, 102);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(169, 20);
            this.txtPreco.TabIndex = 31;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(186, 84);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(47, 13);
            this.lblPreco.TabIndex = 32;
            this.lblPreco.Text = "PREÇO:";
            // 
            // dtgListarOculos
            // 
            this.dtgListarOculos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgListarOculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListarOculos.Location = new System.Drawing.Point(23, 228);
            this.dtgListarOculos.Name = "dtgListarOculos";
            this.dtgListarOculos.Size = new System.Drawing.Size(560, 220);
            this.dtgListarOculos.TabIndex = 33;
            this.dtgListarOculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListarOculos_CellClick_1);
            this.dtgListarOculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListarOculos_CellContentClick_1);
            // 
            // Oculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 461);
            this.Controls.Add(this.dtgListarOculos);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Oculos";
            this.Text = "Oculos";
            this.Load += new System.EventHandler(this.Oculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarOculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.DataGridView dtgListarOculos;
    }
}