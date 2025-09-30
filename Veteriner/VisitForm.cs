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
    public partial class VisitForm : Form
    {
        public VisitForm()
        {
            InitializeComponent();
        }
        VeterinerDbEntities baglan=new VeterinerDbEntities();
        //int a=10
        private void VisitForm_Load(object sender, EventArgs e)
        {
            var result=baglan.Pets.ToList();
            //ToList Tüm verileri Getir result içine ata
            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "Id";
            doldur();
        }
        private void doldur()
        {
            dataGridView1.DataSource = baglan.visits.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visits visit = new visits();
            visit.pet_id = Convert.ToInt16(comboBox1.SelectedValue.ToString());
            visit.visit_date = dateTimePicker1.Value;
            visit.reason = textBox1.Text;
            visit.diagnosis = textBox2.Text;
            visit.treatment = textBox3.Text;
            visit.notes = textBox4.Text;
            baglan.visits.Add(visit);
            baglan.SaveChanges();
            MessageBox.Show("Kaydınız Yapılmıştır");
            doldur();
            temizle();
        }
        private void temizle()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir=dataGridView1.CurrentCell.RowIndex;//Id numarası sil ve güncelle
            Idtxt.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap=MessageBox.Show("Kayıt Silinecek Onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if(cevap == DialogResult.Yes)
            {
                int Id = Convert.ToInt16(Idtxt.Text);//Id numarasına göre 
                var sonuc = baglan.visits.Find(Id);//veritabanından bunu bul
                baglan.visits.Remove(sonuc);//bulduğun satırı database visit tablosundan sil
                baglan.SaveChanges();//database kayıt et
                MessageBox.Show("Kayıt Silindi");//kayıt silindi
                doldur();//datagrid doldur
                temizle();//text combobox1 sil
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(Idtxt.Text);//Id numarasına göre 
            var sonuc = baglan.visits.Find(Id);//veritabanından bunu bul
            sonuc.pet_id = Convert.ToInt16(comboBox1.SelectedValue.ToString()); 
            sonuc.visit_date = dateTimePicker1.Value;
            sonuc.reason = textBox1.Text;
            sonuc.diagnosis = textBox2.Text;
            sonuc.treatment = textBox3.Text;    
            sonuc.notes = textBox4.Text;
            baglan.SaveChanges();//database kayıt et
            doldur();
            temizle();
            MessageBox.Show("Kayıt Güncellendi");   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                var sonuc=baglan.visits.Where(x=>x.visit_date ==Convert.ToDateTime(Aratxt.Text)).ToList();
                //lambda kısa yazım
                dataGridView1.DataSource = sonuc;

            }
            else if(radioButton2.Checked)
            {
                //var sonuc=baglan.visits.Where(x => x.reason==Aratxt.Text).ToList();
                //burada mantı aratext içinde yazdığın kelime birbir uyuşması lazım
                //uymazsa sonuc gelmez.
                var sonuc=baglan.visits.Where(x => x.reason.Contains(Aratxt.Text)).ToList();
                //Contains reason içinde harf hece ve kelime göre arama yap
                //lambda kısa yazım..
                //var sonuc=(from vs in baglan.visits where vs.reason.Contains(Aratxt.Text) select vs).ToList();  
                //linq yazılım uzun yazılım
                dataGridView1.DataSource = sonuc;

            }
            else if (radioButton3.Checked)
            {
                var sonuc=baglan.visits.Where(x => x.diagnosis.Contains(Aratxt.Text)).ToList();
                //sonuc=(from vs in baglan.visits where vs.diagnosis.Contains(Aratxt.Text) select vs).ToList(); 
                //linq
                dataGridView1.DataSource = sonuc;
            }
            else if (radioButton4.Checked)
            {

            }
            else if(radioButton5.Checked)
            {

            }
            else
            {
                MessageBox.Show("Lütfen Bir Seçim Yapınız");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sonuc = baglan.visits.OrderBy(x => x.visit_date).ToList();
            //küçük büyük göre sırala
            dataGridView1.DataSource = sonuc;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sonuc=baglan.visits.OrderByDescending(x => x.visit_date).ToList();
            dataGridView1.DataSource = sonuc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var sonuc=baglan.visits.OrderByDescending(x=>x.visit_date).Take(5).ToList();
            dataGridView1.DataSource = sonuc;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var sonuc = baglan.visits.OrderByDescending(x => x.visit_date).Take(5).Skip(10).ToList();
            dataGridView1.DataSource = sonuc;
        }
    }
}
