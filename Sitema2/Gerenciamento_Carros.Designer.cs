namespace Sitema2
{
    partial class Gerenciamento_Carros
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
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.buttonRemoverClientes = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciamento de Carros\r\n";
            // 
            // dgvCarros
            // 
            this.dgvCarros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(12, 95);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(528, 298);
            this.dgvCarros.TabIndex = 5;
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPesquisarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarClientes.ForeColor = System.Drawing.Color.Snow;
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(546, 95);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(185, 54);
            this.buttonPesquisarClientes.TabIndex = 6;
            this.buttonPesquisarClientes.Text = "Pesquisar Clientes";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = false;
            this.buttonPesquisarClientes.Click += new System.EventHandler(this.buttonPesquisarClientes_Click);
            // 
            // buttonRemoverClientes
            // 
            this.buttonRemoverClientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRemoverClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoverClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoverClientes.ForeColor = System.Drawing.Color.Snow;
            this.buttonRemoverClientes.Location = new System.Drawing.Point(546, 155);
            this.buttonRemoverClientes.Name = "buttonRemoverClientes";
            this.buttonRemoverClientes.Size = new System.Drawing.Size(185, 50);
            this.buttonRemoverClientes.TabIndex = 7;
            this.buttonRemoverClientes.Text = "Remover Clientes";
            this.buttonRemoverClientes.UseVisualStyleBackColor = false;
            this.buttonRemoverClientes.Click += new System.EventHandler(this.buttonRemoverClientes_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.Color.Snow;
            this.buttonFechar.Location = new System.Drawing.Point(546, 342);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(185, 51);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // Gerenciamento_Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonRemoverClientes);
            this.Controls.Add(this.buttonPesquisarClientes);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.label1);
            this.Name = "Gerenciamento_Carros";
            this.Text = "Gerenciamento_Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Button buttonPesquisarClientes;
        private System.Windows.Forms.Button buttonRemoverClientes;
        private System.Windows.Forms.Button buttonFechar;
    }
}