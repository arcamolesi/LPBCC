using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIBLIOTECA.CAMADAS; 

namespace BIBLIOTECA
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
     

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.nome = txtNome.Text;
            cliente.curso = txtCurso.Text;
            cliente.dias = Convert.ToInt32(txtDias.Text);
            cliente.multa = Convert.ToSingle(txtMulta.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Insert(cliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.id = Convert.ToInt32(txtID.Text); 
            cliente.nome = txtNome.Text;
            cliente.curso = txtCurso.Text;
            cliente.dias = Convert.ToInt32(txtDias.Text);
            cliente.multa = Convert.ToSingle(txtMulta.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Update(cliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtID.Text);
           
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Delete(idCliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }
    }
}
