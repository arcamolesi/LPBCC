using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIBLIOTECA.CAMADAS;

namespace BIBLIOTECA
{
    public partial class frmEmprestimo : Form
    {
        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void habilitaControlesEmprestimo(bool status)
        {
            txtClienteID.Enabled = status;
            cmbCliente.Enabled = status;
            dtpData.Enabled = status;
            btnCancelarEmp.Enabled = status;
            btnGravarEmp.Enabled = status;
            btnNovoEmp.Enabled = !status;
            btnEditarEmp.Enabled = !status;
            btnRemoverEmp.Enabled = !status; 
        }

        private void habilitaControlesItens(bool status)
        {
            txtLivro.Enabled = status;
            cmbLivro.Enabled = status;
            dtpEntrega.Enabled = false;
           // btnItemNovo.Enabled = !status;
            //btnItemDevolver.Enabled = status;
            btnItemCancelar.Enabled = status;
            btnItemGravar.Enabled = status; 
        }

        private void limpaCamposEmp()
        {
            lblEmpID.Text = "-1";
            txtClienteID.Text = "";
            dtpData.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            btnItemNovo.Enabled = false; 
        }

        private void limpaCamposItens()
        {
            lblItemEmp.Text = "-1";
            txtLivro.Text = "";
            dtpEntrega.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelarEmp_Click(object sender, EventArgs e)
        {
            limpaCamposEmp(); 
            habilitaControlesEmprestimo(false);
        }

        private void btnGravarEmp_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Emprestimo emprestimo = new CAMADAS.MODEL.Emprestimo();
            emprestimo.id = Convert.ToInt32(lblEmpID.Text);
            emprestimo.clienteId = Convert.ToInt32(txtClienteID.Text);
            emprestimo.data = dtpData.Value;

            CAMADAS.BLL.Emprestimo bllEmp = new CAMADAS.BLL.Emprestimo();
            if (lblEmpID.Text == "-1")
                bllEmp.Insert(emprestimo);
            else bllEmp.Update(emprestimo);

            dgvEmprestimo.DataSource = bllEmp.Select(); 

            habilitaControlesEmprestimo(false); 
        }

        private void btnNovoEmp_Click(object sender, EventArgs e)
        {
            habilitaControlesEmprestimo(true);
            limpaCamposEmp();
            cmbCliente.Focus(); 
        }

        private void btnEditarEmp_Click(object sender, EventArgs e)
        {
            habilitaControlesEmprestimo(true); 
        }

        private void btnRemoverEmp_Click(object sender, EventArgs e)
        {

        }

        private void frmEmprestimo_Load(object sender, EventArgs e)
        {
            //programação para empréstimo
           CAMADAS.BLL.Clientes bllCli = new CAMADAS.BLL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCli.Select();

            CAMADAS.BLL.Emprestimo bllEmp = new CAMADAS.BLL.Emprestimo();
            dgvEmprestimo.DataSource = "";
            dgvEmprestimo.DataSource = bllEmp.Select();
            this.dgvEmprestimo.DefaultCellStyle.Font = new Font("Times", 12);

            habilitaControlesEmprestimo(false);
            limpaCamposEmp();

            ////programação para itens
            CAMADAS.BLL.Livros bllLivro = new CAMADAS.BLL.Livros();
            CAMADAS.BLL.Itens bllItens = new CAMADAS.BLL.Itens(); 
            cmbLivro.DisplayMember = "titulo";
            cmbLivro.ValueMember = "id";
            cmbLivro.DataSource = bllLivro.Select();

            limpaCamposItens();
            habilitaControlesItens(false);

            dgvItens.DataSource = bllItens.Select();
            this.dgvItens.DefaultCellStyle.Font = new Font("Times", 12);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClienteID.Text = cmbCliente.SelectedValue.ToString();    
        }

        private void txtClienteID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtClienteID.Text != "")
                    cmbCliente.SelectedValue = Convert.ToInt32(txtClienteID.Text);
            }
            catch
            {
                MessageBox.Show("Cliente Invalido");
                cmbCliente.Focus(); 
            }

            
        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            cmbCliente_SelectedIndexChanged(null, null); 
        }

        private void dgvEmprestimo_DoubleClick(object sender, EventArgs e)
        {
            lblEmpID.Text = dgvEmprestimo.SelectedRows[0].Cells["id"].Value.ToString();
            cmbCliente.SelectedValue = Convert.ToInt32(dgvEmprestimo.SelectedRows[0].Cells["clienteId"].Value.ToString());
            txtClienteID.Text = dgvEmprestimo.SelectedRows[0].Cells["clienteId"].Value.ToString();
            dtpData.Value = Convert.ToDateTime(dgvEmprestimo.SelectedRows[0].Cells["data"].Value.ToString());
            btnItemNovo.Enabled = true;

            CAMADAS.BLL.Itens bllItem = new CAMADAS.BLL.Itens();
            dgvItens.DataSource = bllItem.SelectByEmp(Convert.ToInt32(lblEmpID.Text)); 
        }

       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmprestimo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnItemNovo_Click(object sender, EventArgs e)
        {
            limpaCamposItens();
            habilitaControlesItens(true);
            dtpEntrega.Value = Convert.ToDateTime("01/01/1900"); 
            cmbLivro.Focus(); 
        }

        private void cmbLivro_Leave(object sender, EventArgs e)
        {

            try
            {
                cmbLivro_SelectedIndexChanged(null, null);
                verificaLivro();
            }
            catch
            {
                MessageBox.Show("Por favor informe um livro...");
                cmbLivro.Focus();
            }
            
            
        }

        private void verificaLivro()
        {
            
            int idLivro = Convert.ToInt32(txtLivro.Text);
            CAMADAS.BLL.Livros bllLivro = new CAMADAS.BLL.Livros();
            List<CAMADAS.MODEL.Livros> lstLivro = bllLivro.SelectByID(idLivro);
            if (lstLivro.Count > 0)
            {
                CAMADAS.MODEL.Livros livro = lstLivro[0]; 
                if (livro.situacao == 2)
                {
                    MessageBox.Show("Livro " + livro.titulo.Trim() + " já esta emprestado!!!");
                    cmbLivro.Focus(); 
                }
            }
            else
            {
                MessageBox.Show("Livro não encontrado"); 
                cmbLivro.Focus();
            }


        }

        private void cmbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLivro.Text = cmbLivro.SelectedValue.ToString();
            
        }

        private void txtLivro_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbLivro.SelectedValue = Convert.ToInt32(txtLivro.Text);
                verificaLivro();
            }
            catch
            {
                cmbLivro.Focus();
            }
            
           
        }

        private void txtLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnItemCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnItemGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Itens item = new CAMADAS.MODEL.Itens();
            item.id = Convert.ToInt32(lblItemEmp.Text);
            item.emprestimoID = Convert.ToInt32(lblEmpID.Text);
            item.livroID = Convert.ToInt32(txtLivro.Text);
            item.entrega = Convert.ToDateTime("01/01/1900");

            CAMADAS.BLL.Itens bllItens = new CAMADAS.BLL.Itens();
            if (lblItemEmp.Text == "-1")
                bllItens.Insert(item);

            dgvItens.DataSource = bllItens.SelectByEmp(Convert.ToInt32(lblEmpID.Text));

        }

        private void btnItemDevolver_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Itens item = new CAMADAS.MODEL.Itens();
            item.id = Convert.ToInt32(lblItemEmp.Text);
            item.emprestimoID = Convert.ToInt32(lblEmpID.Text);
            item.livroID = Convert.ToInt32(txtLivro.Text);
            
           

            CAMADAS.BLL.Itens bllItens = new CAMADAS.BLL.Itens();
            if (lblItemEmp.Text != "-1")
                bllItens.Devolver(item);

            dgvItens.DataSource = bllItens.SelectByEmp(Convert.ToInt32(lblEmpID.Text));


        }

        private void dgvItens_DoubleClick(object sender, EventArgs e)
        {
            if (lblEmpID.Text != "-1")
            {
                lblItemEmp.Text = dgvItens.SelectedRows[0].Cells["idItem"].Value.ToString();
                cmbLivro.SelectedValue = dgvItens.SelectedRows[0].Cells["livroItemID"].Value;
                txtLivro.Text = dgvItens.SelectedRows[0].Cells["livroItemID"].Value.ToString();
                dtpEntrega.Value = Convert.ToDateTime(dgvItens.SelectedRows[0].Cells["entrega"].Value.ToString());
                btnItemDevolver.Enabled = (dtpEntrega.Value == Convert.ToDateTime("1/1/1900")) ? true : false;
            }
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
