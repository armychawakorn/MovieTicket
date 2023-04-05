using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Class
{
    public class Notebook
    {
        public string NotebookID;
        public string NotebookName;
        public Notebook(string notebookID, string notebookName)
        {
            NotebookName = notebookName;
            NotebookID = notebookID;
        }
    }
}
