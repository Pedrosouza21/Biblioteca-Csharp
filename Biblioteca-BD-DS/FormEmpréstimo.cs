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
    public partial class FormEmpréstimo : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306; convert zero datetime=True;";
        //private string data_source = "server=localhost; database=bd_biblioteca; user id=root; password = root ; port=3306;";
        private int? id_livro;
        private int? id_usuario;
        private DateTime confirmDevol;
        
        public FormEmpréstimo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataEmprest;

            dataEmprest = dtEmprestimo.Value;
             



            Conexao = new MySqlConnection(data_source);
                string sql11 = "Select dt_Devol from tb_empr_de_livro WHERE id_Usuario = '" + id_usuario + "'";
                Conexao.Open();
                MySqlCommand comando11 = new MySqlCommand(sql11, Conexao);
                MySqlDataReader reader11 = comando11.ExecuteReader();

                while (reader11.Read())
                {
                    confirmDevol = reader11.GetDateTime(reader11.GetOrdinal("dt_Devol"))    ;

            }
                Conexao.Close();

           

            if (string.IsNullOrWhiteSpace(cbLivro.Text) || string.IsNullOrWhiteSpace(cbUsuario.Text))
                {

                    MessageBox.Show("Preencha todas as informações!");
                }               

                else if(confirmDevol != null)
            {
                    

                    try
                    {
                        Conexao = new MySqlConnection(data_source);
                        string sql4 = "insert into tb_empr_de_livro (id_Registro, id_Livro, id_Usuario, dt_Emprest, dt_Devol) values(default, '" + id_livro + "', '" + id_usuario + "', '" + dataEmprest.ToString("yyyy-MM-dd") + "', '0' )";
                        MySqlCommand comando4 = new MySqlCommand(sql4, Conexao);
                        Conexao.Open();
                        comando4.ExecuteReader();
                        MessageBox.Show("Livro emprestado!");
                        Conexao.Close();
                        cbUsuario.Text = "";
                        cbLivro.Text = "";

                    }
                    catch
                    {
                        MessageBox.Show("Erro no cadastro");
                    }
                }
            else
            {
                MessageBox.Show("O usuário já está com um livro emprestado");
            }
        }
            
     

        private void FormEmpréstimo_Load(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao;
            comando.CommandText = "Select ds_Nome from tb_livros order by ds_Nome";
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbLivro.DisplayMember = "ds_Nome";
            cbLivro.DataSource = dt;

            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand comando2 = new MySqlCommand();
            comando2.Connection = Conexao;
            comando2.CommandText = "Select ds_Nome from tb_usuarios order by ds_Nome";
            MySqlDataReader dr2 = comando2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            cbUsuario.DisplayMember = "ds_Nome";
            cbUsuario.DataSource = dt2;
            
            Conexao = new MySqlConnection(data_source);
            string busca10 = cbLivro.Text;
            string sql10 = "Select id_livro from tb_livros WHERE ds_Nome = '" + busca10 + "'";
            Conexao.Open();
            MySqlCommand comando10 = new MySqlCommand(sql10, Conexao);
            MySqlDataReader reader10 = comando10.ExecuteReader();
            while (reader10.Read())
            {
                id_livro = reader10.GetInt32(0);

            }

            Conexao = new MySqlConnection(data_source);
            string busca2 = cbUsuario.Text;
            string sql3 = "Select id_Usuario from tb_usuarios WHERE ds_Nome = '" + busca2 + "'";
            Conexao.Open();
            MySqlCommand comando3 = new MySqlCommand(sql3, Conexao);
            MySqlDataReader reader2 = comando3.ExecuteReader();
            while (reader2.Read())
            {
                id_usuario = reader2.GetInt32(0);

            }

        }


    }
}
