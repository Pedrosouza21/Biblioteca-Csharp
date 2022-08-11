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
    public partial class Form5 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtExemplaresDisp.Text) || string.IsNullOrWhiteSpace(txtTotalExemplares.Text))
            {
                MessageBox.Show("Preencha o campo necessário !");
            }
            else
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection();
                    conexao.ConnectionString = "server = localhost; database = bd_biblioteca; user id = root; password = root; port = 3306";
                    string sql = "insert into tb_exemplares (id_Exemplares, qt_Total, qt_Disp) values (default, '" + txtTotalExemplares.Text + "', '" + txtExemplaresDisp.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Quantidade cadastrada!");
                    conexao.Close();
                    txtExemplaresDisp.Text = "";
                    txtTotalExemplares.Text = "";
                    txtTotalExemplares.Focus();
                }
                catch
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand comando2 = new MySqlCommand();
            comando2.Connection = Conexao;
            comando2.CommandText = "Select ds_NomeLivro from tb_livros order by ds_NomeLivro";
            MySqlDataReader dr = comando2.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbLivro.DisplayMember = "ds_NomeLivro";
            cbLivro.DataSource = dt;

        }
    }
}
