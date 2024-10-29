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
        private void randomColor()
        {
            Random randomColor = new Random();

            int r = randomColor.Next(100, 256);
            int g = randomColor.Next(100, 256);
            int b = randomColor.Next(100, 256);

            BackColor = Color.FromArgb(r, g, b);
            btnNewNote.BackColor = Color.FromArgb(r, g, b);
            tbNote.BackColor = Color.FromArgb(r, g, b);
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            Process newNote = new Process();

            newNote.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "Sticky Notes by Nick.exe";

            newNote.Start();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            randomColor();
        }

        private void StickNotes_Load(object sender, EventArgs e)
        {
            randomColor();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = menuColorChange.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Red":
                    BackColor = Color.IndianRed;
                    btnNewNote.BackColor= Color.IndianRed;
                    tbNote.BackColor= Color.IndianRed;
                    break;
                case "Green":
                    BackColor = Color.LightGreen;
                    btnNewNote.BackColor= Color.LightGreen;
                    tbNote.BackColor = Color.LightGreen;
                    break;
                case "Blue":
                    BackColor = Color.Cyan;
                    btnNewNote.BackColor= Color.Cyan;
                    tbNote.BackColor= Color.Cyan;
                    break;
                case "Random":
                    randomColor();
                    break;

            }
        }
    }
}
