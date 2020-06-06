
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BIBLIOTECA.RELATORIOS
{
    public partial class frmRelEmprestimo : Form
    {
        public frmRelEmprestimo()
        {
            InitializeComponent();
        }

        private void btnIntOp_Click(object sender, EventArgs e)
        {

            Excel.Application xlApp;
            Excel.Workbook xlPasta;
            Excel.Worksheet xlPlanilha;
            Excel.Range celula;

            object misValue = System.Reflection.Missing.Value;
            //Cria uma planilha temporária na memória do computador
            xlApp = new Excel.Application();
            xlPasta = xlApp.Workbooks.Add(misValue);
            xlPlanilha = (Excel.Worksheet)xlPasta.Worksheets.get_Item(1);

            xlApp.Columns.AutoFit();

            //celulas = xlApp.get_Range("A1", "D1");
            //celulas.Font.Bold = true; 
            //celulas.Font.Color = 
            //celulas.NumberFormat = "dd/mm/aaaa";
            //celulas = xlApp.get_Range("D2", "D3");
            //celulas.NumberFormat = "0,00%";

            //Creating a new style with cell back color, fill pattern and font attribute


            celula = xlApp.get_Range("A1", "A1");
            celula.Font.Size = 20;
            celula.Font.Italic = true;
            celula.Font.Name = "Arial";

            //incluindo dados
            xlPlanilha.Cells[1, 1] = "Dados do cliente:";

            celula = xlApp.get_Range("A2", "A2");
            celula.Font.Size = 15;
            celula.Font.Italic = true;
            celula.Font.Name = "Times";
            xlPlanilha.Cells[1, 2] = 10;


            celula = xlApp.get_Range("A3", "A3");
            celula.Font.Size = 20;
            celula.Font.Italic = true;
            celula.Font.Name = "Arial";
            celula.NumberFormat = "DD/MM/YYYY";
            xlPlanilha.Cells[1, 3] = DateTime.Now;
            xlPlanilha.Cells[1, 4] = 15.67;

            //Salva o arquivo de acordo com a documentação do Excel.
            xlPasta.SaveAs("arquivo.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlPasta.Close(true, misValue, misValue);
            xlApp.Quit();

            //o arquivo foi salvo na pasta Meus Documentos.
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            MessageBox.Show("Concluído. Verifique em " + caminho + "arquivo.xls");

        }

        private void btnRelEmp_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Itens bllItem = new CAMADAS.BLL.Itens();
            List<CAMADAS.MODEL.Itens> lstItens = new List<CAMADAS.MODEL.Itens>();
            lstItens = bllItem.Select();

            lstItens = lstItens.OrderBy(d => d.entrega).ToList();

            if (txtEmprestimo.Text != "")
                lstItens = lstItens.Where(emp => emp.emprestimoID == Convert.ToInt32(txtEmprestimo.Text)).OrderBy(d => d.entrega).ToList();
            if(dtpFim.Value!=Convert.ToDateTime("1/1/1800"))
                lstItens = lstItens.Where(dt => dt.entrega>=dtpInicio.Value && dt.entrega<= dtpFim.Value).OrderBy(d => d.entrega).ToList();

            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelItens_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".xlsx";

            FileInfo caminhoNomeArquivo = new FileInfo(arquivo);
            ExcelPackage arquivoExcel = new ExcelPackage(caminhoNomeArquivo);
            ExcelWorksheet planilha = arquivoExcel.Workbook.Worksheets.Add("Plan1");

            int col = 1;
            int lin = 1;
            //cabeçalho
            planilha.Cells[lin, col].Value = "ID";
            planilha.Cells[lin, ++col].Value = "EMPRÉSTIMO";
            planilha.Cells[lin, ++col].Value = "LIVRO";
            planilha.Cells[lin, ++col].Value = "ENTREGA";

            //dados, corpo da planilha
            if (lstItens.Count > 0)
                foreach (CAMADAS.MODEL.Itens item in lstItens)
                {
                    col = 1;
                    planilha.Cells[++lin, col].Value = item.id;
                    planilha.Cells[lin, ++col].Value = item.emprestimoID;
                    planilha.Cells[lin, ++col].Value = item.livro;
                    planilha.Cells[lin, ++col].Value = item.entrega;
                    planilha.Cells[lin, col].Style.Numberformat.Format = "dd-MM-yyyy";
                }

            ExcelRange rng;

            using (rng = planilha.Cells["A1:D1"])
            {
                rng.Style.Font.Size = 15;
                rng.Style.Font.Name = "Arial";
                rng.Style.Font.Bold = true;
                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                rng.Style.Fill.BackgroundColor.SetColor(Color.Gray);
                rng.Style.Font.Color.SetColor(Color.White);

            }

            using (rng = planilha.Cells["A2:D" + lin.ToString()])
            {
                rng.Style.Font.Size = 13;
                rng.Style.Font.Bold = false;
                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                rng.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                rng.Style.Font.Color.SetColor(Color.Black);
            }

            planilha.Cells.AutoFitColumns();
            planilha.Cells[++lin, 1].Value = "Gerado em " + DateTime.Now.ToString();

            //gravação e saída
            arquivoExcel.Save();
            arquivoExcel.Dispose();

            System.Diagnostics.Process.Start(arquivo);
        }

        private void frmRelEmprestimo_Load(object sender, EventArgs e)
        {
            //dtpFim.Value = Convert.ToDateTime("1/1/1800");
            dtpInicio.Value = Convert.ToDateTime("1/1/1800");
        }
    }
}
