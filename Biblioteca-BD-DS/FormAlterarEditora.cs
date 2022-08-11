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
    public partial class FormAlterarEditora : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";

        public FormAlterarEditora()
        {
            InitializeComponent();
            lstAlterar.View = View.Details;
            lstAlterar.LabelEdit = true;
            lstAlterar.AllowColumnReorder = true;
            lstAlterar.FullRowSelect = true;
            lstAlterar.GridLines = true;
            lstAlterar.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstAlterar.Columns.Add("Editora", 200, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_editora order by nm_editora";
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                lstAlterar.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                     };
                    var linha_listview = new ListViewItem(row);
                    lstAlterar.Items.Add(linha_listview);
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

            try
            {

                Conexao = new MySqlConnection(data_source);
                string sql2 = "UPDATE `tb_editora` SET `nm_Editora` = '" + txtNomeAtt.Text + "' WHERE id_editora = " + txtId.Text;
                MySqlCommand comando2 = new MySqlCommand(sql2, Conexao);
                Conexao.Open();
                comando2.ExecuteReader();

                MessageBox.Show("Alterado com Sucesso !!");

                Conexao.Close();
                txtNomeAtt.Text = "";
                txtId.Text = "";
                txtId.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

                lstAlterar.Items.Clear();

                while (reader.Read())
                {


                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                    };
                    var linha_listview = new ListViewItem(row);
                    lstAlterar.Items.Add(linha_listview);

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

        private void FormAlterarEditora_Load(object sender, EventArgs e)
        {

        }
    }
    }

