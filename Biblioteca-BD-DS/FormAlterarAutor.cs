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
    public partial class FormAlterarAutor : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";
        
        public FormAlterarAutor()
        {
            InitializeComponent();
            lstAlterarAutor.View = View.Details;
            lstAlterarAutor.LabelEdit = true; 
            lstAlterarAutor.AllowColumnReorder = true;  
            lstAlterarAutor.FullRowSelect = true; 
            lstAlterarAutor.GridLines = true; 
            lstAlterarAutor.Columns.Add("ID", 30, HorizontalAlignment.Left); 
            lstAlterarAutor.Columns.Add("Autor", 200, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_autor order by ds_NomeAutor";
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                lstAlterarAutor.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                     };
                    var linha_listview = new ListViewItem(row);
                    lstAlterarAutor.Items.Add(linha_listview);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Conexao = new MySqlConnection(data_source);
                string sql2 = "UPDATE `tb_autor` SET `ds_NomeAutor` = '" + txtNomeAutorAtt.Text + "' WHERE id_autor = " +txtIdAutor.Text; 
                MySqlCommand comando2 = new MySqlCommand(sql2, Conexao);
                Conexao.Open();
                comando2.ExecuteReader();

                MessageBox.Show("Alterado com Sucesso !!");

                Conexao.Close();
                txtNomeAutorAtt.Text = "";                
                txtIdAutor.Text = "";
                txtIdAutor.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void txtPesquisarAutor_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
