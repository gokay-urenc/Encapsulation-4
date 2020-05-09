using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // İlk soru
        {
            Ogrenci ogr = new Ogrenci();
            ogr.ad = "Negan";
            ogr.soyad = "Lucille";
            ogr.cinsiyet = 'E';
            ogr.Yas = 16;
            MessageBox.Show(ogr.ad + " " + ogr.soyad + " " + ogr.cinsiyet + " " + ogr.Yas);
        }

        private void button2_Click(object sender, EventArgs e) // İkinci soru
        {
            Kisi k = new Kisi();
            k.adi = "Negan";
            k.soyadi = "Lucille";
            k.Yas = 21;
            k.veli = null;

            Kisi k1 = new Kisi();
            k1.adi = "Carl";
            k1.soyadi = "Grimes";
            k1.veli = "Rick";
            k1.Yas = 13;

            Kisi[] kisiler = new Kisi[2];
            kisiler[0] = k;
            kisiler[1] = k1;
            dataGridView1.DataSource = kisiler;
        }
    }
}
// Öğrenci adında bir class açarak öğrencinin adını, soyadını, yaşını ve cinsiyetini tutan    özellikleri tanımlayınız. Eğer öğrenci yaşı 18'den küçükse yaş 18 gösterilmeli. Değilse    yaş atanan değer gösterilmeli. Bunu property içinde yapınız.


// Kişi yaşı 18'den küçükse kişinin adı Veli olarak gözüksün. Yaş 18'e eşit veya büyükse kişi
// adı kendi adı gözükebilir.


// OOP Prensipleri:
// * Encapsulation (Kapsülleme)
// * Inheritance (Miras Verme)
// * Abstraction (Soyutlama)
// * Polymorphism (Çok Biçimlilik)

// OOP'nin Faydaları:
// Genişletilebilirlik
// Sürdürülebilirlik
// Okunabilirlik
// Tek yerden yönetilebilirlik