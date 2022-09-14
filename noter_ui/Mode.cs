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
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            CreateNote cn = new("", "");
            this.Hide();
            cn.ShowDialog();
            this.Show();
        }

        private void btnOpenNote_Click(object sender, EventArgs e)
        {
            Notes n = new();
            this.Hide();
            n.ShowDialog();
            this.Show();
        }
    }
}
