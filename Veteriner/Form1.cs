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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeterinerDbEntities baglan = new VeterinerDbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Custormers custormers = new Custormers();
            custormers.full_name = textBox1.Text;
            custormers.phone = textBox2.Text;
            custormers.email = textBox3.Text;
            custormers.address = textBox4.Text;
            custormers.created_at = DateTime.Now;
            baglan.Custormers.Add(custormers);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Yapıldı");
            doldur();
            temizle();
        }
        private void doldur()
        {
            dataGridView1.DataSource = baglan.Custormers.ToList();
        }
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            Idtxt.Text= dataGridView1.Rows[satir].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idno = Convert.ToInt16(Idtxt.Text);
            var result = baglan.Custormers.Find(idno);
            baglan.Custormers.Remove(result);
            baglan.SaveChanges();
            MessageBox.Show("Kayıt Silindi");
            doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idno = Convert.ToInt16(Idtxt.Text);
            var result = baglan.Custormers.Find(idno);
            result.full_name = textBox1.Text;
            result.phone = textBox2.Text;


        }
    }
}
