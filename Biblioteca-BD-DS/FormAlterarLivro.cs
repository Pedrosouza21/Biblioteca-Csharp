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
    public partial class FormAlterarLivro : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";
        //private string data_source = "server=localhost; database=bd_biblioteca; user id=root; password = root ; port=3306;";

        public FormAlterarLivro()
        {
            InitializeComponent();
            lstConsulta.View = View.Details;
            lstConsulta.LabelEdit = true;
            lstConsulta.AllowColumnReorder = true;
            lstConsulta.FullRowSelect = true;
            lstConsulta.GridLines = true;
            lstConsulta.Columns.Add("Id", 30, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Tombo", 100, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("ISBN", 100, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Nome do Livro", 100, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Autor", 100, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Ano", 100, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Gênero", 100, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Editora", 100, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Status", 100, HorizontalAlignment.Left);


            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select id_Livro, nr_Tombo, nr_ISBN, ds_Nome, id_Autor, nr_AnoLivro, id_Genero, id_Editora, Status_Livros from tb_livros order by ds_Nome";
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                lstConsulta.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),

                        reader.GetString(8)
                        //reader.GetString(10),

                     };
                    var linha_listview = new ListViewItem(row);
                    lstConsulta.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    


        private void FormAlterarLivro_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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
                    string sql = "UPDATE tb_livros SET nr_ISBN = '" + txtISBN.Text + "', ds_Nome = '" + txtTitulo.Text + "', id_Autor = '" + cbAutor.Text + "', nr_AnoLivro = '" + txtAno.Text + "', id_Genero = '" + cbGenero.Text + "', id_Editora = '" + cbEditora.Text + "', nr_Tombo = '" + txtTombo.Text + "', Status_Livros = '" + cbStatusLivro.Text + "' WHERE id_Livro = " +txtID.Text;
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);
                    Conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Alterado com sucesso!");
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
                    txtID.Focus();
                    txtID.Text = "";
                }
                catch
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string busca = "'%" + txtPesquisar.Text + "%'";
                Conexao = new MySqlConnection(data_source);

                string sql = "Select * from tb_editora WHERE nm_Editora LIKE " + busca + " order by nm_Editora";

                Conexao.Open();
                MySqlCommand comando3 = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando3.ExecuteReader();

                lstConsulta.Items.Clear();

                while (reader.Read())
                {


                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                    };
                    var linha_listview = new ListViewItem(row);
                    lstConsulta.Items.Add(linha_listview);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}