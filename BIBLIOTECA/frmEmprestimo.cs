using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        void limpaCamposEmp()
        {
                lblEmpID.Text = "-1";
                txtClienteID.Text = "";
                dtpData.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
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
           CAMADAS.BLL.Clientes bllCli = new CAMADAS.BLL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCli.Select(); 

            habilitaControlesEmprestimo(false); 
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
    }
}
