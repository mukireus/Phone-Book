using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click_1(object sender, EventArgs e)
        {
            AddContactForm openForm = new AddContactForm();
            openForm.Show();
            this.Hide();
        }

        private void btnListContact_Click(object sender, EventArgs e)
        {
            ListContactForm openForm = new ListContactForm();
            openForm.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon Rehberi" + "\n" + "Bu uygulama Muhammet ÖMER tarafından yapılmıştır." + "\n" + "Versiyon: 2.0");
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            //DeleteContactForm openForm = new DeleteContactForm();
            //openForm.Show();
            //this.Hide();
            MessageBox.Show("Yapım Aşamasındadır." + "\n" + "En kısa zamanda yeni versiyon ile kullanılabilir olacaktır.");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
