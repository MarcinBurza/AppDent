using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }
        //przycisk logowania
        private void Zaloguj_Click(object sender, EventArgs e)
        {
            //funkcja która sprawdza poprawność nazwy uytkowinka i hasła
            try
            {
                if (txtusername.Text.Length == 0 || txtpassword.Text.Length == 0)
                {
                    lblerror.Text = "Jedno pole jest puste";
                }
                else if (txtusername.Text != "admin" )
                {
                    lblerror.Text = "Niepoprawny login! ";
                }
                else if (txtpassword.Text != "admin")
                {
                    lblerror.Text = "Niepoprawn hasło!";
                }
                else
                {
                    //ukryj ekran logowania
                    this.Hide();

                    // pokaz kolejne okno
                    caredent home = new caredent();
                    home.ShowDialog();
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show("Bład" + ex.Message);
            }
        }
    }
}
