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
    public partial class PetsForm : Form
    {
        public PetsForm()
        {
            InitializeComponent();
        }
        VeterinerDbEntities baglan = new VeterinerDbEntities();
        private void PetsForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = baglan.Custormers.ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "full_name";
            doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pets pets = new Pets();
            pets.customers_id = Convert.ToInt16(comboBox1.SelectedValue.ToString());;
            pets.name = textBox1.Text;
            pets.species = textBox2.Text;
            pets.breed = textBox3.Text;
            pets.gender = comboBox2.Text;
            pets.birth_date = dateTimePicker1.Value;
            pets.chip_number = textBox4.Text;
            pets.created_at = DateTime.Now;
            baglan.Pets.Add(pets);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Yapıldı");
            doldur();
        }
        private void doldur()
        {
            dataGridView1.DataSource = baglan.Pets.ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir=dataGridView1.CurrentCell.RowIndex;
            comboBox1.DisplayMember = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[satir].Cells[6].Value.ToString();
            textBox4.Text= dataGridView1.Rows[satir].Cells[7].Value.ToString();
            Idtxt.Text= dataGridView1.Rows[satir].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idno = Convert.ToInt16(Idtxt.Text);
            var result = baglan.Pets.Find(idno);
            baglan.Pets.Remove(result);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Silindi");
            doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idno = Convert.ToInt16(Idtxt.Text);
            var result = baglan.Pets.Find(idno);
            result.customers_id =Convert.ToInt32(comboBox1.ValueMember.ToString());
            result.name = textBox1.Text;
            result.species = textBox2.Text;
            result.breed = textBox3.Text;
            result.gender = comboBox2.Text;
            result.birth_date = dateTimePicker1.Value;
            result.chip_number = textBox4.Text;
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Düzeltildi");
            doldur();
        }
    }
}
