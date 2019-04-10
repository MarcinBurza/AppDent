 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    public partial class add : UserControl
    {
        //łaczenie sie z bazą danych
        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //łaczene sie z User control dodaj pacjenta
        private static add _instance;
        public static add Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new add();
                return _instance;
            }
        }
        public add()
        {
            InitializeComponent();
        }
        //sprawdzanie poprawności wpisywanych danych
        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtpesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }


        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
       
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) // Select All
            {
                ((TextBox)sender).SelectAll();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        //metoda sprawdzajaca poprawnosc adressu mail
        private bool IsValidEmail(string email)
        {
            var r = new Regex(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
            return !string.IsNullOrEmpty(email) && r.IsMatch(email);
        }
        //przycisk do zapisywania danych do bazy danych
           private void btnsave_Click(object sender, EventArgs e)
             {
              try
               {
                //pęta która sprawdza poprawnosc danych i czy wszystkie dane zostały wpisane 
                if (txtname.Text.Length == 0 || txtpesel.Text.Length == 0 || txtphone.Text.Length == 0 || birthday.Text.Length == 0)
                {
                    lblerror.Text = "Uzupełnij dane";
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    lblerror.Text = "Wybierz płeć";
                }
                else if (txtemail.Text.Length != 0)
                {
                    if (IsValidEmail(txtemail.Text) == false)
                    {
                        lblerror.Text = "Niepoprawy mail";
                    }
                    else
                        PatientData();
                }
                else
                {
                    PatientData();
                }
               }
              catch (Exception ex)
               {
                MessageBox.Show("Failed to save record: " + ex.Message);
               }
             }
        //
       
        //metoda dodawania do bazy danych
        private void PatientData()
        {
            try
            {
                string query = "INSERT INTO PatientInfo (ImieNazwisko, Pesel, Numer, Email, Plec, Dataurodzenia, Adres ,Kodpocztowy) " +
                       "VALUES ( @ImieNazwisko,@Pesel, @Numer, @Email, @Plec, @Dataurodzenia, @Adres,@Kodpocztowy) ";

                // tworzenie połaczenia i komend
                using (SqlConnection cn = new SqlConnection(constr))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.AddWithValue("@ImieNazwisko", txtname.Text);
                    cmd.Parameters.AddWithValue("@Pesel", txtpesel.Text);
                    cmd.Parameters.AddWithValue("@Numer", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    if (radioButton1.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Plec", "Mężczyzna");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Plec", "Kobieta");
                    }
                    cmd.Parameters.AddWithValue("@Dataurodzenia", birthday.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Adres", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@Kodpocztowy", txtkod.Text);

                    
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                 
                    lblerror.Text = null;
                    txtname.Text = null;
                    txtpesel.Text = null;
                    txtaddress.Text = null;
                    txtkod.Text = null;
                    txtemail.Text = null;
                    txtphone.Text = null;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    birthday.Value = DateTime.Now;
                    MessageBox.Show("Pacjent dodany!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }
        //przycisk który anuluje wpisane pola
        private void btncancel_Click(object sender, EventArgs e)
        {

            txtname.Text = null;
            txtaddress.Text = null;
            txtkod.Text = null;
            txtpesel.Text = null;
            txtemail.Text = null;
            txtphone.Text = null;
            lblerror.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            birthday.Value = DateTime.Now;

        }


    }
}
