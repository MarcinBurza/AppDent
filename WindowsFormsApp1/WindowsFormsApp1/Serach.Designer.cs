namespace WindowsFormsApp1
{
    partial class Serach
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serach));
            this.btnselect = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnprintpreview = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbldocktor = new System.Windows.Forms.Label();
            this.lblmiejsce = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblppesel = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblkod = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblDataurodzenia = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdatawizyty = new System.Windows.Forms.TextBox();
            this.txtnumerzeba = new System.Windows.Forms.TextBox();
            this.txtrozpoznanie = new System.Windows.Forms.TextBox();
            this.txtzabiegi = new System.Windows.Forms.TextBox();
            this.txtsymbol = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblblona = new System.Windows.Forms.Label();
            this.lblprzyzembie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblhigiena = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblwada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlgrid1 = new System.Windows.Forms.Panel();
            this.butzamknij = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.txtgrid_checkuppatient_search = new System.Windows.Forms.TextBox();
            this.grid_patient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlgrid1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnselect.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(3, 9);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(110, 43);
            this.btnselect.TabIndex = 64;
            this.btnselect.Text = "Wyszukaj pacjenta";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(645, 1164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 152;
            this.label13.Text = "Podpis pieczątka";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(550, 1180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 151;
            this.pictureBox2.TabStop = false;
            // 
            // btnprintpreview
            // 
            this.btnprintpreview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprintpreview.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintpreview.Location = new System.Drawing.Point(122, 9);
            this.btnprintpreview.Name = "btnprintpreview";
            this.btnprintpreview.Size = new System.Drawing.Size(110, 43);
            this.btnprintpreview.TabIndex = 183;
            this.btnprintpreview.Text = "Podglad";
            this.btnprintpreview.UseVisualStyleBackColor = false;
            this.btnprintpreview.Click += new System.EventHandler(this.btnprintpreview_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(238, 9);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(110, 43);
            this.btnprint.TabIndex = 185;
            this.btnprint.Text = "Drukuj";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbldocktor, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblmiejsce, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label36, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label39, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label44, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label41, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label42, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblid, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblppesel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblphone, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbladdress, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblkod, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblgender, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblDataurodzenia, 1, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(202, 224);
            this.tableLayoutPanel2.TabIndex = 148;
            // 
            // lbldocktor
            // 
            this.lbldocktor.AutoSize = true;
            this.lbldocktor.Location = new System.Drawing.Point(104, 194);
            this.lbldocktor.Name = "lbldocktor";
            this.lbldocktor.Size = new System.Drawing.Size(0, 13);
            this.lbldocktor.TabIndex = 175;
            // 
            // lblmiejsce
            // 
            this.lblmiejsce.AutoSize = true;
            this.lblmiejsce.Location = new System.Drawing.Point(104, 174);
            this.lblmiejsce.Name = "lblmiejsce";
            this.lblmiejsce.Size = new System.Drawing.Size(0, 13);
            this.lblmiejsce.TabIndex = 174;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 173;
            this.label6.Text = "Lekarz prowadzący";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nr karty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 172;
            this.label5.Text = "Miejsce pracy";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(3, 20);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(40, 14);
            this.label36.TabIndex = 84;
            this.label36.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 100;
            this.label2.Text = "Pesel";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(3, 64);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(68, 14);
            this.label39.TabIndex = 86;
            this.label39.Text = "Nr telefonu";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(3, 86);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(38, 14);
            this.label44.TabIndex = 91;
            this.label44.Text = "Adres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 14);
            this.label12.TabIndex = 128;
            this.label12.Text = "Kod pocztowy";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(3, 130);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 14);
            this.label41.TabIndex = 88;
            this.label41.Text = "Płec";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(3, 152);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(89, 14);
            this.label42.TabIndex = 89;
            this.label42.Text = "Data urodzenia";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(104, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 14);
            this.lblid.TabIndex = 55;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(104, 20);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 14);
            this.lblname.TabIndex = 93;
            // 
            // lblppesel
            // 
            this.lblppesel.AutoSize = true;
            this.lblppesel.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblppesel.Location = new System.Drawing.Point(104, 42);
            this.lblppesel.Name = "lblppesel";
            this.lblppesel.Size = new System.Drawing.Size(0, 14);
            this.lblppesel.TabIndex = 101;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(104, 64);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(0, 14);
            this.lblphone.TabIndex = 95;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(104, 86);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(0, 14);
            this.lbladdress.TabIndex = 99;
            // 
            // lblkod
            // 
            this.lblkod.AutoSize = true;
            this.lblkod.Location = new System.Drawing.Point(104, 108);
            this.lblkod.Name = "lblkod";
            this.lblkod.Size = new System.Drawing.Size(0, 13);
            this.lblkod.TabIndex = 132;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(104, 130);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(0, 14);
            this.lblgender.TabIndex = 97;
            // 
            // lblDataurodzenia
            // 
            this.lblDataurodzenia.AutoSize = true;
            this.lblDataurodzenia.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataurodzenia.Location = new System.Drawing.Point(104, 152);
            this.lblDataurodzenia.Name = "lblDataurodzenia";
            this.lblDataurodzenia.Size = new System.Drawing.Size(0, 14);
            this.lblDataurodzenia.TabIndex = 98;
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(279, 130);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 158;
            this.Data.Text = "Data";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 159;
            this.label15.Text = "Ząb";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(408, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 160;
            this.label16.Text = "Rozpoznanie";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(479, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(221, 13);
            this.label17.TabIndex = 161;
            this.label17.Text = "Zabiegi,leki,zalecenia,skierowania do poradni";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(706, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 162;
            this.label18.Text = "Symbol procedury";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(489, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 13);
            this.label14.TabIndex = 163;
            this.label14.Text = "specjalistycznych,niezdoloność do pracy*";
            // 
            // txtdatawizyty
            // 
            this.txtdatawizyty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdatawizyty.Location = new System.Drawing.Point(261, 146);
            this.txtdatawizyty.Multiline = true;
            this.txtdatawizyty.Name = "txtdatawizyty";
            this.txtdatawizyty.Size = new System.Drawing.Size(78, 340);
            this.txtdatawizyty.TabIndex = 165;
            // 
            // txtnumerzeba
            // 
            this.txtnumerzeba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnumerzeba.Location = new System.Drawing.Point(324, 146);
            this.txtnumerzeba.Multiline = true;
            this.txtnumerzeba.Name = "txtnumerzeba";
            this.txtnumerzeba.Size = new System.Drawing.Size(76, 340);
            this.txtnumerzeba.TabIndex = 166;
            // 
            // txtrozpoznanie
            // 
            this.txtrozpoznanie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrozpoznanie.Location = new System.Drawing.Point(387, 146);
            this.txtrozpoznanie.Multiline = true;
            this.txtrozpoznanie.Name = "txtrozpoznanie";
            this.txtrozpoznanie.Size = new System.Drawing.Size(108, 340);
            this.txtrozpoznanie.TabIndex = 167;
            // 
            // txtzabiegi
            // 
            this.txtzabiegi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtzabiegi.Location = new System.Drawing.Point(482, 146);
            this.txtzabiegi.Multiline = true;
            this.txtzabiegi.Name = "txtzabiegi";
            this.txtzabiegi.Size = new System.Drawing.Size(232, 340);
            this.txtzabiegi.TabIndex = 168;
            // 
            // txtsymbol
            // 
            this.txtsymbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsymbol.Location = new System.Drawing.Point(699, 146);
            this.txtsymbol.Multiline = true;
            this.txtsymbol.Name = "txtsymbol";
            this.txtsymbol.Size = new System.Drawing.Size(112, 340);
            this.txtsymbol.TabIndex = 169;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(553, 505);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 170;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 171;
            this.label3.Text = "Podpis pieczątka";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(45, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 20);
            this.label19.TabIndex = 172;
            this.label19.Text = "Stan jamy ustnej";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 14);
            this.label7.TabIndex = 173;
            this.label7.Text = "Błona śluzowa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 174;
            this.label8.Text = "Przyzebie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 175;
            this.label9.Text = "Informacje ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 14);
            this.label10.TabIndex = 176;
            this.label10.Text = "Higiena";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 177;
            this.label11.Text = "Wada zgryzu";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 421);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 176;
            this.label20.Text = "uzupełniające";
            // 
            // lblblona
            // 
            this.lblblona.AutoSize = true;
            this.lblblona.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblona.Location = new System.Drawing.Point(117, 320);
            this.lblblona.Name = "lblblona";
            this.lblblona.Size = new System.Drawing.Size(0, 14);
            this.lblblona.TabIndex = 178;
            // 
            // lblprzyzembie
            // 
            this.lblprzyzembie.AutoSize = true;
            this.lblprzyzembie.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprzyzembie.Location = new System.Drawing.Point(117, 347);
            this.lblprzyzembie.Name = "lblprzyzembie";
            this.lblprzyzembie.Size = new System.Drawing.Size(0, 14);
            this.lblprzyzembie.TabIndex = 179;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(273, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 77);
            this.pictureBox3.TabIndex = 164;
            this.pictureBox3.TabStop = false;
            // 
            // lblhigiena
            // 
            this.lblhigiena.AutoSize = true;
            this.lblhigiena.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhigiena.Location = new System.Drawing.Point(117, 378);
            this.lblhigiena.Name = "lblhigiena";
            this.lblhigiena.Size = new System.Drawing.Size(0, 14);
            this.lblhigiena.TabIndex = 180;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(117, 407);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 14);
            this.lblinfo.TabIndex = 181;
            // 
            // lblwada
            // 
            this.lblwada.AutoSize = true;
            this.lblwada.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwada.Location = new System.Drawing.Point(117, 448);
            this.lblwada.Name = "lblwada";
            this.lblwada.Size = new System.Drawing.Size(0, 14);
            this.lblwada.TabIndex = 182;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblwada);
            this.panel1.Controls.Add(this.lblinfo);
            this.panel1.Controls.Add(this.lblhigiena);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblprzyzembie);
            this.panel1.Controls.Add(this.lblblona);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.txtsymbol);
            this.panel1.Controls.Add(this.txtzabiegi);
            this.panel1.Controls.Add(this.txtrozpoznanie);
            this.panel1.Controls.Add(this.txtnumerzeba);
            this.panel1.Controls.Add(this.txtdatawizyty);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(17, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 618);
            this.panel1.TabIndex = 184;
            // 
            // pnlgrid1
            // 
            this.pnlgrid1.AutoSize = true;
            this.pnlgrid1.BackColor = System.Drawing.Color.Transparent;
            this.pnlgrid1.Controls.Add(this.butzamknij);
            this.pnlgrid1.Controls.Add(this.label48);
            this.pnlgrid1.Controls.Add(this.txtgrid_checkuppatient_search);
            this.pnlgrid1.Controls.Add(this.grid_patient);
            this.pnlgrid1.Location = new System.Drawing.Point(238, 58);
            this.pnlgrid1.Name = "pnlgrid1";
            this.pnlgrid1.Size = new System.Drawing.Size(719, 204);
            this.pnlgrid1.TabIndex = 186;
            this.pnlgrid1.Visible = false;
            // 
            // butzamknij
            // 
            this.butzamknij.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butzamknij.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butzamknij.Location = new System.Drawing.Point(360, 16);
            this.butzamknij.Name = "butzamknij";
            this.butzamknij.Size = new System.Drawing.Size(106, 23);
            this.butzamknij.TabIndex = 3;
            this.butzamknij.Text = "Zamknij";
            this.butzamknij.UseVisualStyleBackColor = false;
            this.butzamknij.Click += new System.EventHandler(this.butzamknij_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(47, 20);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(58, 14);
            this.label48.TabIndex = 2;
            this.label48.Text = "Wyszukaj";
            // 
            // txtgrid_checkuppatient_search
            // 
            this.txtgrid_checkuppatient_search.Location = new System.Drawing.Point(111, 17);
            this.txtgrid_checkuppatient_search.Name = "txtgrid_checkuppatient_search";
            this.txtgrid_checkuppatient_search.Size = new System.Drawing.Size(231, 20);
            this.txtgrid_checkuppatient_search.TabIndex = 1;
            this.txtgrid_checkuppatient_search.TextChanged += new System.EventHandler(this.txtgrid_checkuppatient_search_TextChanged);
            // 
            // grid_patient
            // 
            this.grid_patient.AllowUserToAddRows = false;
            this.grid_patient.AllowUserToDeleteRows = false;
            this.grid_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_patient.Location = new System.Drawing.Point(14, 40);
            this.grid_patient.Name = "grid_patient";
            this.grid_patient.ReadOnly = true;
            this.grid_patient.Size = new System.Drawing.Size(655, 120);
            this.grid_patient.TabIndex = 0;
            this.grid_patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_patient_CellContentClick_1);
            // 
            // Serach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlgrid1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnprintpreview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnselect);
            this.Name = "Serach";
            this.Size = new System.Drawing.Size(1035, 1060);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlgrid1.ResumeLayout(false);
            this.pnlgrid1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnprintpreview;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbldocktor;
        private System.Windows.Forms.Label lblmiejsce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblppesel;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblkod;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblDataurodzenia;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdatawizyty;
        private System.Windows.Forms.TextBox txtnumerzeba;
        private System.Windows.Forms.TextBox txtrozpoznanie;
        private System.Windows.Forms.TextBox txtzabiegi;
        private System.Windows.Forms.TextBox txtsymbol;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblblona;
        private System.Windows.Forms.Label lblprzyzembie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblhigiena;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblwada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlgrid1;
        private System.Windows.Forms.Button butzamknij;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtgrid_checkuppatient_search;
        private System.Windows.Forms.DataGridView grid_patient;
    }
}
