using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace Agenda2
{
   
    public partial class Form3 : Form
    {
        private static string dbPath = Application.StartupPath + "\\" + "Agenda2DB.db;";

        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";
        private static SQLiteConnection connection = new SQLiteConnection(conString);

        private static SQLiteCommand command = new SQLiteCommand("", connection);
        //private static string sql;

        //private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private DataTable DTCategorii = new DataTable();

        struct DataParameter{
             public List<Site> SiteList;
             public string FileName { get; set; }
        }

        private DataParameter __inputParameter;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //create open connection with database
            openConnection();
            updateDataBinding();
            //updateDataBindingListaCategorii(1, "");
            closeConnection();

            groupBox3.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells;

        }

        private void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                // MessageBox.Show("The connection is " + connection.State.ToString());
            }
        }

        private void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                //MessageBox.Show("The connection is " + connection.State.ToString());
            }
        }

        private void updateDataBinding(Int64 fromPageNumber = 1, string criteriu2 = "", string criteriuCategorie2 = "")
        {   // nrranduriperpag=2

            // int nrranduriperpag = 7;
            

            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();

            command.CommandText = "select count(*) as nrrows FROM site " +
                    " where (( lower(denumire) like @criteriuden ) or ( lower(site) like @criteriuden ) or ( lower(note) like @criteriunote )) and (categorie like @criteriuCategorie)";

            command.Parameters.Clear();
            string criteriu = criteriu2.Trim().ToString();
            if (string.IsNullOrEmpty(criteriu)) { criteriu = "%"; }
            else
            { criteriu = "%" + criteriu + "%"; }

            command.Parameters.AddWithValue("criteriuden", criteriu);
            command.Parameters.AddWithValue("criteriunote", criteriu);

            string criteriuCategorie = criteriuCategorie2.Trim().ToString();
            if (string.IsNullOrEmpty(criteriuCategorie)) { criteriuCategorie = "%"; }
            //else
            //{ criteriuCategorie = "%" + criteriuCategorie + "%"; } //aici pe altfel ramane categoria asa cum este

            command.Parameters.AddWithValue("criteriuCategorie", criteriuCategorie);


            DB1 = new SQLiteDataAdapter(command);// (CommandText, connection);
            DS1.Reset();
            DB1.Fill(DS1);
            DT1 = DS1.Tables[0];
           // double nrpag1 = 1;// Convert.ToDouble(DT1.Rows[0].ItemArray[0]) / nrranduriperpag;// 2;
            Int64 nrpag = 1;/* (Int64)(nrpag1) +
                          Convert.ToInt64(
                              nrpag1 > (Int64)(nrpag1)
                                          );*/



            if ((fromPageNumber <= nrpag) && (fromPageNumber >= 1))
            {

                //labelPagina.Text = (fromPageNumber).ToString();
                //labelPagina2.Text = nrpag.ToString();



                command.CommandText = "select id, denumire, categorie, site, note FROM site " +
                        " where ((lower(denumire) like @criteriuden) or ( lower(site) like @criteriuden ) or (lower(note) like @criteriunote)) and (" +
                        " categorie like @criteriuCategorie ) ";// +
                                  // "LIMIT @nrranduriperpag OFFSET @fromrow";
                command.Parameters.Clear();
                //string canal = canal2.Trim().ToString();
                //canal = canal + "%";

                command.Parameters.AddWithValue("criteriuden", criteriu);
                command.Parameters.AddWithValue("criteriunote", criteriu);
                command.Parameters.AddWithValue("criteriuCategorie", criteriuCategorie);
                //command.Parameters.AddWithValue("nrranduriperpag", nrranduriperpag);
                //command.Parameters.AddWithValue("fromrow", (fromPageNumber - 1) * nrranduriperpag);
                DB1 = new SQLiteDataAdapter(command);// CommandText, connection);
                DS1.Reset();
                DB1.Fill(DS1);
                DT1 = DS1.Tables[0];
                if (DT1.Rows.Count > 0) { dataGridView1.DataSource = DT1; }
                else
                {
                    dataGridView1.DataSource = null;
                  //  labelPagina.Text = "1"; labelPagina2.Text = "1";
                }
                // connection.Close();
            }
            else
            {

                if (nrpag == 0)
                {
                    dataGridView1.DataSource = null;
                    //labelPagina.Text = "1"; labelPagina2.Text = "1";
                }
               /* else
                {
                    MessageBox.Show("Message: Nu exista aceasta pagina! Pagina ceruta =" + fromPageNumber.ToString(),
                    "Eroare agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }

        private void labelStatus2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Site> list = ((DataParameter)e.Argument).SiteList;
            string fileName = ((DataParameter)e.Argument).FileName;
            int index = 1;
            int process =  list.Count;
            int percent = 1;
            MessageBox.Show(process.ToString());
            
            using (StreamWriter sw = new(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id,Denumire,Site,Categorie,Note");
                foreach (Site s in list)
                {
                  
                  if (backgroundWorker1.CancellationPending==false)
                    {
                        percent = index * 100 / process;
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4}",s.Id, '"' + s.Denumire + '"', 
                                                          s.SiteAdress, '"' + s.Categorie + '"', '"' + s.Note + '"'));
                        backgroundWorker1.ReportProgress(percent);
                        index++;
                    }
                }
                sw.Write(sb.ToString());
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labelStatus2.Text = string.Format("Se exporta ...{0}%", e.ProgressPercentage);
            progressBar1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(100);
            labelStatus2.Text = "Datele au fost exportate in fisierul csv.";
        }

        public List<Site> DataGridToSite(DataGridView d1)
        {

            Site s;
            List < Site > list = new List<Site> ();
            foreach(DataGridViewRow r1 in d1.Rows)
            {
                s = new Site();
                s.Id = int.Parse(r1.Cells[0].Value.ToString());
                s.Denumire = r1.Cells[1].Value.ToString();
                //MessageBox.Show(s.Denumire);
                s.Categorie = r1.Cells[2].Value.ToString();
                s.SiteAdress = r1.Cells[3].Value.ToString();
                s.Note = r1.Cells[4].Value.ToString();
                list.Add(s);
            }
            return list;
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    __inputParameter.SiteList = DataGridToSite(dataGridView1); //??
                    __inputParameter.FileName = sfd.FileName;
                    //MessageBox.Show((dataGridView1.DataSource as List<Site>).Count.ToString());
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync(__inputParameter);
                }


        }
    }
}
