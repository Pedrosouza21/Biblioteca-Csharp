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
    public partial class FormAlterarGenero : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";

        public FormAlterarGenero()
        {
            InitializeComponent();
            lstAlterar.View = View.Details;
            lstAlterar.LabelEdit = true;
            lstAlterar.AllowColumnReorder = true;
            lstAlterar.FullRowSelect = true;
            lstAlterar.GridLines = true;
            lstAlterar.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstAlterar.Columns.Add("Gênero", 200, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_genero order by ds_genero";
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

        private void FormAlterarGenero_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Conexao = new MySqlConnection(data_source);
                string sql2 = "UPDATE `tb_genero` SET `ds_genero` = '" + txtNomeAtt.Text + "' WHERE id_genero = " + txtId.Text;
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

                string sql = "Select * from tb_genero WHERE ds_Genero LIKE " + busca + " order by ds_Genero";

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
    }
}
