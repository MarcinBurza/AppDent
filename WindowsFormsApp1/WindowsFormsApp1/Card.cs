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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Card : UserControl
    {       
        //łaczenie sie z bazą danych
        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //łaczene sie z User control kartą pacjenta
        private static Card _instance;
        public static Card Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Card();
                return _instance;
            }
        }
        public Card()
        {
            InitializeComponent();
        }

        //przycisk łaczenia z baza danych i wyświetlania danych
        private void btncheckup_selectpatient_Click(object sender, EventArgs e)
        {

            { 
                pnlgrid1.Visible = true;
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("select * from PatientInfo", con))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                grid_patient.DataSource = dt;
                                grid_patient.Columns["PatientID"].Visible = false;
                                grid_patient.Columns["Praca"].Visible = false;
                                grid_patient.Columns["Blonasluzowa"].Visible = false;
                                grid_patient.Columns["Kodpocztowy"].Visible = false;
                                grid_patient.Columns["Przyzebie"].Visible = false;
                                grid_patient.Columns["Higiena"].Visible = false;
                                grid_patient.Columns["Info"].Visible = false;
                                grid_patient.Columns["Wadazgryzu"].Visible = false;
                                grid_patient.Columns["Datawizyty"].Visible = false;
                                grid_patient.Columns["Lekarz"].Visible = false;
                                grid_patient.Columns["Nrzeba"].Visible = false;
                                grid_patient.Columns["Rozpoznanie"].Visible = false;
                                grid_patient.Columns["Zabiegi"].Visible = false;
                                grid_patient.Columns["Symbolprocedury"].Visible = false;
                                con.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured: " + ex.Message);
                }
            }
        }
        //Wybranie pacjenta i wyświetlenia go na karcie pacjenta
        private void grid_checkup_patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    
                    btnsave.Enabled = true;
                    DataGridViewRow row = this.grid_patient.Rows[e.RowIndex];

                    lblid.Text = row.Cells["PatientID"].Value.ToString();
                    lblname.Text = row.Cells["ImieNazwisko"].Value.ToString();
                    lblphone.Text = row.Cells["Numer"].Value.ToString();
                    lblgender.Text = row.Cells["Plec"].Value.ToString();
                    lblDataurodzenia.Text = DateTime.Parse(row.Cells["Dataurodzenia"].Value.ToString()).ToSho‌​rtDateStrin‌​g();
                    lbladdress.Text = row.Cells["Adres"].Value.ToString();
                    lblppesel.Text = row.Cells["Pesel"].Value.ToString();
                    lblkod.Text = row.Cells["Kodpocztowy"].Value.ToString();
                    txtMiejscepracy.Text = row.Cells["Praca"].Value.ToString();
                    txtdoctor.Text = row.Cells["Lekarz"].Value.ToString();
                    txtblona.Text = row.Cells["Blonasluzowa"].Value.ToString();
                    txtprzyzebie.Text = row.Cells["Przyzebie"].Value.ToString();
                    txthigiena.Text = row.Cells["Higiena"].Value.ToString();
                    txtinfo.Text = row.Cells["Info"].Value.ToString();
                    txtwada.Text = row.Cells["Wadazgryzu"].Value.ToString();
                    txtdatawizyty.Text = row.Cells["Datawizyty"].Value.ToString();
                    txtnumerzeba.Text = row.Cells["Nrzeba"].Value.ToString();
                    txtrozpoznanie.Text = row.Cells["Rozpoznanie"].Value.ToString();
                    txtzabiegi.Text = row.Cells["Zabiegi"].Value.ToString();
                    txtsymbol.Text = row.Cells["Symbolprocedury"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }
       
        //wyswietlanie bazy w polu grid
        private void txtgrid_checkuppatient_search_TextChanged(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select PatientID,ImieNazwisko,Pesel,Numer,Email,Plec,Dataurodzenia,Adres from PatientInfo where ImieNazwisko like '" + txtgrid_checkuppatient_search.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                grid_patient.DataSource = dt;
                grid_patient.Columns["PatientID"].Visible = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }


        }

        //Zapisywanie danych z karty pacjenta
        private void btnsave_patientfindings_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMiejscepracy.Text.Length != 0 && txtdoctor.Text.Length != 0 && txtblona.Text.Length != 0 
                    && txtprzyzebie.Text.Length != 0 && txthigiena.Text.Length != 0 && txtinfo.Text.Length != 0
                    && txtwada.Text.Length != 0 && txtdatawizyty.Text.Length != 0 && txtnumerzeba.Text.Length != 0 
                    && txtrozpoznanie.Text.Length != 0 && txtzabiegi.Text.Length != 0 && txtsymbol.Text.Length != 0)
                {
                    string query = "UPDATE PatientInfo SET Praca='" + txtMiejscepracy.Text + "', Lekarz='" + txtdoctor.Text + "', " +
                        "Blonasluzowa='" + txtblona.Text + "'," +" Przyzebie='" + txtprzyzebie.Text + "'," + " Datawizyty='" + txtdatawizyty.Text + "'," +
                        "" + " Nrzeba='" + txtnumerzeba.Text + "'," + " Rozpoznanie='" + txtrozpoznanie.Text + "'," + " Zabiegi='" + txtzabiegi.Text + "'," +
                        "" + " Symbolprocedury='" + txtsymbol.Text + "', Higiena='" + txthigiena.Text + "'," +
                        " Info='" + txtinfo.Text + "', Wadazgryzu='" + txtwada.Text + "'" + "WHERE PatientID='" + lblid.Text + "'";


                    // tworzenia połaczenia i komendy
                    using (SqlConnection cn = new SqlConnection(constr))
                    using (SqlCommand cmd = new SqlCommand(query, cn))

                    {

                        // otwórz połaczenie , zamknij połaczenie
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Zapisano!");
                    }
                }
                else
                {
                    MessageBox.Show("Wpisz wszystkie pola");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }


        }
       
        //przycisk ukryj panel z pacjentami
        private void butzamknij_Click(object sender, EventArgs e)
        {
            
                pnlgrid1.Hide();
            
        }
        //przycisk usunięcia pacjenta z bazy danych
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Jestes pewnien ,że chcesz usunąć?", "Potwierdz usunięcie", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        
                        using (SqlCommand command = new SqlCommand("DELETE FROM PatientInfo WHERE PatientID = @PatientID", con))
                        {
                            command.Parameters.AddWithValue("@PatientID", lblid.Text);
                            int rows = command.ExecuteNonQuery();

                        }
                        con.Close();


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: {0}", ex.Message);
            }
        }
        //przycisk Odswieżania bazy danych
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            pnlgrid1.Visible = true;
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("select * from PatientInfo", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            grid_patient.DataSource = dt;
                            grid_patient.Columns["PatientID"].Visible = false;
                                        con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
}
        }


        //link do strony gdzie mozna sprawdzic czy pacjent jest ubezpieczony
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Process.Start("https://ewus.nfz.gov.pl/ap-ewus/");

        }
    }
 }


