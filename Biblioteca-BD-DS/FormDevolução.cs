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
    public partial class FormDevolução : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";
        public FormDevolução()
        {
            InitializeComponent();
        }

        private void FormDevolução_Load(object sender, EventArgs e)
        {

            lstDevol.Clear();
            lstDevol.View = View.Details;            
            lstDevol.AllowColumnReorder = true;
            lstDevol.FullRowSelect = true;
            lstDevol.GridLines = true;
            lstDevol.Columns.Add("ID Registro", 35, HorizontalAlignment.Left);
            lstDevol.Columns.Add("Nome do Livro", 100, HorizontalAlignment.Left);
            lstDevol.Columns.Add("Nome Usuário", 100, HorizontalAlignment.Left);
            lstDevol.Columns.Add("Data do Empréstimo", 80, HorizontalAlignment.Left);
            


            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "select EMPREST.id_registro, LIVRO.ds_Nome, USUA.ds_Nome, EMPREST.dt_Emprest from tb_empr_de_livro AS EMPREST LEFT JOIN tb_livros AS LIVRO ON(EMPREST.id_Livro = LIVRO.id_livro) LEFT JOIN tb_usuarios AS USUA ON(EMPREST.id_Usuario = USUA.id_Usuario) where dt_Devol = ''";
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                lstDevol.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        
                     };
                    var linha_listview = new ListViewItem(row);
                    lstDevol.Items.Add(linha_listview);
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

        private void button1_Click(object sender, EventArgs e)
        {
            var dataDevol = DateTime.Now;
           /* TimeSpan data = Convert.ToDateTime(dataDevol) - Convert.ToDateTime(dataInicial);

            int totalDias = data.Days; */
            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql1 = "update tb_empr_de_livro set dt_Devol = '"+ dataDevol.ToString("yyyy-MM-dd") + "' WHERE id_Registro ="+textBox1.Text;
                MySqlCommand comando1 = new MySqlCommand(sql1, Conexao);
                Conexao.Open();
                comando1.ExecuteReader();
                MessageBox.Show("Livro Devolvido!");
                Conexao.Close();
                textBox1.Text = "";
                

            }
            catch
            {
                MessageBox.Show("Erro na devolução");
            }
        }
    }
}
