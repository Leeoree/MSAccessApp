using MSAccessApp.Persistence;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MSAccessApp.Forms
{
    public partial class StartMenu : Form
    {
        private readonly IDatabaseProvider _databaseProvider;

        public StartMenu(IDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Salmon;
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.White;
            CloseButton.ForeColor = Color.Black;
        }

        private void AllEntitiesFromTableFormButton_Click(object sender, EventArgs e)
        {
            new AllEntitiesFromTableForm(_databaseProvider);
        }

        private void AddEntityFormButton_Click(object sender, EventArgs e)
        {
            new AddEntityForm(_databaseProvider);
        }

        private void RemoveEntityFromTableFormButton_Click(object sender, EventArgs e)
        {
            new RemoveEntityFromTableForm(_databaseProvider);
        }

        private void EditEntityFromTableFormButton_Click(object sender, EventArgs e)
        {
            new EditEntityFromTableForm(_databaseProvider);
        }

        private void MSysObjectsFormsButton_Click(object sender, EventArgs e)
        {
            new MSysObjectsForm(_databaseProvider);
        }

        private void Requests_Click(object sender, EventArgs e)
        {
            new AllRequests(_databaseProvider);
        }
    }
}
