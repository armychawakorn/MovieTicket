using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Class
{
    public class NotebookList
    {
        public Student student;
        public Notebook notebook;
        public DateTime date;

        public NotebookList(Student student, Notebook notebook, DateTime date)
        {
            this.student = student;
            this.notebook = notebook;
            this.date = date;
        }
    }
}
