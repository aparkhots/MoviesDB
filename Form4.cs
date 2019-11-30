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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_nameDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "base_nameDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.base_nameDataSet.orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordersBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ordersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_nameDataSet);
        }
    }
}
