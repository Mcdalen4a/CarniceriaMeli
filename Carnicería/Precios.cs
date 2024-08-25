using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carnicería
{
    public partial class Precios : Form
    {
        string connectionString = "server=DESKTOP-9F0T7S1\\SQLEXPRESS; database=Carnicería; integrated security=true";

        public Precios()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.RowValidated += dataGridView1_RowValidated;
            Guardar.Click += guardar_Click;
        }

        private void Precios_Load(object sender, EventArgs e)
        {
            CargarProductos();
            ConfigureDataGridViewStyle();

            if (dataGridView1.Columns["ID"] != null)
            {
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void ConfigureDataGridViewStyle()
        {
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(23, 24, 29);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11, System.Drawing.FontStyle.Bold);

            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10);

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.GridColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void CargarProductos()
        {
            string query = "SELECT * FROM PRODUCTOS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    try
                    {
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        dataGridView1.AllowUserToAddRows = true;
                        dataGridView1.AllowUserToDeleteRows = true;
                        dataGridView1.ReadOnly = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los productos: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // No es necesario realizar acciones aquí si solo vamos a guardar todo al hacer clic en el botón
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            // No es necesario realizar acciones aquí si solo vamos a guardar todo al hacer clic en el botón
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            string updateQuery = "UPDATE PRODUCTOS SET Precio = @Precio WHERE Productos = @Productos";
            string insertQuery = "INSERT INTO PRODUCTOS (Productos, Precio) VALUES (@Productos, @Precio)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        updateCommand.Transaction = transaction;
                        insertCommand.Transaction = transaction;

                        try
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    if (row.Cells["Productos"].Value != null && !string.IsNullOrEmpty(row.Cells["Productos"].Value.ToString()))
                                    {
                                        updateCommand.Parameters.Clear();
                                        updateCommand.Parameters.AddWithValue("@Precio", row.Cells["Precio"].Value ?? (object)DBNull.Value);
                                        updateCommand.Parameters.AddWithValue("@Productos", row.Cells["Productos"].Value);

                                        updateCommand.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        insertCommand.Parameters.Clear();
                                        insertCommand.Parameters.AddWithValue("@Productos", row.Cells["Productos"].Value ?? (object)DBNull.Value);
                                        insertCommand.Parameters.AddWithValue("@Precio", row.Cells["Precio"].Value ?? (object)DBNull.Value);

                                        insertCommand.ExecuteNonQuery();
                                    }
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Datos guardados correctamente.");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error al guardar los datos: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
