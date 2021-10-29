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
    public partial class CounterControl : UserControl
    {
        public CounterControl()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnCancelTurn.Text = "Отмена хода";
            btnReset.Text = "Сброс";
            labelSum.Text = "0";
            labelCommandCount.Text = "0";
        }
        Stack<string> accountResults = new Stack<string>();
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            labelSum.Text = (int.Parse(labelSum.Text) + 1).ToString();
            accountResults.Push(labelSum.Text);
            labelCommandCount.Text = (int.Parse(labelCommandCount.Text) + 1).ToString();
            if (btnReset.Enabled == false)
            {
                btnReset.Enabled = true;
            }
            if (btnCancelTurn.Enabled == false)
            {
                btnCancelTurn.Enabled = true;
            }
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            labelSum.Text = (int.Parse(labelSum.Text) * 2).ToString();
            accountResults.Push(labelSum.Text);
            labelCommandCount.Text = (int.Parse(labelCommandCount.Text) + 1).ToString();
            if (btnReset.Enabled == false)
            {
                btnReset.Enabled = true;
            }
            if (btnCancelTurn.Enabled == false)
            {
                btnCancelTurn.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelSum.Text = "0";
            labelCommandCount.Text = "0";
        }

        private void btnCancelTurn_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelSum.Text) > 0)
            {
                labelCommandCount.Text = (int.Parse(labelCommandCount.Text) + 1).ToString();
                accountResults.Pop();
                labelSum.Text = accountResults.Peek();
            }
            else
            {
                btnCancelTurn.Enabled = false;
            }

        }
    }
}
