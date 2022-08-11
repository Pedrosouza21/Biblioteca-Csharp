using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca_BD_DS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cadastrarLivroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormIni frmLivros = new FormIni();
            frmLivros.Show();
        }

        private void cadastrarAutorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 frmAutor = new Form2();
            frmAutor.Show();
        }

        private void cadastrarExemplaresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                    }

        private void cadastrarGêneroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form6 frmGenero = new Form6();
            frmGenero.Show();
        }

        private void cadastrarEditoraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 frmEditora = new Form4();
            frmEditora.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormCadastro frmCadastro = new FormCadastro();
            frmCadastro.Show();
        }

        private void consultaTabelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaGeral frmConsulta = new FormConsultaGeral();
            frmConsulta.Show();
        }

        private void fazerEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpréstimo frmEmpr = new FormEmpréstimo();
            frmEmpr.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterarAutor frmAltAutor = new FormAlterarAutor();
            frmAltAutor.Show();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterarEditora frmAltEditora = new FormAlterarEditora();
            frmAltEditora.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterarUsuario frmAltUser = new FormAlterarUsuario();
            frmAltUser.Show();
        }

        private void genêroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterarGenero frmAltGenero = new FormAlterarGenero();
            frmAltGenero.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterarLivro frmAltLivro = new FormAlterarLivro();
            frmAltLivro.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devolverLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDevolução frmDevol = new FormDevolução();
            frmDevol.Show();
        }
    }
}
