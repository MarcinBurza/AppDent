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
    public partial class Serach : UserControl
    {        
        //łaczenie sie z bazą danych
        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //łaczene sie z User control wyszukaj pacjenta
        private static Serach _instance;
        public static Serach Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Serach();
                return _instance;
            }
        }
        public Serach()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, EventArgs e)
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

       

        private void txtgrid_checkuppatient_search_TextChanged(object sender, EventArgs e)
        {
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
        }

        private void grid_patient_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {

                        DataGridViewRow row = this.grid_patient.Rows[e.RowIndex];

                        lblid.Text = row.Cells["PatientID"].Value.ToString();
                        lblname.Text = row.Cells["ImieNazwisko"].Value.ToString();
                        lblphone.Text = row.Cells["Numer"].Value.ToString();
                        lblgender.Text = row.Cells["Plec"].Value.ToString();
                        lblDataurodzenia.Text = DateTime.Parse(row.Cells["Dataurodzenia"].Value.ToString()).ToSho‌​rtDateStrin‌​g();
                        lbladdress.Text = row.Cells["Adres"].Value.ToString();
                        lblppesel.Text = row.Cells["Pesel"].Value.ToString();
                        lblkod.Text = row.Cells["Kodpocztowy"].Value.ToString();
                        lblmiejsce.Text = row.Cells["Praca"].Value.ToString();
                        lbldocktor.Text = row.Cells["Lekarz"].Value.ToString();
                        lblblona.Text = row.Cells["Blonasluzowa"].Value.ToString();
                        lblprzyzembie.Text = row.Cells["Przyzebie"].Value.ToString();
                        lblhigiena.Text = row.Cells["Higiena"].Value.ToString();
                        lblinfo.Text = row.Cells["Info"].Value.ToString();
                        lblwada.Text = row.Cells["Wadazgryzu"].Value.ToString();
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

        }

        private void butzamknij_Click(object sender, EventArgs e)
            {

                pnlgrid1.Hide();

            }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Bitmap bm = new Bitmap(this.panel1.Width, this.panel1.Height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));

            e.Graphics.DrawImage(bm ,0, 0);
        }
       

        private void btnprintpreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
            
          
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        
    }
}
