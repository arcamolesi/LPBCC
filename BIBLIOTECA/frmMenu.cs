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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void manterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = new frmClientes();
            frmCli.MdiParent = this; 
            frmCli.Show(); 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivro frmLiv = new frmLivro();
            frmLiv.MdiParent = this;
            frmLiv.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSob = new frmSobre();
            frmSob.ShowDialog(); 
        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmprestimo frmEmp = new frmEmprestimo();
            frmEmp.MdiParent = this;
            frmEmp.Show(); 
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelGerais.relLivros(); 
        }

        private void emprestimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RELATORIOS.frmRelEmprestimo frmREmp = new RELATORIOS.frmRelEmprestimo();
            frmREmp.MdiParent = this;
            frmREmp.Show(); 
        }
    }
}
