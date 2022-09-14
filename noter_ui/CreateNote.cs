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
    public partial class CreateNote : Form
    {
        string? name;
        string? note;
        public CreateNote(string? name, string? note)
        {
            InitializeComponent();
            this.name = name;
            this.note = note;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Muistiinpanon nimi ei voi olla tyhjä");
                return;
            }
            else if (File.Exists(txtName.Text + ".txt") && name != txtName.Text)
            {
                MessageBox.Show("Tämä muistiinpano on jo olemassa");
                return;
            }
            if (!File.Exists(txtName.Text))
            {
                File.Delete(name + ".txt");
            }
            using (StreamWriter sw = File.CreateText(txtName.Text + ".txt"))
            {
                sw.WriteLine(txtNote.Text);
            }
            MessageBox.Show("Muistiinpano tallennettu");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtName.Text + ".txt") && name != txtName.Text)
            {
                lbExists.Text = "Muistiinpano on jo olemassa";
            }
            else
            {
                lbExists.Text = "";
            }
        }

        private void CreateNote_Load(object sender, EventArgs e)
        {
            if (name != "")
            {
                txtName.Text = name;
            }
            if (note != "")
            {
                txtNote.Text = note;
            }
        }
    }
}
