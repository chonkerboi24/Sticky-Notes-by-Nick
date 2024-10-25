using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sticky_Notes_by_Nick
{
    public partial class StickNotes : Form
    {
        public StickNotes()
        {
            InitializeComponent();
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            Process newNote = new Process();

            newNote.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "Sticky Notes by Nick.exe";

            newNote.Start();
        }
    }
}
