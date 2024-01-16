using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kersach
{
    public partial class FormAddWorker : Form
    {
        public FormAddWorker()
        {
            InitializeComponent();
        }

        private void FormAddWorker_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 1;
            textBox1.Focus(); // при открытии окна, textBox1 получает фокус
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
