using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snippets
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeTableLayoutPanel();
        }
        private void InitializeTableLayoutPanel()
        {
            // Crear un TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnCount = 2;

            // Afegir controls al TableLayoutPanel
            tableLayoutPanel.Controls.Add(new Label { Text = "Nom:" }, 0, 0);
            tableLayoutPanel.Controls.Add(new TextBox(), 1, 0);
            tableLayoutPanel.Controls.Add(new Label { Text = "Edat:" }, 0, 1);
            tableLayoutPanel.Controls.Add(new TextBox(), 1, 1);

            // Afegir el TableLayoutPanel al formulari
            this.Controls.Add(tableLayoutPanel);
        }
    }


}
