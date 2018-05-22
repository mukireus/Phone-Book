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
                string[] kelime = satir.Split(' ');
                // Her seferinde satırı artırıyor çünkü kalınlık 2n+2 şeklinde ilerliyor 
                // Not : İlk satır kalın olmalı. Onun dışında n = 0 --> 2 , n = 2 --> 4 , vb gibi...
                kalinlik++;
                
                //Eğer kalinlik isimli değişkenin bölümünden kalan 0 ise cümleyi kalın yap değil ise eski haline getir.
                rchtxtReadFile.SelectionFont = (kalinlik % 2 == 0 ? new Font(rchtxtReadFile.Font, FontStyle.Bold) : rchtxtReadFile.Font);
                rchtxtReadFile.SelectionColor = Color.White;
                for (int i = 0; i < 5; i++)
                    rchtxtReadFile.AppendText(kelime[i] + " ");
                rchtxtReadFile.AppendText(kelime[5] + "\n");

            }
            //Dosya kapatma işlemi uygulanıyor.
            SR.Close();
        }

        private void ListContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            this.Hide();
        }

        private void txtBoxSearch_Click(object sender, EventArgs e)
        {
            txtBoxSearch.ForeColor = Color.Black;
            txtBoxSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int start = 0;
            int end = rchtxtReadFile.Text.LastIndexOf(txtBoxSearch.Text);
            rchtxtReadFile.SelectAll();
            rchtxtReadFile.SelectionBackColor = Color.FromArgb(70, 40, 66);
            while (start < end)
            {
                rchtxtReadFile.Find(txtBoxSearch.Text, start, rchtxtReadFile.TextLength, RichTextBoxFinds.MatchCase);
                rchtxtReadFile.SelectionBackColor = Color.Red;
                start = rchtxtReadFile.Text.IndexOf(txtBoxSearch.Text, start) + 1;
            }
        }
    }
}