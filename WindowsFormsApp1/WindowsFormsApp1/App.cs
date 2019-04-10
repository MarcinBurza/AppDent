using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class  caredent : Form
    {
        public caredent()
        {
            InitializeComponent();

        }
        //wyświetlanie daty i godziny
        private void Form1_Load(object sender, EventArgs e)
        {
            timedate.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
           
        }

      //przycisk do otwierania nowej karty dodaj pacjenta 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(add.Instance))
            {
               panel.Controls.Add(add.Instance);
                add.Instance.Dock = DockStyle.Fill;
                add.Instance.BringToFront();

            }
            else
            {
                add.Instance.BringToFront();
            }
        }
        //przycisk otwórz kartę  pacjęnta 

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(Card.Instance))
            {
                panel.Controls.Add(Card.Instance);
                Card.Instance.Dock = DockStyle.Fill;
                Card.Instance.BringToFront();

            }
            else
            {
                Card.Instance.BringToFront();
            }
        }
        //przycisk  wyszukaj pacjenta 

        private void btnSerach_Click(object sender, EventArgs e)
        { 
            if (!panel.Controls.Contains(Serach.Instance))
            {
                panel.Controls.Add(Serach.Instance);
                Serach.Instance.Dock = DockStyle.Fill;
                Serach.Instance.BringToFront();

            }
            else
            {
                Serach.Instance.BringToFront();
            }
        }
        //przycisk do zamykania aplikacji

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
