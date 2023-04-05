using MovieTicket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicket
{
    public partial class Admin : Form
    {
        List<NotebookList> notebookLists = new List<NotebookList>();
        public Admin()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            if (add.DialogResult == DialogResult.OK)
            {
                notebookLists.Add(add.getNotebookList());
                Reload();
            }
        }
        private void Reload()
        {
            dataGridView1.Rows.Clear();
            foreach (NotebookList item in notebookLists)
            {
                dataGridView1.Rows.Add(item.student.studentid, item.student.name, item.notebook.NotebookID, item.notebook.NotebookName, item.date);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "save";
            openfile.Filter = "CSV|*.csv";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                notebookLists.Clear();
                dataGridView1.Rows.Clear();
                using (StreamReader file = new StreamReader(openfile.FileName))
                {
                    string line;
                    int count = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        notebookLists.Add(new NotebookList(new Student(data[0], data[1]), new Notebook(data[2], data[3]), new DateTime().AddTicks(long.Parse(data[4]))));
                    }
                }
                Reload();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "save";
            saveFile.Filter = "CSV|*.csv";
            saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {
                using (StreamWriter file = new StreamWriter(saveFile.FileName))
                {
                    foreach (NotebookList notebook in notebookLists)
                    {
                        file.WriteLine($"{notebook.student.studentid}, {notebook.student.name}, {notebook.notebook.NotebookID}, {notebook.notebook.NotebookName}, {notebook.date.Ticks}");
                    }
                }
            }
        }
    }
}
