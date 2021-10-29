using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Udvoitel : Form
    {
        public Udvoitel()
        {
            InitializeComponent();
            this.Text = "Удвоитель";
        }

        private void игратьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sum = int.Parse(counterControl1.Controls["labelSum"].Text);
            var commandCount = int.Parse(counterControl1.Controls["labelCommandCount"].Text);
            if (!(sum>1&&commandCount>0))
            {
                Random target = new Random();
                int targetNumber = target.Next(10, 101);
                MessageBox.Show("Доберись за минимальное количество ходов до числа", $"{targetNumber}");
                counterControl1.Controls["panel1"].Controls["btnCommand1"].Enabled = true;
                counterControl1.Controls["panel1"].Controls["btnCommand2"].Enabled = true;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
