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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show("Preencha o campo necessário!");
            }
            else
            {
                txtGenero.Focus();
                try
                {
                    MySqlConnection conexao = new MySqlConnection();
                    conexao.ConnectionString = "server = localhost; database = bd_biblioteca; user id = root; port = 3306";
                    string sql = "insert into tb_genero (id_genero, ds_genero) values (default, '" + txtGenero.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Gênero cadastrado!");
                    conexao.Close();
                    txtGenero.Text = "";
                    txtGenero.Focus();
                }
                catch
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
