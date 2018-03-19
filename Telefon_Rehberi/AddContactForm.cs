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

        private string renkName;
        private string renkSurname;
        private string renkNumber;

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
               string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                (!(rdNameRed.Checked) && !(rdNameBlue.Checked) && !(rdNameGreen.Checked)) ||
                (!(rdSurnameRed.Checked) && !(rdSurnameBlue.Checked) && !(rdSurnameGreen.Checked)) ||
                (!(rdPhoneNumberRed.Checked) && !(rdPhoneNumberBlue.Checked) && !(rdPhoneNumberGreen.Checked)))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
            }
            // Boş değil ise dosyaya yazdıracak.
            else
            {
                StreamWriter dosya = File.AppendText("veriler.txt");
                dosya.Write(renkName);
                dosya.Write(renkSurname);
                dosya.Write(renkNumber + " ");
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
            //Eğer girilen space tuşu ise girilmeyecek.
            if (e.KeyChar == (char)Keys.Space)
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

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Eğer girilen harf ise harf basılmayacak Backspace tuşu dışında.
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
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

        private void rdNameRed_CheckedChanged(object sender, EventArgs e)
        {
            renkName = "k";
        }

        private void rdNameBlue_CheckedChanged(object sender, EventArgs e)
        {
            renkName = "m";
        }

        private void rdNameGreen_CheckedChanged(object sender, EventArgs e)
        {
            renkName = "y";
        }

        private void rdSurnameRed_CheckedChanged(object sender, EventArgs e)
        {
            renkSurname = "k";
        }

        private void rdSurnameBlue_CheckedChanged(object sender, EventArgs e)
        {
            renkSurname = "m";
        }

        private void rdSurnameGreen_CheckedChanged(object sender, EventArgs e)
        {
            renkSurname = "y";
        }

        private void rdPhoneNumberRed_CheckedChanged(object sender, EventArgs e)
        {
            renkNumber = "k";
        }

        private void rdPhoneNumberBlue_CheckedChanged(object sender, EventArgs e)
        {
            renkNumber = "m";
        }

        private void rdPhoneNumberGreen_CheckedChanged(object sender, EventArgs e)
        {
            renkNumber = "y";
        }

        private void AddContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
