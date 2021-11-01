using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrueFalseEditor
{
    public partial class Main : Form
    {

        private TrueFalseDatabase database;

        public Main()
        {
            InitializeComponent();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(saveFileDialog.FileName);
                database.Add("Луна круглая?", true);
                database.Save();

                nudNumber.Maximum = 1;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;

            }
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(openFileDialog.FileName);
                database.Load();

                nudNumber.Maximum = database.Count;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;

            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            Question quetion = database[(int)nudNumber.Value - 1];
            tbQuestion.Text = quetion.Text;
            cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            database.Save();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (database!=null)
            {
                database.Add($"#{database.Count + 1}", true);

                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;

            }
            else
            {
                MessageBox.Show("Не создана база данных!", "Добавление вопроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            database.Remove((int)nudNumber.Value -1);

            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }
        /// <summary>
        /// сохраняет базу данных в новом файле с новым именем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(saveFileDialog.FileName, database.Questions);
                //database.Add(tbQuestion.Text, cbTrue.Checked);
                database.Save();
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
