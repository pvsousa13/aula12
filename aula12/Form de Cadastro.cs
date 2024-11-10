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


namespace aula12
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Windows.Forms;
    public partial class Form_de_Cadastro : Form
    {
        private int? productId = null;
        Database db = new Database();
        public Form_de_Cadastro()
        {
            InitializeComponent();
        }
        public Form_de_Cadastro(int id, string nome, decimal preco)
        {
            InitializeComponent();
            productId = id;
            txtNome.Text = nome;
            txtPreço.Text = preco.ToString();
        }

        private void Form_de_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal preco = Convert.ToDecimal(txtPreço.Text);

            db.OpenConnection();
            string query;

            if (productId == null) // Inserção
            {
                query = "INSERT INTO Produto (Nome, Preco) VALUES (@nome, @preco)";
            }
            else // Atualização
            {
                query = "UPDATE Produto SET Nome = @nome, Preco = @preco WHERE Id = @id";
            }

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@preco", preco);

            if (productId != null)
            {
                cmd.Parameters.AddWithValue("@id", productId);
            }

            cmd.ExecuteNonQuery();
            db.CloseConnection();
            DialogResult = DialogResult.OK; // Fecha o formulário
        }
    }
}
    

