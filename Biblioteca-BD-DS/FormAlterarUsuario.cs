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
    public partial class FormAlterarUsuario : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "server=localhost; database=bd_biblioteca; user id=root; port=3306;";

        public FormAlterarUsuario()
        {
            InitializeComponent();
            lstAlterar.View = View.Details;
            lstAlterar.LabelEdit = true;
            lstAlterar.AllowColumnReorder = true;
            lstAlterar.FullRowSelect = true;
            lstAlterar.GridLines = true;
            lstAlterar.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstAlterar.Columns.Add("Tipo de usuário", 30, HorizontalAlignment.Left);
            lstAlterar.Columns.Add("Senha", 100, HorizontalAlignment.Left);
            lstAlterar.Columns.Add("RM", 50, HorizontalAlignment.Left);
            lstAlterar.Columns.Add("Nome", 200, HorizontalAlignment.Left);

            try
            {
                Conexao = new MySqlConnection(data_source);
                string sql = "Select * from tb_usuarios order by ds_Nome";
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
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
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
            if (cbTipoUsuario.Text == "Funcionário")
            {
                cbTipoUsuario.ValueMember = "F";
            }
            if (cbTipoUsuario.Text == "Aluno")
            {
                cbTipoUsuario.ValueMember = "L";
            }
            if (cbTipoUsuario.Text == "Administrador")
            {
                cbTipoUsuario.ValueMember = "A";
            }

            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text) || string.IsNullOrWhiteSpace(txtRM.Text) || string.IsNullOrWhiteSpace(txtSenhaUsuario.Text) || string.IsNullOrWhiteSpace(cbTipoUsuario.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                Conexao = new MySqlConnection(data_source);
                string sql3 = "select * from tb_usuarios where nr_RM_RA = " +txtRM.Text;
                MySqlCommand comando3 = new MySqlCommand(sql3, Conexao);
                Conexao.Open();
                
                MySqlDataReader reader = comando3.ExecuteReader();



                if (reader.Read() == false)
                {
                    try
                    {

                        Conexao = new MySqlConnection(data_source);
                        string sql2 = "UPDATE tb_usuarios SET ds_TipoUsuario = '" + cbTipoUsuario.ValueMember + "', ds_senha = '" + txtSenhaUsuario.Text + "', nr_RM_RA = '" + txtRM.Text + "', ds_nome = '" + txtNomeUsuario.Text + "' WHERE id_Usuario = " + txtId.Text;
                        MySqlCommand comando2 = new MySqlCommand(sql2, Conexao);
                        Conexao.Open();
                        comando2.ExecuteReader();

                        MessageBox.Show("Alterado com Sucesso !!");

                        Conexao.Close();
                        txtRM.Text = "";
                        txtId.Text = "";
                        cbTipoUsuario.Text = "";
                        txtSenhaUsuario.Text = "";
                        txtNomeUsuario.Text = "";
                        txtId.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                else
                {
                    MessageBox.Show("Este RM já está cadastrado!");
                }
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string busca = "'%" + txtPesquisar.Text + "%'";
                Conexao = new MySqlConnection(data_source);

                string sql = "Select * from tb_usuarios WHERE ds_Nome LIKE " + busca + " order by ds_Nome";

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormAlterarUsuario_Load(object sender, EventArgs e)
        {
            cbTipoUsuario.Items.Add("Aluno");
            cbTipoUsuario.Items.Add("Funcionário");
            cbTipoUsuario.Items.Add("Administrador");
        }
    }
}
