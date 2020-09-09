namespace CRUD_Basico
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvAlunos = new System.Windows.Forms.DataGridView();
            this.CkbAtivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.TsbEditar = new System.Windows.Forms.ToolStripButton();
            this.TsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlunos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DgvAlunos);
            this.groupBox1.Controls.Add(this.CkbAtivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpDtNascimento);
            this.groupBox1.Controls.Add(this.TxbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 729);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Aluno";
            // 
            // DgvAlunos
            // 
            this.DgvAlunos.AllowUserToAddRows = false;
            this.DgvAlunos.AllowUserToDeleteRows = false;
            this.DgvAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlunos.Location = new System.Drawing.Point(25, 294);
            this.DgvAlunos.MultiSelect = false;
            this.DgvAlunos.Name = "DgvAlunos";
            this.DgvAlunos.ReadOnly = true;
            this.DgvAlunos.RowHeadersVisible = false;
            this.DgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAlunos.Size = new System.Drawing.Size(781, 418);
            this.DgvAlunos.TabIndex = 7;
            this.DgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlunos_CellClick);
            // 
            // CkbAtivo
            // 
            this.CkbAtivo.AutoSize = true;
            this.CkbAtivo.Location = new System.Drawing.Point(600, 40);
            this.CkbAtivo.Name = "CkbAtivo";
            this.CkbAtivo.Size = new System.Drawing.Size(99, 37);
            this.CkbAtivo.TabIndex = 5;
            this.CkbAtivo.Text = "Ativo";
            this.CkbAtivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de Nascimento:";
            // 
            // DtpDtNascimento
            // 
            this.DtpDtNascimento.Location = new System.Drawing.Point(130, 193);
            this.DtpDtNascimento.Name = "DtpDtNascimento";
            this.DtpDtNascimento.Size = new System.Drawing.Size(569, 40);
            this.DtpDtNascimento.TabIndex = 2;
            // 
            // TxbNome
            // 
            this.TxbNome.Location = new System.Drawing.Point(130, 95);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(569, 40);
            this.TxbNome.TabIndex = 1;
            this.TxbNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbNome_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNovo,
            this.toolStripSeparator1,
            this.TsbSalvar,
            this.TsbEditar,
            this.TsbExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbNovo
            // 
            this.TsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("TsbNovo.Image")));
            this.TsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNovo.Name = "TsbNovo";
            this.TsbNovo.Size = new System.Drawing.Size(91, 44);
            this.TsbNovo.Text = "Novo";
            this.TsbNovo.Click += new System.EventHandler(this.TsbNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("TsbSalvar.Image")));
            this.TsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Size = new System.Drawing.Size(97, 44);
            this.TsbSalvar.Text = "Salvar";
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // TsbEditar
            // 
            this.TsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEditar.Image")));
            this.TsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEditar.Name = "TsbEditar";
            this.TsbEditar.Size = new System.Drawing.Size(95, 44);
            this.TsbEditar.Text = "Editar";
            this.TsbEditar.Click += new System.EventHandler(this.TsbEditar_Click);
            // 
            // TsbExcluir
            // 
            this.TsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("TsbExcluir.Image")));
            this.TsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExcluir.Name = "TsbExcluir";
            this.TsbExcluir.Size = new System.Drawing.Size(102, 44);
            this.TsbExcluir.Text = "Excluir";
            this.TsbExcluir.Click += new System.EventHandler(this.TsbExcluir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 791);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "FormPrincipal";
            this.Text = "Sistema N12";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlunos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CkbAtivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpDtNascimento;
        private System.Windows.Forms.TextBox TxbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvAlunos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripButton TsbEditar;
        private System.Windows.Forms.ToolStripButton TsbExcluir;
    }
}

