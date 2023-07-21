namespace gp_pichau.view
{
    partial class PesquisarPecas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pesquisarCod = new System.Windows.Forms.Button();
            this.BuscarCodCapacidade = new System.Windows.Forms.TextBox();
            this.BuscarCodMarca = new System.Windows.Forms.TextBox();
            this.buscarCodPeca = new System.Windows.Forms.TextBox();
            this.buscarCod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdPecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesquisarNome = new System.Windows.Forms.Button();
            this.buscarNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 241);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pesquisarCod);
            this.tabPage1.Controls.Add(this.BuscarCodCapacidade);
            this.tabPage1.Controls.Add(this.BuscarCodMarca);
            this.tabPage1.Controls.Add(this.buscarCodPeca);
            this.tabPage1.Controls.Add(this.buscarCod);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pesquisarCod
            // 
            this.pesquisarCod.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pesquisarCod.Location = new System.Drawing.Point(329, 24);
            this.pesquisarCod.Name = "pesquisarCod";
            this.pesquisarCod.Size = new System.Drawing.Size(75, 23);
            this.pesquisarCod.TabIndex = 8;
            this.pesquisarCod.Text = "Pesquisar";
            this.pesquisarCod.UseVisualStyleBackColor = true;
            this.pesquisarCod.Click += new System.EventHandler(this.pesquisarCod_Click);
            // 
            // BuscarCodCapacidade
            // 
            this.BuscarCodCapacidade.Location = new System.Drawing.Point(12, 165);
            this.BuscarCodCapacidade.Name = "BuscarCodCapacidade";
            this.BuscarCodCapacidade.Size = new System.Drawing.Size(261, 24);
            this.BuscarCodCapacidade.TabIndex = 7;
            // 
            // BuscarCodMarca
            // 
            this.BuscarCodMarca.Location = new System.Drawing.Point(12, 121);
            this.BuscarCodMarca.Name = "BuscarCodMarca";
            this.BuscarCodMarca.Size = new System.Drawing.Size(118, 24);
            this.BuscarCodMarca.TabIndex = 6;
            // 
            // buscarCodPeca
            // 
            this.buscarCodPeca.Location = new System.Drawing.Point(12, 77);
            this.buscarCodPeca.Name = "buscarCodPeca";
            this.buscarCodPeca.Size = new System.Drawing.Size(214, 24);
            this.buscarCodPeca.TabIndex = 5;
            // 
            // buscarCod
            // 
            this.buscarCod.Location = new System.Drawing.Point(120, 23);
            this.buscarCod.Name = "buscarCod";
            this.buscarCod.Size = new System.Drawing.Size(203, 24);
            this.buscarCod.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Capacidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Peça:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo da Peça:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.pesquisarNome);
            this.tabPage2.Controls.Add(this.buscarNome);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Nome";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPecas,
            this.Peca,
            this.Marca,
            this.Capacidade});
            this.dataGridView1.Location = new System.Drawing.Point(6, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(430, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // IdPecas
            // 
            this.IdPecas.HeaderText = "Codigo";
            this.IdPecas.Name = "IdPecas";
            // 
            // Peca
            // 
            this.Peca.HeaderText = "Peça";
            this.Peca.Name = "Peca";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Capacidade
            // 
            this.Capacidade.HeaderText = "Capacidade";
            this.Capacidade.Name = "Capacidade";
            // 
            // pesquisarNome
            // 
            this.pesquisarNome.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pesquisarNome.Location = new System.Drawing.Point(328, 21);
            this.pesquisarNome.Name = "pesquisarNome";
            this.pesquisarNome.Size = new System.Drawing.Size(75, 23);
            this.pesquisarNome.TabIndex = 17;
            this.pesquisarNome.Text = "Pesquisar";
            this.pesquisarNome.UseVisualStyleBackColor = true;
            // 
            // buscarNome
            // 
            this.buscarNome.Location = new System.Drawing.Point(119, 21);
            this.buscarNome.Name = "buscarNome";
            this.buscarNome.Size = new System.Drawing.Size(203, 24);
            this.buscarNome.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nome da Peça:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Peças:";
            // 
            // PesquisarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(458, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "PesquisarPecas";
            this.Text = "Pesquisar Peças";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button pesquisarCod;
        private TextBox BuscarCodCapacidade;
        private TextBox BuscarCodMarca;
        private TextBox buscarCodPeca;
        private TextBox buscarCod;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private Button pesquisarNome;
        private TextBox buscarNome;
        private Label label9;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdPecas;
        private DataGridViewTextBoxColumn Peca;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Capacidade;
    }
}