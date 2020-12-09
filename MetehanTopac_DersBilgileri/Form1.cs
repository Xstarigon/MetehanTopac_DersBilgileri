using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetehanTopac_DersBilgileri
{
    public partial class Form1 : Form
    {
        private DersService dersService;
        public Form1()
        {
            InitializeComponent();
            dersService = new DersService(new MemoryOperations());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKategori.Items.Add("-- Seçiniz --");
            cbKategori.Items.Add("Sayısal");
            cbKategori.Items.Add("Sözel");
            cbKategori.SelectedIndex = 0;
            FillGrid();
        }

        void FillGrid()
        {
            Ders[] dersler = dersService.List();
            dataGridView1.DataSource = dersler;
        }

        private void rbHafiza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHafiza.Checked)
            {
                dersService = new DersService(new MemoryOperations());
                FillGrid();
            }

        }

        private void rbDosya_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDosya.Checked)
            {
                dersService = new DersService(new FileOperations());
                FillGrid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kategori = cbKategori.SelectedIndex;
            if (kategori == 0)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz!", "Hatalı Giriş", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbAd.Text) || string.IsNullOrWhiteSpace(tbIcerik.Text))
            {
                MessageBox.Show("Lütfen her alanı doldurunuz!", "Hatalı Giriş", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            Ders ders = new Ders()
            {
                Adi = tbAd.Text.Trim(),
                Icerik = tbIcerik.Text.Trim(),
                Kategori = (KategoriEnum) kategori,
                Kredi = (byte) nudKredi.Value
            };

            dersService.Add(ders);
            MessageBox.Show("Veri giriş işlemi tamamlandı.", "Başarılı", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            FillGrid();
        }
    }
}
