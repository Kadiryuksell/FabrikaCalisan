using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaCalisan
{
    public class Fabrika
    {
        private string fabrikaAd = "ASEKAN";
              
        private List<Isci> calisanlar = new List<Isci>();
        
        public void CalisanEkle(Isci isci)
        {
            calisanlar.Add(isci);
        }
        public string CalisanlariListele()
        {
            string temp = "";
            foreach (Isci calis in calisanlar)
            {
                temp += "\nFabrika Adı: "+ fabrikaAd + "\nAd: " + calis.Kimlik.Ad + "\nSoyad: " + calis.Kimlik.Soyad + "\nTC No: " 
                    + calis.Kimlik.TCKimlikNo.ToString()
                    + " \nDoğum Yeri: " + calis.Kimlik.DogumYeri+"\nDoğum tarihi: " + calis.Kimlik.Dogumtarihi.ToLongDateString() 
                    + "\nMaas: " + calis.Maas.ToString();
            }
            return temp;
        }

    }
}
