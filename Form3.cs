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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_nameDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "base_nameDataSet.movies". При необходимости она может быть перемещена или удалена.
            this.moviesTableAdapter.Fill(this.base_nameDataSet.movies);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            moviesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moviesBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moviesBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moviesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moviesBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            moviesBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_nameDataSet);
        }

    }
}
