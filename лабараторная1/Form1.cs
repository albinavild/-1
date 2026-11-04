using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабараторная1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void разрабToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработал: Вильд Альбина Вариант 15\nГруппа: 231", "О разработчике", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void вводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем и открываем вторую форму
            Form2 Form2 = new Form2();
            Form2.ShowDialog(); // ShowDialog блокирует главное окно, пока открыто это
        }
    }
}
