using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Dosyaya yazı yazmak için gerekli olan kütüphane
using System.IO;

namespace Telefon_Rehberi
{
    public partial class ListContactForm : Form
    {
        private int kalinlik = 1;
        private string satir;

        public ListContactForm()
        {
            InitializeComponent();
            StreamReader SR = new StreamReader("veriler.txt");

            //Dosyanın sonuna kadar okunması için döngüye giriyor.
            while ((satir = SR.ReadLine()) != null)
            {
                string renk1;
                string renk2;
                string renk3;
                string[] kelime = satir.Split(' ');
                // Her seferinde satırı artırıyor çünkü kalınlık 2n+2 şeklinde ilerliyor 
                // Not : İlk satır kalın olmalı. Onun dışında n = 0 --> 2 , n = 2 --> 4 , vb gibi...
                kalinlik++;

                // Burada yapılan işlem ilk kelimenin her harfini birer değişkene atamak ve o değişkende tutmak.
                renk1 = kelime[0].Substring(0, 1);
                renk2 = kelime[0].Substring(1, 1);
                renk3 = kelime[0].Substring(2, 1);
                
                //Eğer kalinlik isimli değişkenin bölümünden kalan 0 ise cümleyi kalın yap değil ise eski haline getir.
                rchtxtReadFile.SelectionFont = (kalinlik % 2 == 0 ? new Font(rchtxtReadFile.Font, FontStyle.Bold) : rchtxtReadFile.Font);
                
                //Eğer isim yani renk1 değişkeni k ise Kırmızı m ise Maviye değil ise Yeşil olsun.
                rchtxtReadFile.SelectionColor = (renk1 == "k" ? Color.Red : (renk1 == "m" ? Color.Blue : Color.Green));
                rchtxtReadFile.AppendText(kelime[1] + " ");

                //Eğer soyisim yani renk2 değişkeni k ise Kırmızı m ise Maviye değil ise Yeşil olsun.
                rchtxtReadFile.SelectionColor = (renk2 == "k" ? Color.Red : (renk2 == "m" ? Color.Blue : Color.Green));
                rchtxtReadFile.AppendText(kelime[2] + " ");

                //Eğer numara yani renk3 değişkeni k ise Kırmızı m ise Maviye değil ise Yeşil olsun.
                rchtxtReadFile.SelectionColor = (renk3 == "k" ? Color.Red : (renk3 == "m" ? Color.Blue : Color.Green));
                rchtxtReadFile.AppendText(kelime[3] + "\n");
            }
            //Dosya kapatma işlemi uygulanıyor.
            SR.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            this.Hide();
        }

        private void ListContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}