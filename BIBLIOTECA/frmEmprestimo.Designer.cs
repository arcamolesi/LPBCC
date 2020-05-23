namespace BIBLIOTECA
{
    partial class frmEmprestimo
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
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.btnGravarEmp = new System.Windows.Forms.Button();
            this.btnCancelarEmp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRemoverEmp = new System.Windows.Forms.Button();
            this.btnEditarEmp = new System.Windows.Forms.Button();
            this.btnNovoEmp = new System.Windows.Forms.Button();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Itens Empréstimo (Livros)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.dgvEmprestimo);
            this.splitContainer1.Panel1.Controls.Add(this.btnGravarEmp);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelarEmp);
            this.splitContainer1.Panel1.Controls.Add(this.btnSair);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoverEmp);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditarEmp);
            this.splitContainer1.Panel1.Controls.Add(this.btnNovoEmp);
            this.splitContainer1.Panel1.Controls.Add(this.txtClienteID);
            this.splitContainer1.Panel1.Controls.Add(this.dtpData);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCliente);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmpID);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1299, 719);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.data,
            this.clienteId});
            this.dgvEmprestimo.Location = new System.Drawing.Point(781, 36);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.RowHeadersWidth = 51;
            this.dgvEmprestimo.RowTemplate.Height = 24;
            this.dgvEmprestimo.Size = new System.Drawing.Size(486, 283);
            this.dgvEmprestimo.TabIndex = 14;
            this.dgvEmprestimo.DoubleClick += new System.EventHandler(this.dgvEmprestimo_DoubleClick);
            // 
            // btnGravarEmp
            // 
            this.btnGravarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarEmp.Location = new System.Drawing.Point(398, 270);
            this.btnGravarEmp.Name = "btnGravarEmp";
            this.btnGravarEmp.Size = new System.Drawing.Size(154, 49);
            this.btnGravarEmp.TabIndex = 13;
            this.btnGravarEmp.Text = "&Gravar";
            this.btnGravarEmp.UseVisualStyleBackColor = true;
            this.btnGravarEmp.Click += new System.EventHandler(this.btnGravarEmp_Click);
            // 
            // btnCancelarEmp
            // 
            this.btnCancelarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEmp.Location = new System.Drawing.Point(223, 270);
            this.btnCancelarEmp.Name = "btnCancelarEmp";
            this.btnCancelarEmp.Size = new System.Drawing.Size(154, 49);
            this.btnCancelarEmp.TabIndex = 12;
            this.btnCancelarEmp.Text = "&Cancelar";
            this.btnCancelarEmp.UseVisualStyleBackColor = true;
            this.btnCancelarEmp.Click += new System.EventHandler(this.btnCancelarEmp_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(44, 270);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(154, 49);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRemoverEmp
            // 
            this.btnRemoverEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverEmp.Location = new System.Drawing.Point(398, 210);
            this.btnRemoverEmp.Name = "btnRemoverEmp";
            this.btnRemoverEmp.Size = new System.Drawing.Size(154, 49);
            this.btnRemoverEmp.TabIndex = 10;
            this.btnRemoverEmp.Text = "&Remover";
            this.btnRemoverEmp.UseVisualStyleBackColor = true;
            this.btnRemoverEmp.Click += new System.EventHandler(this.btnRemoverEmp_Click);
            // 
            // btnEditarEmp
            // 
            this.btnEditarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmp.Location = new System.Drawing.Point(223, 210);
            this.btnEditarEmp.Name = "btnEditarEmp";
            this.btnEditarEmp.Size = new System.Drawing.Size(154, 49);
            this.btnEditarEmp.TabIndex = 9;
            this.btnEditarEmp.Text = "&Editar";
            this.btnEditarEmp.UseVisualStyleBackColor = true;
            this.btnEditarEmp.Click += new System.EventHandler(this.btnEditarEmp_Click);
            // 
            // btnNovoEmp
            // 
            this.btnNovoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoEmp.Location = new System.Drawing.Point(44, 210);
            this.btnNovoEmp.Name = "btnNovoEmp";
            this.btnNovoEmp.Size = new System.Drawing.Size(154, 49);
            this.btnNovoEmp.TabIndex = 8;
            this.btnNovoEmp.Text = "&Novo";
            this.btnNovoEmp.UseVisualStyleBackColor = true;
            this.btnNovoEmp.Click += new System.EventHandler(this.btnNovoEmp_Click);
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(474, 81);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(198, 34);
            this.txtClienteID.TabIndex = 7;
            this.txtClienteID.Leave += new System.EventHandler(this.txtClienteID_Leave);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(158, 130);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(148, 34);
            this.dtpData.TabIndex = 6;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(158, 78);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(310, 37);
            this.cmbCliente.TabIndex = 5;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.Leave += new System.EventHandler(this.cmbCliente_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(153, 36);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(79, 29);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empréstimo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "CLIENTE";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.Width = 94;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "DATA";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.Width = 74;
            // 
            // clienteId
            // 
            this.clienteId.DataPropertyName = "clienteId";
            this.clienteId.HeaderText = "clienteId";
            this.clienteId.MinimumWidth = 6;
            this.clienteId.Name = "clienteId";
            this.clienteId.Visible = false;
            this.clienteId.Width = 125;
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 719);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo";
            this.Load += new System.EventHandler(this.frmEmprestimo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravarEmp;
        private System.Windows.Forms.Button btnCancelarEmp;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRemoverEmp;
        private System.Windows.Forms.Button btnEditarEmp;
        private System.Windows.Forms.Button btnNovoEmp;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteId;
    }
}