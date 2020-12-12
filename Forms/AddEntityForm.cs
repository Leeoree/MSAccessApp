using MSAccessApp.Modules;
using MSAccessApp.Persistence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MSAccessApp.Forms
{
    public partial class AddEntityForm : Form
    {
        private readonly IDatabaseProvider _dataBaseProvider;

        private List<RadioButton> _tablesRadioButtons = new List<RadioButton>();
        private Button _addEntityButton;
        private GroupBox _currentInputs;

        public AddEntityForm(IDatabaseProvider databaseProvider)
        {
            _dataBaseProvider = databaseProvider;
            InitializeComponent();
            _addEntityButton = new Button();
            _addEntityButton.Hide();
            _addEntityButton.Text = "Добавить";
            _addEntityButton.Location = new Point(650, 75);
            _addEntityButton.Click += HandleOnSumbit;
            _addEntityButton.Dock = DockStyle.Fill;
            _addEntityButton.Size = Nazad.Size;
            _addEntityButton.BackColor = Color.White;
            Controls.Add(_addEntityButton);
            PrintTablesList();
            this.Show();
        }

        private void PrintTablesList()
        {
            var tables = _dataBaseProvider.GetTables();
            var groupBox = new GroupBox();
            groupBox.Dock = DockStyle.Fill;
            groupBox.Text = "Выберите таблицу";
            groupBox.Location = new Point(30, 70);
            groupBox.Size = new Size(300, (tables.Count + 2) * 20);

            var y = 20;
            foreach (var tableName in tables)
            {
                var button = new RadioButton();
                button.Location = new Point(31, y);
                button.Size = new Size(190, 20);
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

                _addEntityButton.Show();
                var groupBox = new GroupBox();
                groupBox.Dock = DockStyle.Top;
                groupBox.Text = "Заполните поля новой записи";
                (var rows, var columns) = _dataBaseProvider.GetRowsFromTable(button.Name);
                groupBox.Location = new Point(300, 70);
                groupBox.Size = new Size(800, (columns.Count) * 40 + 40);

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
            var values = new string[_currentInputs.Controls.Count / 2];
            var typeOnColumns = _dataBaseProvider.GetTableColumnsWithTypes(tableName);
            (var rows, var columns) = _dataBaseProvider.GetRowsFromTable(tableName);
            var success = true;
            try
            {
                for (var i = 0; i < _currentInputs.Controls.Count; i = i + 2)
                {
                    values[i/2] = Parser.GetValueFromInput(_currentInputs.Controls[i].Text, typeOnColumns[columns[i/2]]);                 
                }
            }
            catch (Exception) { success = false; }
            if (success)
            {
                success &= _dataBaseProvider.AddRowToTable(tableName, values);
            }

            if (success)
            {
                MessageBox.Show("Запись успешно добавлена.");
            }
            else
            {
                MessageBox.Show("Запись добавлена не была. Попробуйте снова.");
            }
            _currentInputs.Hide();
            _addEntityButton.Hide();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
