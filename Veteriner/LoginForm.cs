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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        VeterinerDbEntities baglan=new VeterinerDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            var sorgu=baglan.Admin.Where(x=>x.Kul==username && x.Sifre==password).FirstOrDefault();
            if(sorgu!=null)
            {
                Anaform anaform = new Anaform();
                //anaform yeniden oluştur
                anaform.Show();
                //anaformu göster
                this.Hide();
                //login sayfasını gizle

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            //bu sorgu içinde varsayılan ilk değeri al ve sorgu değişkenine ata

            //if (username == "admin" && password == "admin")
            //{
            //    Anaform anaform = new Anaform();
            //    //anaform yeniden oluştur
            //    anaform.Show();
            //    //anaformu göster
            //    this.Hide();
            //    //login sayfasını gizle
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            //}
        }
    }
}
