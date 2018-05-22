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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            this.Hide();
        }

        // Kaydet butonu fonksiyonu
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Eğer herhangi bir bilgi boş bırakılmış ise uyarı mesajı gösterilecek.
            if (string.IsNullOrEmpty(txtName.Text) ||
               string.IsNullOrEmpty(txtSurname.Text) ||
               string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
            }
            // Boş değil ise dosyaya yazdıracak.
            else
            {
                StreamWriter dosya = File.AppendText("veriler.txt");
                dosya.Write(txtName.Text + " ");
                dosya.Write(txtSurname.Text + " ");
                dosya.WriteLine(txtPhoneNumber.Text);
                dosya.Close();

                //Yazdırdıktan sonra dosyayı kapatıcak ve tüm textboxları temizleyecek.
                foreach (Control nesne in this.Controls)
                {
                    if (nesne is TextBox)
                        (nesne as TextBox).Clear();
                }

                //Temizledikten sonra İsim kısmına odaklanıcak. Yazdırdıktan başarılı olduğunun bilgisini vericek.
                txtName.Focus();
                MessageBox.Show("Kayıt Başarılı.");
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Eğer girilen rakam ise rakam girilmeyecek.
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Eğer girilen rakam ise rakam girilmeyecek.
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Eğer girilen space tuşu ise girilmeyecek.
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control nesne in this.Controls)
            {
                if (nesne is TextBox)
                    (nesne as TextBox).Clear();
            }
        }

        private void AddContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım aşamasında...");
        }
    }
}
