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
    public partial class FormIni : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";
        //private string data_source = "server=localhost; database=bd_biblioteca; user id=root; password = root ; port=3306;";
        private int? id_autor;
        private int? id_editora;
        private int? id_genero;
        private int? id_livro;

        public FormIni()
        {
            InitializeComponent();



        }
        private void button1_Click_1(object sender, EventArgs e)
        {

                if (string.IsNullOrWhiteSpace(txtQuantidade.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(cbGenero.Text) || string.IsNullOrWhiteSpace(cbEditora.Text) || string.IsNullOrWhiteSpace(cbAutor.Text) || string.IsNullOrWhiteSpace(txtISBN.Text) || string.IsNullOrWhiteSpace(txtTombo.Text) || string.IsNullOrWhiteSpace(txtAno.Text) || string.IsNullOrWhiteSpace(cbStatusLivro.Text))
                {

                    MessageBox.Show(" Preencha todas as informações!");
                }
                else
                {
                    txtTitulo.Focus();
                    try
                    {

                    Conexao = new MySqlConnection(data_source);
                    string busca = cbAutor.Text;
                    string sql5 = "Select id_autor from tb_autor WHERE ds_NomeAutor = '" + busca + "'";
                    Conexao.Open();
                    MySqlCommand comando5 = new MySqlCommand(sql5, Conexao);
                    MySqlDataReader reader = comando5.ExecuteReader();
                    while (reader.Read())
                    {
                        id_autor = reader.GetInt32(0);

                    }
                    

                    Conexao = new MySqlConnection(data_source);
                    string busca2 = cbEditora.Text;
                    string sql6 = "Select id_editora from tb_editora WHERE nm_Editora = '" + busca2 + "'";
                    Conexao.Open();
                    MySqlCommand comando6 = new MySqlCommand(sql6, Conexao);
                    MySqlDataReader reader2 = comando6.ExecuteReader();
                    while (reader2.Read())
                    {
                        id_editora = reader2.GetInt32(0);

                    }
                    

                    Conexao = new MySqlConnection(data_source);
                    string busca3 = cbGenero.Text;
                    string sql7 = "Select id_genero from tb_genero WHERE ds_Genero = '" + busca3 + "'";
                    Conexao.Open();
                    MySqlCommand comando7 = new MySqlCommand(sql5, Conexao);
                    MySqlDataReader reader3 = comando7.ExecuteReader();
                    while (reader3.Read())
                    {
                        id_genero = reader3.GetInt32(0);

                    }

                        Conexao = new MySqlConnection(data_source);
                        string sql9 = "SELECT id_Livro FROM tb_livros ORDER BY Id_Livro DESC LIMIT 1";
                        MySqlCommand comando9 = new MySqlCommand(sql9, Conexao);
                        Conexao.Open();
                        MySqlDataReader reader4 = comando9.ExecuteReader();
                        while (reader4.Read())
                        {
                            id_livro = reader4.GetInt32(0);

                        }

                    Conexao = new MySqlConnection(data_source);
                        string sql8 = "insert into tb_exemplares (id_Exemplares, id_Livro, qt_Total, qt_Disp) values (default, '" + id_livro + "', '" + txtQuantidade.Text + "', '" + txtQuantidade.Text + "')";
                        MySqlCommand comando8 = new MySqlCommand(sql8, Conexao);
                        Conexao.Open();
                        comando8.ExecuteReader();



                        Conexao = new MySqlConnection(data_source);
                        string sql = "insert into tb_livros (id_Livro, nr_ISBN, ds_Nome, id_Autor, nr_AnoLivro, id_Genero, id_Editora, nr_Tombo, Status_Livros) values (default, '" + txtISBN.Text + "', '" + txtTitulo.Text + "', '" + id_autor + "', '" + txtAno.Text + "', '" + id_genero + "', '" + id_editora + "', '" + txtTombo.Text + "', '" + cbStatusLivro.Text + "')";
                        MySqlCommand comando = new MySqlCommand(sql, Conexao);
                        Conexao.Open();
                        comando.ExecuteReader();
                        MessageBox.Show("Livro cadastrado!");
                        Conexao.Close();
                        txtAno.Text = "";
                        cbAutor.Text = "";
                        cbEditora.Text = "";
                        cbGenero.Text = "";
                        txtQuantidade.Text = "";
                        txtTitulo.Text = "";
                        txtISBN.Text = "";
                        txtTombo.Text = "";
                        cbStatusLivro.Text = "";
                        txtTitulo.Focus();

                        
                    }
                    catch
                    {
                        MessageBox.Show("Erro no cadastro");
                    }

                
            }
            
         }
    
    
        private void txtISBN_TextChanged(object sender, EventArgs e)
            {

            }

            private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void FormIni_Load(object sender, EventArgs e)
            {
                cbStatusLivro.Items.Add("D");
                cbStatusLivro.Items.Add("I");
                cbStatusLivro.Items.Add("B");

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand comando2 = new MySqlCommand();
                comando2.Connection = Conexao;
                comando2.CommandText = "Select ds_NomeAutor from tb_autor order by ds_NomeAutor";
                MySqlDataReader dr = comando2.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbAutor.DisplayMember = "ds_NomeAutor";
                cbAutor.DataSource = dt;




                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand comando3 = new MySqlCommand();
                comando3.Connection = Conexao;
                comando3.CommandText = "Select nm_editora from tb_editora order by nm_editora";
                MySqlDataReader dr1 = comando3.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                cbEditora.DisplayMember = "nm_editora";
                cbEditora.DataSource = dt1;


                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand comando4 = new MySqlCommand();
                comando4.Connection = Conexao;
                comando4.CommandText = "Select ds_genero from tb_genero order by ds_genero";
                MySqlDataReader dr2 = comando4.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);
                cbGenero.DisplayMember = "ds_genero";
                cbGenero.DataSource = dt2;



            }

            private void cbAutor_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }
