using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using System.IO;

namespace Extraction_Maarif_Sortant
{
    public partial class Form1 : Form
    {
        private SqlConnection cnx;
        private SqlDataAdapter da;
        private String selectQueryString;
        private String exportDateString;
        private String q_selectString;
        private String campDBString;
        private String clientTableString;
        private String callTableString;
        private String fileNameExtensionSting;
        private String destinationFolderString;

        /*
            //public SqlConnection Cnx { get => cnx; set => cnx = value; }
            //public SqlDataAdapter Da { get => da; set => da = value; }
            //public string SelectQueryString { get => selectQueryString; set => selectQueryString = value; }
            //public string ExportDateString { get => exportDateString; set => exportDateString = value; }
            //public string CallTableString { get => callTableString; set => callTableString = value; }
            //public string ClientTableString { get => clientTableString; set => clientTableString = value; }
            //public string CampDBString { get => campDBString; set => campDBString = value; }
            //public string Q_selectString { get => q_selectString; set => q_selectString = value; }
            //public string FileNameExtensionSting { get => fileNameExtensionSting; set => fileNameExtensionSting = value; }
            //public string DestinationFolderString { get => destinationFolderString; set => destinationFolderString = value; }
         */




        public DataTable Dt { get; set; } = new DataTable();
        public SqlConnection Cnx { get { return cnx; } set { cnx = value; } }
        public SqlDataAdapter Da { get { return da; } set { da = value; } }
        public string SelectQueryString { get { return selectQueryString; } set { selectQueryString = value; } }
        public string ExportDateString { get { return exportDateString; } set { exportDateString = value; } }
        public string CallTableString { get { return callTableString; } set { callTableString = value; } }
        public string ClientTableString { get { return clientTableString; } set { clientTableString = value; } }
        public string CampDBString { get { return campDBString; } set { campDBString = value; } }
        public string Q_selectString { get { return q_selectString; } set { q_selectString = value; } }
        public string FileNameExtensionSting { get { return fileNameExtensionSting; } set { fileNameExtensionSting = value; } }
        public string DestinationFolderString { get { return destinationFolderString; } set { destinationFolderString = value; } }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect_To_Database();          
            Cnx.Open();
            Fill_CheckedListBox();
        }
        
        //Methode allows you to connect to the DataBase.
        void Connect_To_Database()
        {
            string data_source = "10.122.20.51\\SQLEXPRESS;";
            string Initial_Catalog = "TESTS;";
            string User_ID = "ZAkhdari;";
            string Password = "123456789;";
            Cnx = new SqlConnection("Data Source=" + data_source + "Initial Catalog=" + Initial_Catalog + "User ID=" + User_ID + "Password=" + Password + "MultipleActiveResultSets=True");
        }

        void Fill_CheckedListBox()
        {
            //select everything in the table and fill the checkedlistbox with Capmagne as a DisplayMember and the id_param as a ValueMember
            using (SqlDataAdapter Da = new SqlDataAdapter("select * from Export_Tasks_Maarif", Cnx))
            {
                string campagne = "";
                Int64 id_param = 0;
                Da.Fill(Dt);
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    campagne = Dt.Rows[i].Field<string>("Campagne");
                    checkedListBox1.DisplayMember = campagne;
                    id_param = Dt.Rows[i].Field<Int64>("ID_Param");
                    checkedListBox1.ValueMember = id_param.ToString();
                    checkedListBox1.Items.Insert(i, campagne);
                }
            }
        }
        //select all the items by clicking on Btn_Select_all_Click
        private void Btn_Select_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }
        //Select none of the items by clicking on Btn_Unselect_all_Click
        private void Btn_Unselect_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
        //Invert the selection by clicking on Btn_Invert_Select_Click
        private void Btn_Invert_Select_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, !checkedListBox1.GetItemChecked(i));
                }
        }

        private void Btn_Export_CSV_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedItem = checkedListBox1.CheckedItems;
            if (checkedItem.Count == 0)
            {
                MessageBox.Show("No campaign selected!", "Error!");
            }
            else
            {
                DateTime executionStart = DateTime.Now;
                //open the folderBrowser to choose where do you want to save the file  
                using (FolderBrowserDialog extractionDirectory = new FolderBrowserDialog())
                {
                    if (extractionDirectory.ShowDialog() == DialogResult.OK)
                    {
                        //Select the checked items in checkedListBox1 to collect their informations using sql requete
                        foreach (var checked_Campaign in checkedListBox1.CheckedItems)
                        {
                            string Campagne = "[Campagne]";
                            //selecting all the needed information to put them in variables and i used SqlDataReader to bring the infomations from database
                            SqlCommand cmd = new SqlCommand("select Camp_DB , client_table , appel_table , Dest_Folder , File_Name , Q_select from [Export_Tasks_Maarif] where " + Campagne + " = '" + checked_Campaign + "'", Cnx);
                            SqlDataReader dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                //the name of database
                                CampDBString = dr[0].ToString();
                                ClientTableString = dr[1].ToString();
                                CallTableString = dr[2].ToString();
                                DestinationFolderString = dr[3].ToString();
                                FileNameExtensionSting = dr[4].ToString();
                                Q_selectString = dr[5].ToString();

                                SelectQueryString = "SELECT " + Q_selectString + " FROM [" + CampDBString + "].[dbo].[" + ClientTableString + "] c INNER JOIN [" + CampDBString + "].[dbo].[" + CallTableString + "] a ON (c.INDICE=a.INDICE AND a.DATE = " + ExportDateString + ")";
                                SqlDataAdapter da = new SqlDataAdapter(selectQueryString, Cnx);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                //the file name
                                string extractionFileName = "Exp_" + checked_Campaign + "_" + DateTime.Now.ToString("dd_MM_yyyy") + "_" + FileNameExtensionSting + ".csv";
                                Directory.CreateDirectory(extractionDirectory.SelectedPath + "\\" + CampDBString);
                                this.WriteToCSV(dt, extractionDirectory.SelectedPath + "\\" + CampDBString + "\\" + extractionFileName);
                            }
                        }
                    }
                }
                TimeSpan difference = DateTime.Now - executionStart;
                MessageBox.Show("Generating and storing data done in : " + difference.Hours.ToString() + "h" + difference.Minutes.ToString() + "m" + difference.Seconds.ToString() + "s" + difference.Milliseconds.ToString() + "ms", "Information!");
                Application.Exit();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string day = "";
            string month = "";
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                //CHANGE IN ORDER TO GET 20191104 INSTEAD OF 2019114 , IF THE PICKED DATE IS UNDER 10 IT SHOULD ADD A "0" BEHIND THE NUMBER ,
                // THE SAME THING FOR THE MONTH , AND STORE IT IN ExportDateString TO USE IT SOMEWHERE ELSE
                // ALSO YOU CAN'T CHOOSE A DATE BIGGER THAN THE ACTUAL DATE , OR IT WILL SHOW AN ERROR MESSAGE.
                if (dateTimePicker1.Value.Day < 10)
                {
                    day = "0";
                }
                if (dateTimePicker1.Value.Month < 10)
                {
                    month = "0";
                }
                ExportDateString = dateTimePicker1.Value.Year.ToString() + month + dateTimePicker1.Value.Month.ToString() + day + dateTimePicker1.Value.Day.ToString();
            }
            else
            {
                MessageBox.Show("Can't generate data of the futur! Please select another date", "Error!");
            }
        }

        private void WriteToCSV(DataTable data, String filename)
        {
            //StreamWriter : methods to write data into file.
            using (var sw = new StreamWriter(filename))
            {
                //CsvWriter : writing delimited text data to a file .
                using (var csv = new CsvWriter(sw))
                {
                    //Create the data Columns into the file.
                    foreach (DataColumn column in data.Columns)
                    {
                        csv.WriteField(column.ColumnName);
                    }
                    //NextRecord : Ends writing of the current record and starts a new record. This automatically deletes the writer.
                    csv.NextRecord();

                    //Create the data Rows into the file.
                    foreach (DataRow row in data.Rows)
                    {
                        for (var i = 0; i < data.Columns.Count; i++)
                        {
                            csv.WriteField(row[i]);
                        }
                        csv.NextRecord();
                    }
                }
            }
        }
    }
}