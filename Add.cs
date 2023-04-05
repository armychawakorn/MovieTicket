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
    public partial class Add : Form
    {
        private NotebookList notebooklist;
        public Add()
        {
            InitializeComponent();
            foreach (Notebook item in new Notebooks().getAllNotebooks())
            {
                selectnotebook.Items.Add($"{item.NotebookName}");
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            notebooklist = new NotebookList(new Student(studentid.Text, studentname.Text), new Notebooks().getAllNotebooks()[selectnotebook.SelectedIndex], dateTimePicker1.Value);
            this.DialogResult = DialogResult.OK;
        }
        public NotebookList getNotebookList()
        {
            return notebooklist;
        }
    }
}
