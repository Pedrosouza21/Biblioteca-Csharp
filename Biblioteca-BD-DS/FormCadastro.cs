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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            cbTipoUsuario.Items.Add("Aluno");
            cbTipoUsuario.Items.Add("Funcionário");
            cbTipoUsuario.Items.Add("Administrador");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtRM.Text) || string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(cbTipoUsuario.Text))
            {

                MessageBox.Show(" Preencha todas as informações!");
            }
            else
            {
                if(cbTipoUsuario.Text == "Funcionário")
                {
                    cbTipoUsuario.ValueMember = "F";
                }
                if(cbTipoUsuario.Text == "Aluno")
                {
                    cbTipoUsuario.ValueMember = "L";
                }
                if(cbTipoUsuario.Text == "Administrador")
                {
                    cbTipoUsuario.ValueMember = "A";
                }
                txtNome.Focus();
                try
                {
                    MySqlConnection conexao = new MySqlConnection();
                    conexao.ConnectionString = "server = localhost; database = bd_biblioteca; user id = root; port = 3306";
                    //conexao.ConnectionString = "server = localhost; database = bd_biblioteca; user id = root; password = root; port = 3306";
                    string sql = "insert into tb_usuarios (`id_Usuario`, `ds_TipoUsuario`,`ds_senha`,`nr_RM_RA`,`ds_Nome`) values (default, '" + cbTipoUsuario.ValueMember + "', '" + txtSenha.Text + "', '" + txtRM.Text + "', '" + txtNome.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Usuário cadastrado!");
                    conexao.Close();
                    txtNome.Text = "";
                    txtRM.Text = "";
                    txtSenha.Text = "";
                    
                    txtNome.Focus();
                }
                catch
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
