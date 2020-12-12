using MSAccessApp.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MSAccessApp.Forms
{
    public partial class AllEntitiesFromTableForm : Form
    {
        #region Fields

        private readonly IDatabaseProvider _databaseProvider;
        private readonly Dictionary<Button, EventHandler> _clickHandlerOnButton = new Dictionary<Button, EventHandler>();

        #endregion


        public AllEntitiesFromTableForm(IDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
            InitializeComponent();
            this.Show();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            (var rows, var columns) = _databaseProvider.GetRowsFromTable("Врач");

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

        private void Pacients_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            (var rows, var columns) = _databaseProvider.GetRowsFromTable("Пациент");

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

        private void Medical_establishments_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            (var rows, var columns) = _databaseProvider.GetRowsFromTable("Лечебное учреждение");

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

        private void Diagnoses_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            (var rows, var columns) = _databaseProvider.GetRowsFromTable("Диагноз");

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

        private void Procedures_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            (var rows, var columns) = _databaseProvider.GetRowsFromTable("Процедура");

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

        private void Appointments_Click(object sender, EventArgs e)
        {
            TableView.Clear();
            (var rows, var columns) = _databaseProvider.GetRowsFromTable("Приём");

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
    }
}
