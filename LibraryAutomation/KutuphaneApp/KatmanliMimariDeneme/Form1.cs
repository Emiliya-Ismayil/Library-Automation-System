using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;


namespace KatmanliMimariDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapListele();
            kategoriListele();

        }

        private void kategoriListele()
        {
             List<EKategori> kategoriListesi = BLLKategori.SelectList();
          
            cbKategori.DataSource = kategoriListesi;
         

        }

        private void kitapListele()
        {
            List<EKitap> kitaplistesi = BLLKitap.SelectList();
            dataGridView2.DataSource = kitaplistesi;
        }

        private void btEkle_Click(object sender, EventArgs e)
        {
            EKitap kitapItem = new EKitap();
            kitapItem.Kategoriİd = Convert.ToInt32(cbKategori.SelectedValue);
            kitapItem.SayfaSayisi = Convert.ToInt16(txtSayfaS.Text);
            kitapItem.Adi = txtAdi.Text;
            kitapItem.Yazar = txtYazar.Text;
            if (BLLKitap.İnsert(kitapItem) > 0)
            {
                kitapListele();
                 
                    MessageBox.Show("Kitap ekleme işlemi başarılı!!");
                txtAdi.ResetText();
                txtYazar.ResetText();
                txtSayfaS.ResetText();
                txtID.ResetText();

            }
            else
            {
                MessageBox.Show("Kitap eklerken bir hata meydana geldi lütfen destek talep ediniz.Hata kodu : #98565");
            }
        }

   
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //gridview secili satirdaki degerleri textbox aktariyoruz.
          //  txtID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAdi.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSayfaS.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbKategori.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtYazar.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {    cbKategori.DisplayMember = "Adı";
            cbKategori.ValueMember = "Id";

        }

        private void btSil_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {
                EKitap kitapItem = new EKitap();
                kitapItem.ID = Convert.ToInt32(txtID.Text);
                kitapItem.Kategoriİd = Convert.ToInt32(cbKategori.SelectedValue);
                kitapItem.SayfaSayisi = Convert.ToInt16(txtSayfaS.Text);
                kitapItem.Adi = txtAdi.Text;
                kitapItem.Yazar = txtYazar.Text;

                if (BLLKitap.Delete(kitapItem.ID) == true)
                {

                    kitapListele();

                    MessageBox.Show("Kitap basarıyla silindi!!");
                    txtAdi.ResetText();
                    txtYazar.ResetText();
                    txtSayfaS.ResetText();
                    txtID.ResetText();

                }
                else
                {
                    MessageBox.Show("Kitap silmede bir hata meydana geldi lütfen destek talep ediniz.Hata kodu : #98565");
                }
            }

        }

     

        private void btguncelle_Click(object sender, EventArgs e)
        {
            EKitap kitapItem = new EKitap();
            kitapItem.ID = Convert.ToInt32(txtID.Text);
            kitapItem.Kategoriİd = Convert.ToInt32(cbKategori.SelectedValue);
            kitapItem.SayfaSayisi = Convert.ToInt16(txtSayfaS.Text);
            kitapItem.Adi = txtAdi.Text;
            kitapItem.Yazar = txtYazar.Text;
            if (BLLKitap.Update(kitapItem)== true)
            {
                kitapListele();

                MessageBox.Show("Kitap bilgileri guncellestirildi!!");
                txtAdi.ResetText();
                txtYazar.ResetText();
                txtSayfaS.ResetText();
                 txtID.ResetText();

            }
            else
            {
                MessageBox.Show("Kitap guncellestirirken bir hata meydana geldi lütfen destek talep ediniz.Hata kodu : #98565");
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
          
            ////gridview secili satirdaki degerleri textbox aktariyoruz.
           txtID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtSayfaS.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            cbKategori.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtYazar.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();




        }

        private void btYeni_Click(object sender, EventArgs e)
        {
            txtAdi.ResetText();
            txtYazar.ResetText();
            txtSayfaS.ResetText();
            txtID.ResetText();

        }
    }
}
