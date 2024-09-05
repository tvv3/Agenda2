
namespace Agenda2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelIdSite = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDenumireSite = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelNoteSite = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.labelCategorieSite = new System.Windows.Forms.Label();
            this.labelSite = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.buttonGolesteDateSite = new System.Windows.Forms.Button();
            this.buttonAdaugaSite = new System.Windows.Forms.Button();
            this.buttonDeschideSite = new System.Windows.Forms.Button();
            this.buttonDeschideFormCategorie = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonModificaSite = new System.Windows.Forms.Button();
            this.buttonStergeSite = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenFormExport = new System.Windows.Forms.Button();
            this.txtCategorieCriteriu2 = new System.Windows.Forms.TextBox();
            this.txtDenSiteNoteCriteriu1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2DeschideCategoriile = new System.Windows.Forms.Button();
            this.txtCriteriuCategorie = new System.Windows.Forms.TextBox();
            this.txtCriteriuDenNote = new System.Windows.Forms.TextBox();
            this.labelCriteriuCategorie = new System.Windows.Forms.Label();
            this.labelCriteriuSite = new System.Windows.Forms.Label();
            this.buttonCautaSite = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUrmator = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.labelPagina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPagina2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIdSite
            // 
            this.labelIdSite.AutoSize = true;
            this.labelIdSite.Location = new System.Drawing.Point(3, 0);
            this.labelIdSite.Name = "labelIdSite";
            this.labelIdSite.Size = new System.Drawing.Size(29, 25);
            this.labelIdSite.TabIndex = 0;
            this.labelIdSite.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1739, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Site";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelDenumireSite, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelIdSite, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNote, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNoteSite, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCategorie, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDenumire, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCategorieSite, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelSite, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSite, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonGolesteDateSite, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdaugaSite, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeschideSite, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeschideFormCategorie, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1733, 347);
            this.tableLayoutPanel1.TabIndex = 16;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelDenumireSite
            // 
            this.labelDenumireSite.AutoSize = true;
            this.labelDenumireSite.Location = new System.Drawing.Point(3, 59);
            this.labelDenumireSite.Name = "labelDenumireSite";
            this.labelDenumireSite.Size = new System.Drawing.Size(103, 25);
            this.labelDenumireSite.TabIndex = 1;
            this.labelDenumireSite.Text = "Denumire*";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(112, 251);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(1153, 93);
            this.txtNote.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(112, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(1153, 31);
            this.txtId.TabIndex = 5;
            // 
            // labelNoteSite
            // 
            this.labelNoteSite.AutoSize = true;
            this.labelNoteSite.Location = new System.Drawing.Point(3, 248);
            this.labelNoteSite.Name = "labelNoteSite";
            this.labelNoteSite.Size = new System.Drawing.Size(54, 25);
            this.labelNoteSite.TabIndex = 4;
            this.labelNoteSite.Text = "Note";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCategorie.Location = new System.Drawing.Point(112, 193);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(1153, 31);
            this.txtCategorie.TabIndex = 8;
            // 
            // txtDenumire
            // 
            this.txtDenumire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDenumire.Location = new System.Drawing.Point(112, 62);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(1153, 31);
            this.txtDenumire.TabIndex = 6;
            // 
            // labelCategorieSite
            // 
            this.labelCategorieSite.AutoSize = true;
            this.labelCategorieSite.Location = new System.Drawing.Point(3, 190);
            this.labelCategorieSite.Name = "labelCategorieSite";
            this.labelCategorieSite.Size = new System.Drawing.Size(102, 25);
            this.labelCategorieSite.TabIndex = 3;
            this.labelCategorieSite.Text = "Categorie*";
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(3, 127);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(52, 25);
            this.labelSite.TabIndex = 2;
            this.labelSite.Text = "Site*";
            // 
            // txtSite
            // 
            this.txtSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSite.Location = new System.Drawing.Point(112, 130);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(1153, 31);
            this.txtSite.TabIndex = 7;
            // 
            // buttonGolesteDateSite
            // 
            this.buttonGolesteDateSite.Location = new System.Drawing.Point(1421, 3);
            this.buttonGolesteDateSite.Name = "buttonGolesteDateSite";
            this.buttonGolesteDateSite.Size = new System.Drawing.Size(269, 53);
            this.buttonGolesteDateSite.TabIndex = 10;
            this.buttonGolesteDateSite.Text = "Goleste campurile";
            this.buttonGolesteDateSite.UseVisualStyleBackColor = true;
            this.buttonGolesteDateSite.Click += new System.EventHandler(this.buttonGolesteDateSite_Click);
            // 
            // buttonAdaugaSite
            // 
            this.buttonAdaugaSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdaugaSite.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonAdaugaSite.Location = new System.Drawing.Point(1421, 62);
            this.buttonAdaugaSite.Name = "buttonAdaugaSite";
            this.buttonAdaugaSite.Size = new System.Drawing.Size(112, 62);
            this.buttonAdaugaSite.TabIndex = 11;
            this.buttonAdaugaSite.Text = "Adauga";
            this.buttonAdaugaSite.UseVisualStyleBackColor = true;
            this.buttonAdaugaSite.Click += new System.EventHandler(this.buttonAdaugaSite_Click);
            // 
            // buttonDeschideSite
            // 
            this.buttonDeschideSite.Location = new System.Drawing.Point(1421, 130);
            this.buttonDeschideSite.Name = "buttonDeschideSite";
            this.buttonDeschideSite.Size = new System.Drawing.Size(269, 55);
            this.buttonDeschideSite.TabIndex = 14;
            this.buttonDeschideSite.Text = "Deschide site-ul";
            this.buttonDeschideSite.UseVisualStyleBackColor = true;
            this.buttonDeschideSite.Click += new System.EventHandler(this.buttonDeschideSite_Click);
            // 
            // buttonDeschideFormCategorie
            // 
            this.buttonDeschideFormCategorie.Location = new System.Drawing.Point(1421, 193);
            this.buttonDeschideFormCategorie.Name = "buttonDeschideFormCategorie";
            this.buttonDeschideFormCategorie.Size = new System.Drawing.Size(269, 51);
            this.buttonDeschideFormCategorie.TabIndex = 15;
            this.buttonDeschideFormCategorie.Text = "Deschide categoriile";
            this.buttonDeschideFormCategorie.UseVisualStyleBackColor = true;
            this.buttonDeschideFormCategorie.Click += new System.EventHandler(this.buttonDeschideFormCategorie_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonModificaSite, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonStergeSite, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1421, 251);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 69);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // buttonModificaSite
            // 
            this.buttonModificaSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModificaSite.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonModificaSite.Location = new System.Drawing.Point(3, 3);
            this.buttonModificaSite.Name = "buttonModificaSite";
            this.buttonModificaSite.Size = new System.Drawing.Size(112, 49);
            this.buttonModificaSite.TabIndex = 12;
            this.buttonModificaSite.Text = "Modifica";
            this.buttonModificaSite.UseVisualStyleBackColor = true;
            this.buttonModificaSite.Click += new System.EventHandler(this.buttonModificaSite_Click);
            // 
            // buttonStergeSite
            // 
            this.buttonStergeSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStergeSite.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonStergeSite.Location = new System.Drawing.Point(157, 3);
            this.buttonStergeSite.Name = "buttonStergeSite";
            this.buttonStergeSite.Size = new System.Drawing.Size(112, 49);
            this.buttonStergeSite.TabIndex = 13;
            this.buttonStergeSite.Text = "Sterge";
            this.buttonStergeSite.UseVisualStyleBackColor = true;
            this.buttonStergeSite.Click += new System.EventHandler(this.buttonStergeSite_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.buttonOpenFormExport);
            this.groupBox2.Controls.Add(this.txtCategorieCriteriu2);
            this.groupBox2.Controls.Add(this.txtDenSiteNoteCriteriu1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2DeschideCategoriile);
            this.groupBox2.Controls.Add(this.txtCriteriuCategorie);
            this.groupBox2.Controls.Add(this.txtCriteriuDenNote);
            this.groupBox2.Controls.Add(this.labelCriteriuCategorie);
            this.groupBox2.Controls.Add(this.labelCriteriuSite);
            this.groupBox2.Controls.Add(this.buttonCautaSite);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(32, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1739, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cauta site (criterii de cautare)";
            // 
            // buttonOpenFormExport
            // 
            this.buttonOpenFormExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenFormExport.Location = new System.Drawing.Point(963, 98);
            this.buttonOpenFormExport.Name = "buttonOpenFormExport";
            this.buttonOpenFormExport.Size = new System.Drawing.Size(242, 59);
            this.buttonOpenFormExport.TabIndex = 26;
            this.buttonOpenFormExport.Text = "Deschide Export to CSV";
            this.buttonOpenFormExport.UseVisualStyleBackColor = true;
            this.buttonOpenFormExport.Click += new System.EventHandler(this.buttonOpenFormExport_Click);
            // 
            // txtCategorieCriteriu2
            // 
            this.txtCategorieCriteriu2.Enabled = false;
            this.txtCategorieCriteriu2.Location = new System.Drawing.Point(1019, 66);
            this.txtCategorieCriteriu2.Name = "txtCategorieCriteriu2";
            this.txtCategorieCriteriu2.Size = new System.Drawing.Size(683, 31);
            this.txtCategorieCriteriu2.TabIndex = 25;
            // 
            // txtDenSiteNoteCriteriu1
            // 
            this.txtDenSiteNoteCriteriu1.Enabled = false;
            this.txtDenSiteNoteCriteriu1.Location = new System.Drawing.Point(1019, 28);
            this.txtDenSiteNoteCriteriu1.Name = "txtDenSiteNoteCriteriu1";
            this.txtDenSiteNoteCriteriu1.Size = new System.Drawing.Size(683, 31);
            this.txtDenSiteNoteCriteriu1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Den/site/note";
            // 
            // button2DeschideCategoriile
            // 
            this.button2DeschideCategoriile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2DeschideCategoriile.Location = new System.Drawing.Point(148, 98);
            this.button2DeschideCategoriile.Name = "button2DeschideCategoriile";
            this.button2DeschideCategoriile.Size = new System.Drawing.Size(242, 59);
            this.button2DeschideCategoriile.TabIndex = 21;
            this.button2DeschideCategoriile.Text = "Deschide categoriile";
            this.button2DeschideCategoriile.UseVisualStyleBackColor = true;
            this.button2DeschideCategoriile.Click += new System.EventHandler(this.button2DeschideCategoriile_Click);
            // 
            // txtCriteriuCategorie
            // 
            this.txtCriteriuCategorie.Location = new System.Drawing.Point(148, 66);
            this.txtCriteriuCategorie.Name = "txtCriteriuCategorie";
            this.txtCriteriuCategorie.Size = new System.Drawing.Size(726, 31);
            this.txtCriteriuCategorie.TabIndex = 19;
            // 
            // txtCriteriuDenNote
            // 
            this.txtCriteriuDenNote.Location = new System.Drawing.Point(148, 28);
            this.txtCriteriuDenNote.Name = "txtCriteriuDenNote";
            this.txtCriteriuDenNote.Size = new System.Drawing.Size(726, 31);
            this.txtCriteriuDenNote.TabIndex = 18;
            // 
            // labelCriteriuCategorie
            // 
            this.labelCriteriuCategorie.AutoSize = true;
            this.labelCriteriuCategorie.Location = new System.Drawing.Point(21, 69);
            this.labelCriteriuCategorie.Name = "labelCriteriuCategorie";
            this.labelCriteriuCategorie.Size = new System.Drawing.Size(94, 25);
            this.labelCriteriuCategorie.TabIndex = 17;
            this.labelCriteriuCategorie.Text = "Categorie";
            // 
            // labelCriteriuSite
            // 
            this.labelCriteriuSite.AutoSize = true;
            this.labelCriteriuSite.Location = new System.Drawing.Point(21, 31);
            this.labelCriteriuSite.Name = "labelCriteriuSite";
            this.labelCriteriuSite.Size = new System.Drawing.Size(131, 25);
            this.labelCriteriuSite.TabIndex = 16;
            this.labelCriteriuSite.Text = "Den/site/note";
            this.labelCriteriuSite.Click += new System.EventHandler(this.labelCriteriuSite_Click);
            // 
            // buttonCautaSite
            // 
            this.buttonCautaSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCautaSite.Location = new System.Drawing.Point(745, 97);
            this.buttonCautaSite.Name = "buttonCautaSite";
            this.buttonCautaSite.Size = new System.Drawing.Size(129, 59);
            this.buttonCautaSite.TabIndex = 15;
            this.buttonCautaSite.Text = "Cauta";
            this.buttonCautaSite.UseVisualStyleBackColor = true;
            this.buttonCautaSite.Click += new System.EventHandler(this.buttonCautaSite_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(35, 582);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1736, 310);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista site-uri (rezultat cautare)";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1730, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // buttonUrmator
            // 
            this.buttonUrmator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUrmator.Location = new System.Drawing.Point(601, 22);
            this.buttonUrmator.Name = "buttonUrmator";
            this.buttonUrmator.Size = new System.Drawing.Size(112, 47);
            this.buttonUrmator.TabIndex = 12;
            this.buttonUrmator.Text = "Urmator";
            this.buttonUrmator.UseVisualStyleBackColor = true;
            this.buttonUrmator.Click += new System.EventHandler(this.buttonUrmator_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAnterior.Location = new System.Drawing.Point(165, 22);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(108, 47);
            this.buttonAnterior.TabIndex = 13;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // labelPagina
            // 
            this.labelPagina.AutoSize = true;
            this.labelPagina.Location = new System.Drawing.Point(328, 33);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(22, 25);
            this.labelPagina.TabIndex = 15;
            this.labelPagina.Text = "1";
            this.labelPagina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPagina.Click += new System.EventHandler(this.labelPagina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "/";
            // 
            // labelPagina2
            // 
            this.labelPagina2.AutoSize = true;
            this.labelPagina2.Location = new System.Drawing.Point(524, 33);
            this.labelPagina2.Name = "labelPagina2";
            this.labelPagina2.Size = new System.Drawing.Size(22, 25);
            this.labelPagina2.TabIndex = 17;
            this.labelPagina2.Text = "1";
            this.labelPagina2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.buttonAnterior);
            this.groupBox4.Controls.Add(this.buttonUrmator);
            this.groupBox4.Controls.Add(this.labelPagina2);
            this.groupBox4.Controls.Add(this.labelPagina);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(38, 906);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1733, 82);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pagini lista site-uri ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1828, 1050);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Agenda2  vers.1.3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdSite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDeschideSite;
        private System.Windows.Forms.Button buttonStergeSite;
        private System.Windows.Forms.Button buttonModificaSite;
        private System.Windows.Forms.Button buttonAdaugaSite;
        private System.Windows.Forms.Button buttonGolesteDateSite;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelNoteSite;
        private System.Windows.Forms.Label labelCategorieSite;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.Label labelDenumireSite;
        private System.Windows.Forms.Button buttonCautaSite;
        private System.Windows.Forms.TextBox txtCriteriuCategorie;
        private System.Windows.Forms.TextBox txtCriteriuDenNote;
        private System.Windows.Forms.Label labelCriteriuCategorie;
        private System.Windows.Forms.Label labelCriteriuSite;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUrmator;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPagina2;
        private System.Windows.Forms.Button buttonDeschideFormCategorie;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2DeschideCategoriile;
        private System.Windows.Forms.TextBox txtCategorieCriteriu2;
        private System.Windows.Forms.TextBox txtDenSiteNoteCriteriu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenFormExport;
    }
}

