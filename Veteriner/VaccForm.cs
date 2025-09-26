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
    }
}
