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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();

            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNomeEditora.Text))
            {
                MessageBox.Show("Preencha o campo necessário");
            }
            else
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection();
                    conexao.ConnectionString = "server = localhost; database = bd_biblioteca; user id = root; port = 3306";
                    //conexao.ConnectionString = "server = localhost; database = bd_biblioteca; user id = root; password = root; port = 3306";
                    string sql = "insert into tb_editora (id_Editora, nm_Editora) values (default, '" + txtNomeEditora.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Editora cadastrada!");
                    conexao.Close();
                    txtNomeEditora.Text = "";
                    txtNomeEditora.Focus();
                }
                catch
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }

        }

        private void lst_editora_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
