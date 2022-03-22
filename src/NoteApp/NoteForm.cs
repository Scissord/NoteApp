using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
