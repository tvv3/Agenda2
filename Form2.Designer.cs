
namespace Agenda2
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.buttonAdaugaCategorie = new System.Windows.Forms.Button();
            this.buttonStergeCategorie = new System.Windows.Forms.Button();
            this.buttonCautaCategorie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista categorii";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(360, 562);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(232, 48);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(360, 31);
            this.txtCategorie.TabIndex = 3;
            // 
            // buttonAdaugaCategorie
            // 
            this.buttonAdaugaCategorie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdaugaCategorie.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonAdaugaCategorie.Location = new System.Drawing.Point(658, 44);
            this.buttonAdaugaCategorie.Name = "buttonAdaugaCategorie";
            this.buttonAdaugaCategorie.Size = new System.Drawing.Size(112, 46);
            this.buttonAdaugaCategorie.TabIndex = 4;
            this.buttonAdaugaCategorie.Text = "Adauga";
            this.buttonAdaugaCategorie.UseVisualStyleBackColor = true;
            this.buttonAdaugaCategorie.Click += new System.EventHandler(this.buttonAdaugaCategorie_Click);
            // 
            // buttonStergeCategorie
            // 
            this.buttonStergeCategorie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStergeCategorie.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonStergeCategorie.Location = new System.Drawing.Point(658, 136);
            this.buttonStergeCategorie.Name = "buttonStergeCategorie";
            this.buttonStergeCategorie.Size = new System.Drawing.Size(112, 46);
            this.buttonStergeCategorie.TabIndex = 5;
            this.buttonStergeCategorie.Text = "Sterge";
            this.buttonStergeCategorie.UseVisualStyleBackColor = true;
            this.buttonStergeCategorie.Click += new System.EventHandler(this.buttonStergeCategorie_Click);
            // 
            // buttonCautaCategorie
            // 
            this.buttonCautaCategorie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCautaCategorie.Location = new System.Drawing.Point(658, 231);
            this.buttonCautaCategorie.Name = "buttonCautaCategorie";
            this.buttonCautaCategorie.Size = new System.Drawing.Size(112, 49);
            this.buttonCautaCategorie.TabIndex = 6;
            this.buttonCautaCategorie.Text = "Cauta";
            this.buttonCautaCategorie.UseVisualStyleBackColor = true;
            this.buttonCautaCategorie.Click += new System.EventHandler(this.buttonCautaCategorie_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(614, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 129);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inapoi la site-uri cu categoria curenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(614, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 129);
            this.button2.TabIndex = 8;
            this.button2.Text = "Inapoi la site-uri fara categoria curenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCautaCategorie);
            this.Controls.Add(this.buttonStergeCategorie);
            this.Controls.Add(this.buttonAdaugaCategorie);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Categorii";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Button buttonAdaugaCategorie;
        private System.Windows.Forms.Button buttonStergeCategorie;
        private System.Windows.Forms.Button buttonCautaCategorie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}