using MSAccessApp.Persistence;
using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace MSAccessApp.Forms
{
    public partial class AllRequests : Form
    {
        private readonly IDatabaseProvider _databaseProvider;

        public AllRequests(IDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
            InitializeComponent();
            this.Show();
        }

        private bool IsRequestExist(string query)
        {
            var connectionsString = ConfigurationManager.ConnectionStrings["Database"];

            using (var connection = new OleDbConnection(connectionsString.ConnectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT MSysObjects.Id, MSysObjects.Name FROM MSysObjects WHERE(((MSysObjects.Name) = @Temp1))";
                    cmd.Parameters.AddWithValue("@Temp1", query);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    return rd.HasRows;
                }
                catch { }
            }

            return false;
        }

        private void Pacients70000000_Click(object sender, EventArgs e)
        {
            var connectionsString = ConfigurationManager.ConnectionStrings["Database"];

            using (var connection = new OleDbConnection(connectionsString.ConnectionString))
            {
                try
                {
                    var stringQuery = "SELECT COUNT(*) AS Количество FROM Пациент WHERE Пациент.[Номер страхового полиса] > 70000000;";
                    var adapter = new OleDbDataAdapter(stringQuery, connection);
                    var dataSet = new DataSet();

                    adapter.Fill(dataSet);

                    var result = "";

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        result += $"{row.ItemArray[0]}";
                    }

                    MessageBox.Show($"Кол-во пациентов со страховым полисом большим 7000 0000\n{ result}");
                }
                catch { }
            }
        }

        private void Doctors2019_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            (var rows, var columns) = _databaseProvider.GetRowsFromTable("Выборка 3 - Врачи, проводившие приём в 2019 году");

            var items = rows.AsEnumerable().Where(row => row as DataRow != null)
                .Select(dataRow =>
                {
                    var listViewItem = new ListViewItem(dataRow.ItemArray[0]?.ToString());

                    if (dataRow.ItemArray.Length > 1)
                    {
                        listViewItem.SubItems.AddRange(dataRow.ItemArray.Skip(1).Select(_ => _?.ToString()).ToArray());

                    }

                    return listViewItem;
                })
                .ToArray();

            foreach (var columnName in columns)
            {
                TableView.Columns.Add(columnName.ToString(), TableView.Width / columns.Count, HorizontalAlignment.Left);
            }

            TableView.Items.AddRange(items);
            TableView.AllowColumnReorder = true;
            TableView.View = View.Details;
            TableView.FullRowSelect = true;
            TableView.GridLines = true;
        }
        
        private void Doctors1_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            (var rows, var columns) = _databaseProvider.GetRowsFromTable("Выборка 1 - Врачи, поставившие на приёме диагноз номер 1");

            var items = rows.AsEnumerable().Where(row => row as DataRow != null)
                .Select(dataRow =>
                {
                    var listViewItem = new ListViewItem(dataRow.ItemArray[0]?.ToString());

                    if (dataRow.ItemArray.Length > 1)
                    {
                        listViewItem.SubItems.AddRange(dataRow.ItemArray.Skip(1).Select(_ => _?.ToString()).ToArray());

                    }

                    return listViewItem;
                })
                .ToArray();

            foreach (var columnName in columns)
            {
                TableView.Columns.Add(columnName.ToString(), TableView.Width / columns.Count, HorizontalAlignment.Left);
            }

            TableView.Items.AddRange(items);
            TableView.AllowColumnReorder = true;
            TableView.View = View.Details;
            TableView.FullRowSelect = true;
            TableView.GridLines = true;
        }

        private void AppointmentsDate_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            var connectionsString = ConfigurationManager.ConnectionStrings["Database"];

            using (var connection = new OleDbConnection(connectionsString.ConnectionString))
            {
                try
                {
                    var stringQuery = $"SELECT * FROM Приём WHERE Приём.[Дата приёма]= {DateForAppointments.Text}; ";
                    var adapter = new OleDbDataAdapter(stringQuery, connection);
                    var dataSet = new DataSet();

                    adapter.Fill(dataSet);

                   

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        foreach (var filed in row.ItemArray)
                        {
                            TableView.Columns.Add(filed.ToString(), TableView.Width / dataSet.Tables[0].Columns.Count, HorizontalAlignment.Left);
                        }
                    }

                    TableView.AllowColumnReorder = true;
                    TableView.View = View.Details;
                    TableView.FullRowSelect = true;
                    TableView.GridLines = true;                                       
                }
                catch
                {
                    MessageBox.Show("Попробуйте снова.");
                }
                finally
                {
                    DateForAppointments.Clear();
                }
            }
        }

        private void Birthday_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            //TableView.Items.AddRange(items);
            
            var connectionsString = ConfigurationManager.ConnectionStrings["Database"];

            using (var connection = new OleDbConnection(connectionsString.ConnectionString))
            {
                try
                {
                    var stringQuery = $"SELECT * FROM Пациент WHERE [Дата рождения]> {BirthdayDate.Text}; ";
                    var adapter = new OleDbDataAdapter(stringQuery, connection);
                    var dataSet = new DataSet();

                    adapter.Fill(dataSet);

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        foreach (var filed in row.ItemArray)
                        {
                            TableView.Columns.Add(filed.ToString(), TableView.Width / dataSet.Tables[0].Columns.Count, HorizontalAlignment.Left);
                        }
                    }

                    TableView.AllowColumnReorder = true;
                    TableView.View = View.Details;
                    TableView.FullRowSelect = true;
                    TableView.GridLines = true;
                }
                catch
                {
                    MessageBox.Show("Попробуйте снова.");
                }
                finally
                {
                    BirthdayDate.Clear();
                }
                
            }
        }

        private void PacientDiag_Click(object sender, EventArgs e)
        {
            TableView.Clear();

            var connectionsString = ConfigurationManager.ConnectionStrings["Database"];

            using (var connection = new OleDbConnection(connectionsString.ConnectionString))
            {
                try
                {
                    var stringQuery = $"SELECT Пациент.Фамилия FROM Пациент INNER JOIN Приём ON Пациент.[Номер страхового полиса] = Приём.[Номер страхового полиса] WHERE Приём.[Номер диагноза]= {Diag.Text}; ";
                    var adapter = new OleDbDataAdapter(stringQuery, connection);
                    var dataSet = new DataSet();

                    adapter.Fill(dataSet);


                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        foreach (var filed in row.ItemArray)
                        {
                            TableView.Columns.Add(filed.ToString(), TableView.Width / dataSet.Tables[0].Columns.Count, HorizontalAlignment.Left);
                        }
                    }

                    TableView.AllowColumnReorder = true;
                    TableView.View = View.Details;
                    TableView.FullRowSelect = true;
                    TableView.GridLines = true;
                }
                catch
                {
                    MessageBox.Show("Попробуйте снова.");
                }
                finally
                {
                    Diag.Clear();
                }

            }
        }

        private void AddProc_Click(object sender, EventArgs e)
        {
            var connectionsString = ConfigurationManager.ConnectionStrings["Database"];

            using (var connection = new OleDbConnection(connectionsString.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Процедура ([Номер процедуры], Название) VALUES (@Number, @Name)";
                    cmd.Parameters.AddWithValue("@Number", 8);
                    cmd.Parameters.AddWithValue("@Name", "Прогревание");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Процедура №8 - 'Прогревание' успешно добавлена.");
                }
                catch
                {
                    MessageBox.Show("Попробуйте снова.");
                }
            }
        }

        private void DeleteProc_Click(object sender, EventArgs e)
        {
            var connectionsString = ConfigurationManager.ConnectionStrings["Database"];

            using (var connection = new OleDbConnection(connectionsString.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE * FROM Процедура WHERE[Номер процедуры] = 8;";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Процедура №8 успешно удалена.");
                }
                catch
                {
                    MessageBox.Show("Попробуйте снова.");
                }
            }

        }

        private void ChangeProc_Click(object sender, EventArgs e)
        {
            var connectionsString = ConfigurationManager.ConnectionStrings["Database"];

            using (var connection = new OleDbConnection(connectionsString.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Процедура SET Длительность = @Duration, Цена = @Price WHERE [Номер процедуры] = 8;";
                    cmd.Parameters.AddWithValue("@Duration", 0.05);
                    cmd.Parameters.AddWithValue("@Price", 1000);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Процедура №8 успешно изменена.");
                }
                catch
                {
                    MessageBox.Show("Попробуйте снова.");
                }
            }
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
