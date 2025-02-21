using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new StudentContext())
            {
                var student = new Student
                {
                    Name = textName.Text,
                    Age = int.Parse(textAge.Text),
                    Class = textClass.Text
                };
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textClass_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new StudentContext())
                {
                    dataGridView1.DataSource = context.Students.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
    }
}
