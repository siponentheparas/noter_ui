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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            var notes = Directory.EnumerateFiles(Directory.GetCurrentDirectory());
            foreach (string note in notes)
            {
                listBox.Items.Add(Path.GetFileNameWithoutExtension(note));
            }
            listBox.SelectedIndex = -1;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbName.Text = listBox.Items[listBox.SelectedIndex].ToString();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnOpen.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Haluatko poistaa muistiinpanon: " + listBox.Items[listBox.SelectedIndex].ToString(),
                                "Poista muistiinpano",
                                MessageBoxButtons.YesNo);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string? name = listBox.Items[listBox.SelectedIndex].ToString();
            string? note = File.ReadAllText(name + ".txt");
            CreateNote cn = new(name, note);
            this.Hide();
            cn.ShowDialog();
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string? name = listBox.Items[listBox.SelectedIndex].ToString();
            string? note = File.ReadAllText(name + ".txt");
            OpenNote on = new(name, note);
            this.Hide();
            on.ShowDialog();
            this.Close();
        }
    }
}
