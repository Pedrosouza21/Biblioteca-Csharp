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
    public partial class FormConsultaGeral : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";
        //private string data_source = "server=localhost; database=bd_biblioteca; user id=root; password = root; port=3306;";
        public FormConsultaGeral()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lstConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnAutor_CheckedChanged(object sender, EventArgs e)
        {
            lstConsulta.Clear();
            lstConsulta.View = View.Details;
            lstConsulta.LabelEdit = true;
            lstConsulta.AllowColumnReorder = true;
            lstConsulta.FullRowSelect = true;
            lstConsulta.GridLines = true;
            lstConsulta.Columns.Add("Id", 30, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Autor", 100, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_autor order by ds_NomeAutor";
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

        private void rdbtnGenero_CheckedChanged(object sender, EventArgs e)
        {
            lstConsulta.Clear();
            lstConsulta.View = View.Details;
            lstConsulta.LabelEdit = true;
            lstConsulta.AllowColumnReorder = true;
            lstConsulta.FullRowSelect = true;
            lstConsulta.GridLines = true;
            lstConsulta.Columns.Add("Id", 30, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Gênero", 100, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_genero order by ds_Genero";
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

        private void rdbtnEditora_CheckedChanged(object sender, EventArgs e)
        {
            lstConsulta.Clear();
            lstConsulta.View = View.Details;
            lstConsulta.LabelEdit = true;
            lstConsulta.AllowColumnReorder = true;
            lstConsulta.FullRowSelect = true;
            lstConsulta.GridLines = true;
            lstConsulta.Columns.Add("Id", 30, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Editora", 100, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_editora order by nm_editora";
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

        private void rdbtnLivros_CheckedChanged(object sender, EventArgs e)
        {
            lstConsulta.Clear();
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
                string sql = "Select Livros.id_Livro, Livros.nr_Tombo, Livros.nr_ISBN, Livros.ds_Nome, AUTOR.ds_NomeAutor, Livros.nr_AnoLivro, GENERO.ds_Genero, EDITORA.nm_Editora, Livros.Status_Livros from tb_livros AS Livros LEFT JOIN tb_autor AS AUTOR ON (Livros.id_Autor = AUTOR.id_autor) LEFT JOIN tb_editora AS EDITORA ON (EDITORA.id_Editora = Livros.id_Editora) LEFT JOIN tb_genero AS GENERO ON (GENERO.id_Genero = Livros.id_Genero) order by Livros.ds_Nome";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lstConsulta.Clear();
            lstConsulta.View = View.Details;
            lstConsulta.LabelEdit = true;
            lstConsulta.AllowColumnReorder = true;
            lstConsulta.FullRowSelect = true;
            lstConsulta.GridLines = true;
            lstConsulta.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Tipo de usuário", 30, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Senha", 100, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("RM", 50, HorizontalAlignment.Left);
            lstConsulta.Columns.Add("Nome", 200, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_usuarios order by ds_Nome";
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
