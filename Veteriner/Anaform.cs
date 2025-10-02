using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veteriner
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 musteri=new Form1();
            musteri.MdiParent = this;
            musteri.Show();

        }

        private void hayvanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetsForm pet = new PetsForm();
            pet.MdiParent = this;
            pet.Show();
        }

        private void aşıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VaccForm vaccForm = new VaccForm();
            vaccForm.MdiParent = this;
            vaccForm.Show();
        }

        private void ziyaretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitForm visitForm = new VisitForm();  
            visitForm.MdiParent = this; 
            visitForm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
