using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaCalisan
{
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Fabrika fabrika = new Fabrika();
           

            KimlikBilgisi kimlik = new KimlikBilgisi
            {
                Ad = mkdtAd.Text,
                Soyad = mkdtSoyad.Text,
                TCKimlikNo = (ulong)Convert.ToInt64(mkdtTCNo.Text),
                DogumYeri = mkdtDogumYeri.Text,
                Dogumtarihi=Convert.ToDateTime(mkdtDogumTarihi.Text)
            };
            Isci ısci = new Isci
            {
                Kimlik = kimlik             
            };
            fabrika.CalisanEkle(ısci);
            MessageBox.Show(fabrika.CalisanlariListele());
          


        }

        private void frmPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
