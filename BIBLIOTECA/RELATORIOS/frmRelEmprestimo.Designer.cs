namespace BIBLIOTECA.RELATORIOS
{
    partial class frmRelEmprestimo
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
            this.btnIntOp = new System.Windows.Forms.Button();
            this.btnRelEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnIntOp
            // 
            this.btnIntOp.Location = new System.Drawing.Point(60, 198);
            this.btnIntOp.Name = "btnIntOp";
            this.btnIntOp.Size = new System.Drawing.Size(147, 50);
            this.btnIntOp.TabIndex = 0;
            this.btnIntOp.Text = "Exemplo Interop Excel";
            this.btnIntOp.UseVisualStyleBackColor = true;
            this.btnIntOp.Click += new System.EventHandler(this.btnIntOp_Click);
            // 
            // btnRelEmp
            // 
            this.btnRelEmp.Location = new System.Drawing.Point(412, 51);
            this.btnRelEmp.Name = "btnRelEmp";
            this.btnRelEmp.Size = new System.Drawing.Size(143, 79);
            this.btnRelEmp.TabIndex = 1;
            this.btnRelEmp.Text = "Relatório Empréstimo";
            this.btnRelEmp.UseVisualStyleBackColor = true;
            this.btnRelEmp.Click += new System.EventHandler(this.btnRelEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empréstimo: ";
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmprestimo.Location = new System.Drawing.Point(173, 24);
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(100, 34);
            this.txtEmprestimo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Início: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fim:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(173, 75);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(175, 34);
            this.dtpInicio.TabIndex = 6;
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(173, 127);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(175, 34);
            this.dtpFim.TabIndex = 7;
            // 
            // frmRelEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 281);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmprestimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelEmp);
            this.Controls.Add(this.btnIntOp);
            this.Name = "frmRelEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelEmprestimo";
            this.Load += new System.EventHandler(this.frmRelEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIntOp;
        private System.Windows.Forms.Button btnRelEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
    }
}