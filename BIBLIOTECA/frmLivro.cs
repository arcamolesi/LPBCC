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
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
        }

       

        private void frmLivro_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Livros bllLivros = new CAMADAS.BLL.Livros();
            dtgLivros.DataSource = "";
            dtgLivros.DataSource = bllLivros.Select();
            habilitaControles(false);
            habilitaButtons(true);
        }

        private void habilitaControles(bool status)
        {
            txtTitulo.Enabled = status;
            txtEditora.Enabled = status;
            txtAutor.Enabled = status;
            txtValor.Enabled = status;
            txtSituacao.Enabled = status; 
        }

        private void habilitaButtons(bool status)
        {
            btnInserir.Enabled = status;
            btnEditar.Enabled = status;
            btnRemover.Enabled = status;
            btnGravar.Enabled = !status;
            btnCancelar.Enabled = !status; 
        }

        private void limpaControles()
        {
            lblID.Text = ""; 
            txtTitulo.Text = "";
            txtEditora.Text = "";//string.Empty
            txtAutor.Text = string.Empty; //""
            txtValor.Text = "";
            txtSituacao.Text = ""; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles(); 
            habilitaControles(false);
            habilitaButtons(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Livros bllLivros = new CAMADAS.BLL.Livros(); 
            string msg="";
            string titMsg=""; 
            if (lblID.Text == "-1")
            {
                msg = "Deseja Inserir novo Livro?";
                titMsg = "Inserir"; 
            }
            else
            {
                msg = "Deseja Alterar o Livro atual?";
                titMsg = "Atualizar"; 
            }
            DialogResult resposta = MessageBox.Show(msg, titMsg,MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1); 
            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Livros livro = new CAMADAS.MODEL.Livros();
                livro.id = Convert.ToInt32(lblID.Text);
                livro.titulo = txtTitulo.Text;
                livro.editora = txtEditora.Text;
                livro.autor = txtAutor.Text;
                livro.valor = Convert.ToSingle(txtValor.Text);
                livro.situacao = Convert.ToInt32(txtSituacao.Text);

                if (lblID.Text=="-1")
                    bllLivros.Insert(livro);
                else bllLivros.Update(livro); 

            }

            limpaControles(); 
            habilitaControles(false);
            habilitaButtons(true);
            dtgLivros.DataSource = "";
            dtgLivros.DataSource = bllLivros.Select(); 

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Livros bllLivros = new CAMADAS.BLL.Livros(); 
            string msg = "Não há livros para remover";
            string titBox = "Remover";
            if (lblID.Text != "")
            {
                msg = "Deseja remover o livro: " + txtTitulo.Text;
                DialogResult resposta = MessageBox.Show(msg, titBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblID.Text);
                    bllLivros.Delete(id);
                }
            }
            else MessageBox.Show(msg, titBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            limpaControles();
            dtgLivros.DataSource = "";
            dtgLivros.DataSource = bllLivros.Select(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "")
            {
                habilitaControles(true);
                habilitaButtons(false);
                txtTitulo.Focus();
            }
            else MessageBox.Show("Não há dados para atualizar", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limpaControles();
            habilitaButtons(false);
            habilitaControles(true);         
            lblID.Text = "-1";
            txtTitulo.Focus(); 
        }

        private void dtgLivros_DoubleClick(object sender, EventArgs e)
        {
            lblID.Text = dtgLivros.SelectedRows[0].Cells["id"].Value.ToString();
            txtTitulo.Text = dtgLivros.SelectedRows[0].Cells["titulo"].Value.ToString();
            txtEditora.Text = dtgLivros.SelectedRows[0].Cells["editora"].Value.ToString();
            txtAutor.Text = dtgLivros.SelectedRows[0].Cells["autor"].Value.ToString(); 
            txtValor.Text = dtgLivros.SelectedRows[0].Cells["valor"].Value.ToString();
            txtSituacao.Text = dtgLivros.SelectedRows[0].Cells["situacao"].Value.ToString();
        }

        private void dtgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
