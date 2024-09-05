using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda2
{
    public partial class Form2 : Form
    {
        //proprietati Site

        private static string dbCommand = "";
        private static BindingSource bindingSrc;
        private static string dbPath = Application.StartupPath + "\\" + "Agenda2DB.db;";

        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";
        private static SQLiteConnection connection = new SQLiteConnection(conString);

        private static SQLiteCommand command = new SQLiteCommand("", connection);
        private static string sql;

        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public string CategorieSelectata = "";
        public bool AduCategoria = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            openConnection();
            updateDataBinding();
            closeConnection();

            //groupBox3.AutoSize = true;
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

        private void updateDataBinding(Int64 fromPageNumber = 1, string criteriu2Categorie = "")
        {   // nrranduriperpag=2


            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();

            command.CommandText = "select count(*) as nrrows FROM categorie " +
                    " where categorie like @criteriuCategorie";

            command.Parameters.Clear();

            string criteriuCategorie = criteriu2Categorie.Trim().ToString();
            if (string.IsNullOrEmpty(criteriuCategorie)) { criteriuCategorie = "%"; }
            else
            { criteriuCategorie = "%" + criteriuCategorie + "%"; } //aici pe altfel ramane categoria asa cum este

            command.Parameters.AddWithValue("criteriuCategorie", criteriuCategorie);


            DB1 = new SQLiteDataAdapter(command);// (CommandText, connection);
            DS1.Reset();
            DB1.Fill(DS1);
            DT1 = DS1.Tables[0];
            double nrpag1 = Convert.ToDouble(DT1.Rows[0].ItemArray[0]) / 2;
            Int64 nrpag = (Int64)(nrpag1) +
                          Convert.ToInt64(
                              nrpag1 > (Int64)(nrpag1)
                                          );

            
            nrpag = 1;//nou

            if ((fromPageNumber <= nrpag) && (fromPageNumber >= 1))
            {

                //    labelPagina.Text = (fromPageNumber).ToString();
                //    labelPagina2.Text = nrpag.ToString();



                command.CommandText = "select categorie FROM categorie " +
                        " where " +
                        "categorie like @criteriuCategorie order by categorie;";// +
                                  // "LIMIT 2 OFFSET @fromrow";
                command.Parameters.Clear();
                //string canal = canal2.Trim().ToString();
                //canal = canal + "%";

                command.Parameters.AddWithValue("criteriuCategorie", criteriuCategorie);
               // command.Parameters.AddWithValue("fromrow", (fromPageNumber - 1) * 2);
                DB1 = new SQLiteDataAdapter(command);// CommandText, connection);
                DS1.Reset();
                DB1.Fill(DS1);
                DT1 = DS1.Tables[0];
                if (DT1.Rows.Count > 0) { dataGridView1.DataSource = DT1; }
                else
                {
                    dataGridView1.DataSource = null;
                 //   labelPagina.Text = "1"; labelPagina2.Text = "1";
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
                else
                {
                    MessageBox.Show("Message: Nu exista aceasta pagina! Pagina ceruta =" + fromPageNumber.ToString(),
                    "Eroare agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Boolean verify_exista_deja_categoria(string categorie1)
        {
            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();

            command.CommandText = "select count(*) as nrrows FROM categorie " +
                    " where categorie = @criteriuCategorie ";

            command.Parameters.Clear();

            string criteriuCategorie = categorie1.Trim().ToString();

            command.Parameters.AddWithValue("criteriuCategorie", criteriuCategorie);


            DB1 = new SQLiteDataAdapter(command);// (CommandText, connection);
            DS1.Reset();
            DB1.Fill(DS1);
            DT1 = DS1.Tables[0];
            double nrrows = Convert.ToDouble(DT1.Rows[0].ItemArray[0]);// 2;
            if (nrrows > 0) return false; //nu se poate sterge
            return true;
            // if (DT1.Rows.Count > 0) { dataGridView1.DataSource = DT1; }

        }

        private void add()
        {
            Boolean b=true;
            if
                (string.IsNullOrEmpty(txtCategorie.Text.Trim().ToString()))
            {
                MessageBox.Show("Nu ati completat categoria de adaugat ! Mai selectati o data!");
                b= false; 
                return;
            }
            
            if (!verify_exista_deja_categoria(txtCategorie.Text.Trim().ToString()))
            {
                MessageBox.Show("Exista deja aceasta categorie! Nu puteti adauga categoria!");
                b= false;
                return;
            }
            //b==true
            command.CommandText = "insert into categorie (categorie) values ('"
                                       + 
                                         txtCategorie.Text  + "'" +
                                       ")";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Am adaugat categoria noua in baza de date!");
                try
                {
                    Int64 nrpag /*de afisat*/ = 1;// Convert.ToInt64(labelPagina.Text);

                    updateDataBinding(nrpag, txtCategorie.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private Boolean verify_exista_siteuri_in_categorie(string categorie1)
        {
            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();

            command.CommandText = "select count(*) as nrrows FROM site " +
                    " where categorie = @criteriuCategorie ";

            command.Parameters.Clear();

            string criteriuCategorie = categorie1.Trim().ToString();
            
            command.Parameters.AddWithValue("criteriuCategorie", criteriuCategorie);


            DB1 = new SQLiteDataAdapter(command);// (CommandText, connection);
            DS1.Reset();
            DB1.Fill(DS1);
            DT1 = DS1.Tables[0];
            double nrrows = Convert.ToDouble(DT1.Rows[0].ItemArray[0]);// 2;
            if (nrrows > 0) return false; //nu se poate sterge
            return true;
               // if (DT1.Rows.Count > 0) { dataGridView1.DataSource = DT1; }
                
        }



        private Boolean delete()
        {
            if 
                (string.IsNullOrEmpty(txtCategorie.Text.Trim().ToString()))
            {
                MessageBox.Show("Nu ati selectat nici o categorie din lista! Mai selectati o data si apoi apasati butonul Sterge!");
                return false;
            }

            if (!verify_exista_siteuri_in_categorie(txtCategorie.Text))
            {
                MessageBox.Show("Exista site-uri cu aceasta categorie! Nu puteti sterge categoria!");
                return false;
            }

            command.CommandText = "delete from categorie where categorie = '"  + txtCategorie.Text + "'" +
                                   ";";
            try
            {
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        private void buttonAdaugaCategorie_Click(object sender, EventArgs e)
        {
            openConnection();
            add();
            closeConnection();
        }

        private void buttonStergeCategorie_Click(object sender, EventArgs e)
        {
            /*openConnection();
            delete();
            closeConnection();*/

            Boolean b = false;
            if (MessageBox.Show("Sigur doriti sa stergeti categoria curenta din baza de date?", "Stergere site", MessageBoxButtons.YesNo)
              == DialogResult.Yes)
            {
                openConnection();
                try
                {
                    b = delete();

                    if (b == true)
                    {
                        // openConnection();
                        try
                        {
                            //Int64 nrpag /*de afisat*/ = 1;// Convert.ToInt64(labelPagina.Text);

                            updateDataBinding(1, "");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                        //finally { closeConnection(); }
                    }

                }//try
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                finally { closeConnection(); }
            }
        }

        private void buttonCautaCategorie_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                {
                    // txtCriteriuCanal2.Text = ""; //nu mai trebuie
                    updateDataBinding();
                    return;
                }
                //else
                //txtCriteriuCanal2.Text = txtCriteriuCanal.Text;//nu mai trebuie

                updateDataBinding(1, txtCategorie.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message: Search error. " + ex.Message.ToString(), "Eroare Agenda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
                txtCategorie.Focus();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCategorie.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.CategorieSelectata = this.txtCategorie.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategorie.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.CategorieSelectata = this.txtCategorie.Text;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategorie.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            this.CategorieSelectata = this.txtCategorie.Text;
        }

        private void button1_Click(object sender, EventArgs e) //inapoi la site-uri; inchide formul cu categoria selectata
        {
            //Form1 f1 = new Form1();
            //f1.Show();
            //this.CategorieSelectata = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.AduCategoria = true;
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e) //inchide formul fara categoria selectata
        { 
            this.AduCategoria = false;
            this.Close();

        }
    }
}
