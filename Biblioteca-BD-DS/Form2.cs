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
    public partial class Form2 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";
        int? id_componente_selecionado = null;

        public Form2()
        {
            InitializeComponent();
            lstAutor.Clear();
            lstAutor.View = View.Details;
            lstAutor.LabelEdit = true;
            lstAutor.AllowColumnReorder = true;
            lstAutor.FullRowSelect = true;
            lstAutor.GridLines = true;
            lstAutor.Columns.Add("Id", 30, HorizontalAlignment.Left);
            lstAutor.Columns.Add("Autor", 100, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_autor order by ds_NomeAutor";
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                lstAutor.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                     };
                    var linha_listview = new ListViewItem(row);
                    lstAutor.Items.Add(linha_listview);
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

            String getValor()
            {
                String valor;

                valor = txtNomeAutor.Text;


                return valor;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeAutor.Text))
            {
                MessageBox.Show("Preencha o campo necessário!");

            }
            else
            {
                txtNomeAutor.Focus();
                try
                {
                    MySqlConnection conexao = new MySqlConnection();
                    conexao.ConnectionString = "server = localhost; database = bd_biblioteca; user id = root; port = 3306";
                    //conexao.ConnectionString = "server = localhost; database = bd_biblioteca; user id = root; password = root; port = 3306";
                    string sql = "insert into tb_autor (id_autor, ds_nomeautor) values (default, '" + txtNomeAutor.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Autor cadastrado!");
                    conexao.Close();
                    txtNomeAutor.Text = "";
                    txtNomeAutor.Focus();
                }
                catch
                {
                    MessageBox.Show("Erro no cadastro");
                }
              }
            }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
            

        private void lstAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstAutor.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                
                id_componente_selecionado = Convert.ToInt32(item.SubItems[0].Text);                
                txtNomeAutor.Text = item.SubItems[1].Text;

            }
        }
    }
}
