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
using System.IO;//new
using Newtonsoft.Json.Linq;//new

namespace Agenda2
{
    public partial class Form1 : Form
    {

        //proprietati Site

        //private static string dbCommand = "";
        //private static BindingSource bindingSrc;
        private static string dbPath = Application.StartupPath + "\\" + "Agenda2DB.db;";

        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";
        private static SQLiteConnection connection = new SQLiteConnection(conString);

        private static SQLiteCommand command = new SQLiteCommand("", connection);
        //private static string sql;

        //private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private DataTable DTCategorii = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }


        private void emptyFields()
        {
            txtId.Text = ""; //atentie nu mai este implicit Id !!!!
            txtDenumire.Text = "";
            txtSite.Text = "";
            txtCategorie.Text = "";
            txtNote.Text = "";
        }
        private void buttonGolesteDateSite_Click(object sender, EventArgs e)
        {
            emptyFields();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //create open connection with database
            openConnection();
            updateDataBinding();
            updateDataBindingListaCategorii(1, "");
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

            int nrranduriperpag = 7;
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
            double nrpag1 = Convert.ToDouble(DT1.Rows[0].ItemArray[0]) / nrranduriperpag;// 2;
            Int64 nrpag = (Int64)(nrpag1) +
                          Convert.ToInt64(
                              nrpag1 > (Int64)(nrpag1)
                                          );



            if ((fromPageNumber <= nrpag) && (fromPageNumber >= 1))
            {

                labelPagina.Text = (fromPageNumber).ToString();
                labelPagina2.Text = nrpag.ToString();



                command.CommandText = "select id, denumire, categorie, site, note FROM site " +
                        " where ((lower(denumire) like @criteriuden) or ( lower(site) like @criteriuden ) or (lower(note) like @criteriunote)) and (" +
                        " categorie like @criteriuCategorie ) " +
                                   "LIMIT @nrranduriperpag OFFSET @fromrow";
                command.Parameters.Clear();
                //string canal = canal2.Trim().ToString();
                //canal = canal + "%";

                command.Parameters.AddWithValue("criteriuden", criteriu);
                command.Parameters.AddWithValue("criteriunote", criteriu);
                command.Parameters.AddWithValue("criteriuCategorie", criteriuCategorie);
                command.Parameters.AddWithValue("nrranduriperpag", nrranduriperpag);
                command.Parameters.AddWithValue("fromrow", (fromPageNumber - 1) * nrranduriperpag);
                DB1 = new SQLiteDataAdapter(command);// CommandText, connection);
                DS1.Reset();
                DB1.Fill(DS1);
                DT1 = DS1.Tables[0];
                if (DT1.Rows.Count > 0) { dataGridView1.DataSource = DT1; }
                else
                {
                    dataGridView1.DataSource = null;
                    labelPagina.Text = "1"; labelPagina2.Text = "1";
                }
                // connection.Close();
            }
            else
            {

                if (nrpag == 0)
                {
                    dataGridView1.DataSource = null;
                    labelPagina.Text = "1"; labelPagina2.Text = "1";
                }
                else
                {
                    MessageBox.Show("Message: Nu exista aceasta pagina! Pagina ceruta =" + fromPageNumber.ToString(),
                    "Eroare agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetPrimaryKeyCategorie(DataColumn col)
        {
            var keys = new DataColumn[1];
            DataColumn columnCategoriePK=col;

            // Create column 1 if null
            if (col is null)
            {
                columnCategoriePK = new DataColumn();
                columnCategoriePK.DataType = Type.GetType("System.String");
                columnCategoriePK.ColumnName = "categorie";
                // Add the column to the DataTable.Columns collection.
                DTCategorii.Columns.Add(columnCategoriePK);
            }
           
            // Add the column to the array.
            keys[0] = columnCategoriePK;


            // Set the PrimaryKeys property to the array.
            DTCategorii.PrimaryKey = keys;
        }

        private void updateDataBindingListaCategorii(Int64 fromPageNumber = 1, string criteriu2Categorie = "")
        {   // nrranduriperpag=2


            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();
            

                command.CommandText = "select categorie FROM categorie "
                        ;
                
                DB1 = new SQLiteDataAdapter(command);// CommandText, connection);
                DS1.Reset();
                DB1.Fill(DS1);
                //SetPrimaryKeyCategorie();
                DTCategorii = DS1.Tables[0];
                SetPrimaryKeyCategorie(DTCategorii.Columns[0]);

            /*
            if (DT1.Rows.Count > 0) { DTCategorii = DT1;
                DTCategorii.PrimaryKey = null;
                DTCategorii.PrimaryKey.Append(DTCategorii.Columns[0]);
                MessageBox.Show("primary key setata");
                                         }
                else
                {
                    DTCategorii = null;
                    //   labelPagina.Text = "1"; labelPagina2.Text = "1";
                }
                // connection.Close();
            */
        }

        private Boolean verificaCategoria(string categorie)
        {
            if (DTCategorii.Rows.Contains(categorie)) return true;
            //else
            return false;
        }

        private Boolean verify_exista_deja_siteul_for_add(string denumire1, string site1)//pentru adauga
        {
            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();

            command.CommandText = "select count(*) as nrrows FROM site " +
                    " where denumire = @criteriuDenumire or site = @criteriuSite ";

            command.Parameters.Clear();

            string criteriuDenumire = denumire1.Trim().ToString();
            string criteriuSite = site1.Trim().ToString();
            command.Parameters.AddWithValue("criteriuDenumire", criteriuDenumire);
            command.Parameters.AddWithValue("criteriuSite", criteriuSite);


            DB1 = new SQLiteDataAdapter(command);// (CommandText, connection);
            DS1.Reset();
            DB1.Fill(DS1);
            DT1 = DS1.Tables[0];
            double nrrows = Convert.ToDouble(DT1.Rows[0].ItemArray[0]);// 2;
            if (nrrows > 0) return false; //nu se poate sterge
            return true;
            // if (DT1.Rows.Count > 0) { dataGridView1.DataSource = DT1; }

        }


        private Boolean verify_exista_deja_denumirea_siteului_for_import(string denumire1)//pentru adauga prin import
        {
            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();

            command.CommandText = "select count(*) as nrrows FROM site " +
                    " where denumire = @criteriuDenumire";

            command.Parameters.Clear();

            string criteriuDenumire = denumire1.Trim().ToString();
            //string criteriuSite = site1.Trim().ToString();
            command.Parameters.AddWithValue("criteriuDenumire", criteriuDenumire);
            //command.Parameters.AddWithValue("criteriuSite", criteriuSite);


            DB1 = new SQLiteDataAdapter(command);// (CommandText, connection);
            DS1.Reset();
            DB1.Fill(DS1);
            DT1 = DS1.Tables[0];
            double nrrows = Convert.ToDouble(DT1.Rows[0].ItemArray[0]);// 2;
            if (nrrows > 0) return false; //nu se poate sterge
            return true;
            // if (DT1.Rows.Count > 0) { dataGridView1.DataSource = DT1; }

        }

        public Boolean verify_exista_deja_siteul_siteului_for_import(string site1)//pentru adauga prin import
        {
            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();

            command.CommandText = "select count(*) as nrrows FROM site " +
                    " where site = @criteriuSite";

            command.Parameters.Clear();

            //string criteriuDenumire = denumire1.Trim().ToString();
            string criteriuSite = site1.Trim().ToString();
            //command.Parameters.AddWithValue("criteriuDenumire", criteriuDenumire);
            command.Parameters.AddWithValue("criteriuSite", criteriuSite);


            DB1 = new SQLiteDataAdapter(command);// (CommandText, connection);
            DS1.Reset();
            DB1.Fill(DS1);
            DT1 = DS1.Tables[0];
            double nrrows = Convert.ToDouble(DT1.Rows[0].ItemArray[0]);// 2;
            if (nrrows > 0) return false; //nu se poate sterge
            return true;
            // if (DT1.Rows.Count > 0) { dataGridView1.DataSource = DT1; }

        }
        private Boolean verify_exista_deja_siteul_for_modify(string denumire1, string site1, Int64 idSite1)//pentru modifica
        {
            SQLiteDataAdapter DB1;
            DataSet DS1 = new DataSet();
            DataTable DT1 = new DataTable();

            command.CommandText = "select count(*) as nrrows FROM site " +
                    " where (denumire = @criteriuDenumire or site = @criteriuSite) and (id <> @idSite) ";

            command.Parameters.Clear();

            string criteriuDenumire = denumire1.Trim().ToString();
            string criteriuSite = site1.Trim().ToString();
            string idSite = idSite1.ToString();
            command.Parameters.AddWithValue("criteriuDenumire", criteriuDenumire);
            command.Parameters.AddWithValue("criteriuSite", criteriuSite);
            command.Parameters.AddWithValue("idSite", idSite);

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
           // Boolean b = true;
            if (
               (string.IsNullOrEmpty(txtDenumire.Text.Trim().ToString())) ||
               (string.IsNullOrEmpty(txtSite.Text.Trim().ToString())) ||
               (string.IsNullOrEmpty(txtCategorie.Text.Trim().ToString()))
               )
                {
                MessageBox.Show("Nu ati completat denumirea sau site-ul sau categoria noului site! Mai completati o data campurile inainte de a apasa butonul Adauga!");
              //  b = false;
                return;
            }

            if (!verify_exista_deja_siteul_for_add(txtDenumire.Text.Trim().ToString(),
                                                       txtSite.Text.Trim().ToString()))
            {
                MessageBox.Show("Exista deja un site care are aceasta denumire sau aceasta adresa url(site)! Nu puteti adauga site-ul nou!");
                //b = false;
                return;
            }
            //b==true
            if (verificaCategoria(txtCategorie.Text)==false)
            {
                MessageBox.Show("Nu exista categoria " + txtCategorie.Text + " in baza de date! Nu am adaugat site-ul nou!");
                return;
            }
           // else 
            //pas1. verifica ca nu exista un site cu denumirea sau site-ul nou --- inca nu am facut
            //pas2. insert efectiv
            command.CommandText = "insert into site (denumire, site, categorie, note) values ('"
                                       + txtDenumire.Text + "','" + txtSite.Text + "','"+
                                         txtCategorie.Text + "','" + txtNote.Text + "'" +
                                       ")";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Am adaugat site-ul nou in baza de date!");
                try
                {
                    Int64 nrpag /*de afisat*/ = 1;// Convert.ToInt64(labelPagina.Text);

                    updateDataBinding(nrpag, txtCriteriuDenNote.Text, txtCriteriuCategorie.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private Boolean modifica()
        {
            string idSite = txtId.Text;
            if (txtId.Text.ToString() == "")
            {
                MessageBox.Show("Nu ati selectat nici un site din lista! Mai selectati o data!");
                return false;
            }
            if (
               (string.IsNullOrEmpty(txtDenumire.Text.Trim().ToString())) ||
               (string.IsNullOrEmpty(txtSite.Text.Trim().ToString()))||
               (string.IsNullOrEmpty(txtCategorie.Text.Trim().ToString()))
               ) 
            {
                MessageBox.Show("Nu ati completat pentru site-ul curent noua denumire, site-ul sau categoria!");
                return false;
            }

            if (verificaCategoria(txtCategorie.Text) == false)
            {
                MessageBox.Show("Nu exista categoria " + txtCategorie.Text + " in baza de date! Nu am modificat site-ul nou!");
                return false;
            }
            Int64 id1=-1;
            try
            {
                id1 = Convert.ToInt64(txtId.Text.ToString());
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Eroare id site selectat non numeric! Mai selectati o data!");
                return false; 
            }

            if (id1<0)
            {
                MessageBox.Show("Eroare id site selectat! Mai selectati o data!");
                return false;
            }

            if (!verify_exista_deja_siteul_for_modify(txtDenumire.Text.Trim().ToString(),
                                                       txtSite.Text.Trim().ToString(),
                                                       id1))
            {
                MessageBox.Show("Exista deja un alt site care are aceasta denumire sau aceasta"+
                    " adresa url(site)! Nu puteti adauga site-ul nou!");
                //b = false;
                return false;
            }

            //pas1. verifica daca exista un site cu alt id !!! care are aceasta noua denumire sau nou site --- inca nu am facut
            //pas2. update efectiv
            command.CommandText = "update site set denumire='"
                                       + txtDenumire.Text + "' , site='" + txtSite.Text + 
                                       "', categorie ='" 
                                       + txtCategorie.Text + "'" +
                                        ", note ='"
                                       + txtNote.Text + "'" +
                                       " where id = " + idSite + ";";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Ati modificat cu succes campurile site-ului curent ( adica ale site-ului cu id =" 
                                 + idSite.ToString() +" )!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        private Boolean delete()
        {
            if ((txtId.Text.ToString() == "") ||
                (string.IsNullOrEmpty(txtDenumire.Text.ToString())) ||
                (string.IsNullOrEmpty(txtSite.Text.ToString()))||
                (string.IsNullOrEmpty(txtCategorie.Text.ToString())))
            {
                MessageBox.Show("Nu ati selectat nici un site din lista sau ati golit campurile site-ului selectat! Mai selectati o data!");
                return false;
            }

            command.CommandText = "delete from site where id = " +
                                   txtId.Text +
                                   " and denumire='" + txtDenumire.Text +
                                   "' and site='" + txtSite.Text +
                                   "' and categorie='" + txtCategorie.Text + "'";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Am sters cu succes site-ul din baza de date!");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        private void buttonAdaugaSite_Click(object sender, EventArgs e)
        {
            openConnection();
            add();
            closeConnection();
        }

        private void buttonModificaSite_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            openConnection();
            try
            {
                b = modifica();

                if (b == true)
                {
                    //openConnection();
                    try
                    {
                        Int64 nrpag /*de afisat*/ = Convert.ToInt64(labelPagina.Text);

                        updateDataBinding(nrpag, txtCriteriuDenNote.Text, txtCriteriuCategorie.Text);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                    /*finally
                    {
                        closeConnection();
                    }*/
                }
            }//try
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            finally
            {
                closeConnection();
            }
        }

        private void buttonStergeSite_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            if (MessageBox.Show("Sigur doriti sa stergeti site-ul curent din baza de date?", "Stergere site", MessageBoxButtons.YesNo)
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
                            Int64 nrpag /*de afisat*/ = 1;// Convert.ToInt64(labelPagina.Text);

                            updateDataBinding(nrpag, txtCriteriuDenNote.Text, txtCriteriuCategorie.Text);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                        //finally { closeConnection(); }
                    }

                }//try
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                finally { closeConnection(); }
            }
        }

        private void buttonDeschideSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", txtSite.Text);
        }

        private void buttonCautaSite_Click(object sender, EventArgs e)
        {
            txtDenSiteNoteCriteriu1.Text = txtCriteriuDenNote.Text.Trim();
            txtCategorieCriteriu2.Text = txtCriteriuCategorie.Text.Trim();
            emptyFields();//goleste campurile de sus din lista adaugat la 17 sept 2021
            openConnection();
            try
            {
                if (string.IsNullOrEmpty(txtCriteriuDenNote.Text.Trim()+ txtCriteriuCategorie.Text.Trim()))
                {
                   // txtCriteriuCanal2.Text = ""; //nu mai trebuie
                    updateDataBinding();
                    return;
                }
                //else
                //txtCriteriuCanal2.Text = txtCriteriuCanal.Text;//nu mai trebuie

                updateDataBinding(1, txtCriteriuDenNote.Text, txtCriteriuCategorie.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message: Search error. " + ex.Message.ToString(), "Eroare Agenda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
                txtDenumire.Focus();
            }
            //nu mai fac disable campurile de cautare dupa apasarea butonului cautare
            //txtCriteriuDenNote.Enabled = false;
            //txtCriteriuCategorie.Enabled = false;
        }

        /*private void button1_Click(object sender, EventArgs e)//Goleste criteriile de cautare
        {
           
            txtCriteriuDenNote.Text = "";
            txtCriteriuCategorie.Text = "";
            txtCriteriuDenNote.Enabled = true;
            txtCriteriuCategorie.Enabled = true;
        }*/

       

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            openConnection();
            try
            {
                Int64 nrpag /*de afisat*/ = Convert.ToInt64(labelPagina.Text);
                nrpag--;
                //updateDataBinding(nrpag, txtCriteriuDenNote.Text, txtCriteriuCategorie.Text);
                updateDataBinding(nrpag, txtDenSiteNoteCriteriu1.Text, txtCategorieCriteriu2.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                closeConnection();
            }
        }

        private void buttonUrmator_Click(object sender, EventArgs e)
        {
            openConnection();
            try
            {
                Int64 nrpag /*de afisat*/ = Convert.ToInt64(labelPagina.Text);
                nrpag++;
                //updateDataBinding(nrpag, txtCriteriuDenNote.Text, txtCriteriuCategorie.Text);
                updateDataBinding(nrpag, txtDenSiteNoteCriteriu1.Text, txtCategorieCriteriu2.Text);
            }
            catch (Exception ex) { }
            finally
            {
                closeConnection();
            }
        }

        private void selectSiteCurent(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDenumire.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCategorie.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSite.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNote.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectSiteCurent(sender, e);
        }

        private void labelPagina_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeschideFormCategorie_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
            f2.Focus();
            //f2.Show();
            //this.Close();
            if (f2.AduCategoria == true)
            { this.txtCategorie.Text = f2.CategorieSelectata; }

            openConnection();
            updateDataBindingListaCategorii(1, "");
            closeConnection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectSiteCurent(sender, e);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectSiteCurent(sender, e);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void labelCriteriuSite_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2DeschideCategoriile_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
            f2.Focus();
            //f2.Show();
            //this.Close();
            if (f2.AduCategoria == true)
            { this.txtCriteriuCategorie.Text = f2.CategorieSelectata; }

            openConnection();
            updateDataBindingListaCategorii(1, "");
            closeConnection();
        }

        private void buttonOpenFormExport_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            f3.Show();
           // this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open form 4
            Form4 f4 = new Form4(this);
            f4.Show();

        }

        private void add_site_imported_from_chrome(String denumire, String site, String cale)
        {
            // Boolean b = true;
            
            if (
               (string.IsNullOrEmpty(denumire.Trim().ToString())) ||
               (string.IsNullOrEmpty(site.Trim().ToString())) 
              // (string.IsNullOrEmpty(txtCategorie.Text.Trim().ToString()))
               )
            {
                //MessageBox.Show("Nu ati completat denumirea sau site-ul noului site importat! Mai completati o data campurile inainte de a apasa butonul Adauga!");
                //  b = false;
                return;
            }

            if (!verify_exista_deja_siteul_siteului_for_import(site.Trim().ToString()))
            {
               // MessageBox.Show("Exista deja un site care are aceasta denumire sau aceasta adresa url(site)! Nu puteti adauga site-ul nou!");
                //b = false;
                return;
            }
            // denumire = denumire.ToString().Replace("'", "");
            string vers_denumire = denumire.Trim().ToString();
            int nrvers = 2;
            while (!verify_exista_deja_denumirea_siteului_for_import(vers_denumire))
            {
                // MessageBox.Show("Exista deja un site care are aceasta denumire sau aceasta adresa url(site)! Nu puteti adauga site-ul nou!");
                //b = false;
                // return;
                nrvers++;
                vers_denumire = denumire + " v." + nrvers.ToString();
                if (nrvers >= 100)
                {
                    break;
                 }
            }
            denumire = vers_denumire;
            //b==true
            String categorie = "import Google Chrome";
            if (verificaCategoria(categorie) == false)
            {
                //MessageBox.Show("Nu exista categoria " + categorie + " in baza de date! Nu am adaugat site-ul nou!");
                return;
            }
            // else 
            //pas1. verifica ca nu exista un site cu denumirea sau site-ul nou --- inca nu am facut
            //pas2. insert efectiv
            
            String note = "cale Google Chrome: " + cale;
            command.CommandText = //"insert into site (denumire, site, categorie, note) values ('"
                                  //  + denumire + "','" + site + "','" +
                                  //    categorie + "','" + note + "'" +
                                  //   ")";

                                   "insert into site (denumire, site, categorie, note) values (@critDenumire, @critSite, @critCategorie, @critNote)";
            try
            {
                command.Parameters.AddWithValue("critDenumire",denumire);
                command.Parameters.AddWithValue("critSite", site);
                command.Parameters.AddWithValue("critCategorie", categorie);
                command.Parameters.AddWithValue("critNote", note);


                command.ExecuteNonQuery();
                //MessageBox.Show("Am adaugat site-ul nou in baza de date!");
                /*try
                {
                    Int64 nrpag  = 1;

                    updateDataBinding(nrpag, txtCriteriuDenNote.Text, txtCriteriuCategorie.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                */
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonImportFromChrome_Click(object sender, EventArgs e)
        {
            openConnection();
            LoadBookmarksNew();
            closeConnection();
        }
        private void LoadBookmarksNew()
        {
            try
            {
                // Calea către folderul de profil Chrome al utilizatorului
                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string chromeBookmarksPath = Path.Combine(userProfile, "AppData", "Local", "Google", "Chrome", "User Data", "Default", "Bookmarks");

                if (!File.Exists(chromeBookmarksPath))
                {
                    MessageBox.Show("Fișierul de marcaje Google Chrome nu a fost găsit.");
                    return;
                }

                // Citește fișierul JSON al marcajelor
                string bookmarksJson = File.ReadAllText(chromeBookmarksPath);

                // Parsează JSON-ul
                JObject bookmarksData = JObject.Parse(bookmarksJson);

                var roots = bookmarksData["roots"];

                // Procesează toate secțiunile principale: bookmark_bar, other și mobile
                ProcessFolder(roots["bookmark_bar"], "Bookmark Bar", "");
                ProcessFolder(roots["other"], "Other Bookmarks", "");
                ProcessFolder(roots["synced"], "Mobile Bookmarks", "");

                MessageBox.Show("Importul din Chrome s-a finalizat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}");
            }
        }

        private void ProcessFolder(JToken folder, string folderName, string cale)
        {
            if (folder == null) return;

            // Adaugă titlul folderului în ListBox
            //listBoxBookmarks.Items.Add($"--- {folderName} ---");
            String myfolderName = $"{folderName}";
            // Procesează conținutul folderului
            var children = folder["children"];
            if (children != null)
            {
                foreach (var child in children)
                {
                    string type = child["type"]?.ToString();

                    if (type == "folder")
                    {
                        // Dacă este un folder, procesează-l recursiv
                        string subFolderName = child["name"]?.ToString() ?? "Folder fără nume";
                        //cale = cale + '/' + myfolderName;//atentie foreach ; nu trebuie facut asa; 
                        ProcessFolder(child, subFolderName, cale + '/' + myfolderName);
                    }
                    else if (type == "url")
                    {
                        // Dacă este un marcaj, adaugă-l la ListBox
                        string name = child["name"]?.ToString();
                        string url = child["url"]?.ToString();

                        //listBoxBookmarks.Items.Add($"{name}: {url}");
                        //cale = cale + '/' + myfolderName;//atentie foreach  nu trebuie facut asa; 

                        add_site_imported_from_chrome(name, url, cale + '/' + myfolderName);
                        
                        //return;
                    }
                }
            }
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGoPage_Click(object sender, EventArgs e)
        {
            openConnection();
            try
            {
                Int64 nrpag /*de afisat*/ = Convert.ToInt64(txtPage.Text);
                
                //updateDataBinding(nrpag, txtCriteriuDenNote.Text, txtCriteriuCategorie.Text);
                updateDataBinding(nrpag, txtDenSiteNoteCriteriu1.Text, txtCategorieCriteriu2.Text);
            }
            catch (Exception ex) { MessageBox.Show("Eroare la schimbarea paginii!"); }
            finally
            {
                closeConnection();
                txtPage.Text = "";
            }
        }
    }
}


