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
    public partial class VaccForm : Form
    {
        public VaccForm()
        {
            InitializeComponent();
        }
        VeterinerDbEntities baglan = new VeterinerDbEntities();
        /// <summary>
        /// database bağlanmak için kullandığımız kod
         
        
        private void VaccForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = baglan.Pets.ToList();
            //hayvan tüm bilgileri tolist çek combobox ata
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "Id";
            doldur();
        }
        private void doldur()
        {
            dataGridView1.DataSource = baglan.vaccinations.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vaccinations vacc = new vaccinations();
            vacc.pet_id=Convert.ToInt16(comboBox1.SelectedValue.ToString());
            vacc.vaccine_name = textBox1.Text;
            vacc.vaccination_date = dateTimePicker1.Value;
            vacc.next_due_date = dateTimePicker2.Value;
            vacc.notes = textBox2.Text;
            baglan.vaccinations.Add(vacc);
            baglan.SaveChanges();
            MessageBox.Show("Kaydınız Yapılmıştır");
            doldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentCell.RowIndex;
            Idtxt.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            comboBox1.Text= dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox1.Text= dataGridView1.Rows[satir].Cells[2].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[satir].Cells[3].Value.ToString();
            dateTimePicker2.Text= dataGridView1.Rows[satir].Cells[4].Value.ToString();
            textBox2.Text= dataGridView1.Rows[satir].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(Idtxt.Text);
            var sonuc = baglan.vaccinations.Find(Id);
            baglan.vaccinations.Remove(sonuc);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Silindi");
            doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(Idtxt.Text);
            var sonuc = baglan.vaccinations.Find(Id);
            sonuc.notes = textBox2.Text;
            sonuc.vaccination_date = dateTimePicker1.Value;
            sonuc.next_due_date = dateTimePicker2.Value;
            sonuc.vaccine_name = textBox1.Text;
            sonuc.pet_id = Convert.ToInt16(comboBox1.Text);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi");
            doldur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                

            }
            else if(radioButton2.Checked)
            {
                var sonuc = baglan.vaccinations.Where(p => p.vaccine_name.Contains(textBox3.Text)).ToList();
                dataGridView1.DataSource = sonuc;
            }
            else if(radioButton3.Checked)
            {
                var sonuc = baglan.vaccinations.Where(z => z.notes.Contains(textBox3.Text)).ToList();
                dataGridView1.DataSource = sonuc;
            }
        }
    }
}
