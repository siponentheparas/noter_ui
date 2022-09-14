using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noter_ui
{
    public partial class OpenNote : Form
    {
        string? name;
        string? note;
        public OpenNote(string? name, string? note)
        {
            InitializeComponent();
            this.name = name;
            this.note = note;
        }

        private void OpenNote_Load(object sender, EventArgs e)
        {
            txtNote.Text = note;
            lbName.Text = name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
