﻿namespace gp_pichau.view
{
    partial class Cadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxPeca = new System.Windows.Forms.TextBox();
            this.txtboxmarca = new System.Windows.Forms.TextBox();
            this.txtboxcapacidade = new System.Windows.Forms.TextBox();
            this.btncadastrarpecas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Peças";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peça";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidade";
            // 
            // txtboxPeca
            // 
            this.txtboxPeca.Location = new System.Drawing.Point(48, 87);
            this.txtboxPeca.Name = "txtboxPeca";
            this.txtboxPeca.Size = new System.Drawing.Size(177, 23);
            this.txtboxPeca.TabIndex = 4;
            // 
            // txtboxmarca
            // 
            this.txtboxmarca.Location = new System.Drawing.Point(48, 131);
            this.txtboxmarca.Name = "txtboxmarca";
            this.txtboxmarca.Size = new System.Drawing.Size(124, 23);
            this.txtboxmarca.TabIndex = 5;
            // 
            // txtboxcapacidade
            // 
            this.txtboxcapacidade.Location = new System.Drawing.Point(48, 175);
            this.txtboxcapacidade.Name = "txtboxcapacidade";
            this.txtboxcapacidade.Size = new System.Drawing.Size(158, 23);
            this.txtboxcapacidade.TabIndex = 6;
            // 
            // btncadastrarpecas
            // 
            this.btncadastrarpecas.ForeColor = System.Drawing.Color.Black;
            this.btncadastrarpecas.Location = new System.Drawing.Point(48, 204);
            this.btncadastrarpecas.Name = "btncadastrarpecas";
            this.btncadastrarpecas.Size = new System.Drawing.Size(124, 23);
            this.btncadastrarpecas.TabIndex = 7;
            this.btncadastrarpecas.Text = "Cadastrar";
            this.btncadastrarpecas.UseVisualStyleBackColor = true;
            this.btncadastrarpecas.Click += new System.EventHandler(this.btncadastrarpecas_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(310, 292);
            this.Controls.Add(this.btncadastrarpecas);
            this.Controls.Add(this.txtboxcapacidade);
            this.Controls.Add(this.txtboxmarca);
            this.Controls.Add(this.txtboxPeca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Cadastrar";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtboxPeca;
        private TextBox txtboxmarca;
        private TextBox txtboxcapacidade;
        private Button btncadastrarpecas;
    }
}