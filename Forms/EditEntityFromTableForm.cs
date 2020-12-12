using MSAccessApp.Modules;
using MSAccessApp.Persistence;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MSAccessApp.Forms
{
    public partial class EditEntityFromTableForm : Form
    { 
        private readonly IDatabaseProvider _databaseProvider;

        private List<RadioButton> _tablesRadioButtons = new List<RadioButton>();
        private Button _editEntityButton;
        private GroupBox _currentInputs;

        public EditEntityFromTableForm(IDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
            InitializeComponent();
            _editEntityButton = new Button();
            _editEntityButton.Hide();
            _editEntityButton.Text = "Применить";
            _editEntityButton.Location = new Point(650, 75);
            _editEntityButton.Click += HandleOnSumbit;
            _editEntityButton.Size = new Size(100, 40);
            _editEntityButton.BackColor = Color.White;
            _editEntityButton.Dock = DockStyle.Fill;
            _editEntityButton.Size = Nazad.Size;
            Controls.Add(_editEntityButton);
            PrintTablesList();
            this.Show();
        }

        private void PrintTablesList()
        {
            var tables = _databaseProvider.GetTables();
            var groupBox = new GroupBox();
            groupBox.Dock = DockStyle.Fill;
            groupBox.Text = "Выберите таблицу";
            groupBox.Location = new Point(30, 70);
            groupBox.Size = new Size(220, (tables.Count + 2) * 20);

            var y = 20;
            foreach (var tableName in tables)
            {
                var button = new RadioButton();
                button.Location = new Point(31, y);
                button.Name = tableName;
                button.Text = tableName;
                button.CheckedChanged += HandleTablesCheckedChanged;

                groupBox.Controls.Add(button);
                _tablesRadioButtons.Add(button);
                y += 20;
            }

            Controls.Add(groupBox);
        }

        private void HandleTablesCheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;
            if (button == null) { return; }

            if (button.Checked)
            {
                if (_currentInputs != null)
                {
                    Controls.Remove(_currentInputs);
                    _currentInputs?.Dispose();
                }

                _editEntityButton.Show();
                var groupBox = new GroupBox();
                groupBox.Dock = DockStyle.Top;
                groupBox.Text = "Заполните поля, которые необходимо обновить";
                (var rows, var columns) = _databaseProvider.GetRowsFromTable(button.Name);
                groupBox.Location = new Point(300, 70);
                groupBox.Size = new Size(320, (columns.Count) * 40 + 40);

                var y = 20;

                foreach (var column in columns)
                {
                    var description = new Label();
                    var input = new TextBox();
                    description.Location = new Point(5, y);
                    description.Size = new Size(300, 30);
                    description.TextAlign = ContentAlignment.TopRight;
                    description.Text = $"{column}:";
                    input.Location = new Point(315, y);
                    input.Size = new Size(300, 30);
                    y += 40;
                    groupBox.Controls.Add(input);
                    groupBox.Controls.Add(description);
                }

                Controls.Add(groupBox);
                _currentInputs = groupBox;
            }
        }

        private void HandleOnSumbit(object sender, EventArgs e)
        {
            var tableName = _tablesRadioButtons.FirstOrDefault(_ => _.Checked).Name;
            var values = new string[_currentInputs.Controls.Count];
            var typeOnColumns = _databaseProvider.GetTableColumnsWithTypes(tableName);
            (var rows, var columns) = _databaseProvider.GetRowsFromTable(tableName);
            try
            {
                for (var i = 0; i < _currentInputs.Controls.Count; ++i)
                {
                    values[i] = Parser.GetValueFromInput(_currentInputs.Controls[i].Text, typeOnColumns[columns[i]]);
                    _currentInputs.Controls[i].Text = columns[i] + ":";
                }

                if (_databaseProvider.UpdateRowFromTable(tableName, values))
                {
                    MessageBox.Show("Запись успешно обновлена.");
                }
                else
                {
                    MessageBox.Show("Запись обновлена не была. Попробуйте снова.");
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Записи с таким идентификатором в таблице нет. Попробуйте снова.");
            }
            _currentInputs.Hide();
            _editEntityButton.Hide();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
