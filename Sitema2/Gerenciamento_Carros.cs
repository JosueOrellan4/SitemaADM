using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema2
{
    public partial class Gerenciamento_Carros: Form
    {
        public Gerenciamento_Carros()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string connectionString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre conexão
                    consulta.Open();
                    //Consulta SQL para selecionar Clientes
                    string listagem = "SELECT Id_Carro, Proprietario, Telefone, Cpf, Placa, Ano, Chassi, Cor, Marca, Modelo, Acessorios, Valor FROM tb_Carros";

                    //Cria o comando MySql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtém os resultados.
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao dataGridView
                        dgvCarros.DataSource = dadosClientes;




                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os carros: " + ex.Message);
            }

        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            if (dgvCarros.SelectedRows.Count > 0)
            {
                int carroID = Convert.ToInt32(dgvCarros.SelectedRows[0].Cells["Id_Carro"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este carro?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //Defina sua string de conexão com o banco
                    string connectionString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados MySql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre conexão
                            consulta.Open();
                            //Consulta SQL para selecionar 
                            string listagem = "DELETE FROM tb_carros WHERE Id_Carro = @Id_Carro";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id_Carro", carroID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Carro excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o carro");
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }





                }
                else
                {
                    MessageBox.Show("Por favor, Selecione um carro para excluir");
                }
            }
        }
    }
}
