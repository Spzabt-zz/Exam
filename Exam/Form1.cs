using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private readonly Student[] _students;

        public Form1()
        {
            InitializeComponent();

            _students = new Student[]
            {
                new UsualStudent("Bogdan", "Stoida", "Oleksandrovich", 12),
                new UsualStudent("Bogdan1", "Stoida1", "Oleksandrovich1", 5),
                new UsualStudent("Bogdan2", "Stoida2", "Oleksandrovich2", 20),
                new UsualStudent("Bogdan3", "Stoida3", "Oleksandrovich3", 15),
                new UsualStudent("Bogdan4", "Stoida4", "Oleksandrovich4", 3),
                new CleverS("cs", "cd", "sxs", 12),
                new CleverS("cs", "cd", "sxs", 5),
                new CleverS("cs", "cd", "sxs", 20),
                new CleverS("cs", "cd", "sxs", 14),
                new GeniusStudent("Валерій", "Жмишенко", "Альбертович", 1)
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var student in _students)
            {
                if (student.PassExam())
                    textBox1.Text += student + ", Student passed exam" + Environment.NewLine;
                else
                    textBox1.Text += student + ", Student doesn't pass exam" + Environment.NewLine;
            }
        }
    }
}