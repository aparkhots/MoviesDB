using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_nameDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "base_nameDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.base_nameDataSet.clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientsBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clientsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_nameDataSet);
        }

    }
}
