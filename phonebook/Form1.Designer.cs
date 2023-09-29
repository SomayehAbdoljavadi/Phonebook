namespace phonebook
{
    partial class Form1
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bbtnnew = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.tnnext = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.tnfirst = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbfeild = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(85, 18);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(222, 27);
            this.txtname.TabIndex = 1;
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(85, 51);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.ReadOnly = true;
            this.txtfamily.Size = new System.Drawing.Size(222, 27);
            this.txtfamily.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Family:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(85, 117);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(222, 89);
            this.txtaddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // txttell
            // 
            this.txttell.Location = new System.Drawing.Point(85, 84);
            this.txttell.Name = "txttell";
            this.txttell.ReadOnly = true;
            this.txttell.Size = new System.Drawing.Size(222, 27);
            this.txttell.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tell:";
            // 
            // Bbtnnew
            // 
            this.Bbtnnew.Location = new System.Drawing.Point(9, 225);
            this.Bbtnnew.Name = "Bbtnnew";
            this.Bbtnnew.Size = new System.Drawing.Size(70, 37);
            this.Bbtnnew.TabIndex = 8;
            this.Bbtnnew.Text = "New";
            this.Bbtnnew.UseVisualStyleBackColor = true;
            this.Bbtnnew.Click += new System.EventHandler(this.Bbtnnew_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(237, 225);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(70, 37);
            this.btndel.TabIndex = 9;
            this.btndel.Text = "Del";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(161, 225);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(70, 37);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(85, 225);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(70, 37);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tnnext
            // 
            this.tnnext.Location = new System.Drawing.Point(85, 268);
            this.tnnext.Name = "tnnext";
            this.tnnext.Size = new System.Drawing.Size(70, 37);
            this.tnnext.TabIndex = 15;
            this.tnnext.Text = "Next";
            this.tnnext.UseVisualStyleBackColor = true;
            this.tnnext.Click += new System.EventHandler(this.tnnext_Click);
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(161, 268);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(70, 37);
            this.btnpre.TabIndex = 14;
            this.btnpre.Text = "Pre..";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(237, 268);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(70, 37);
            this.btnlast.TabIndex = 13;
            this.btnlast.Text = "Last";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // tnfirst
            // 
            this.tnfirst.Location = new System.Drawing.Point(9, 268);
            this.tnfirst.Name = "tnfirst";
            this.tnfirst.Size = new System.Drawing.Size(70, 37);
            this.tnfirst.TabIndex = 12;
            this.tnfirst.Text = "First";
            this.tnfirst.UseVisualStyleBackColor = true;
            this.tnfirst.Click += new System.EventHandler(this.tnfirst_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search By:";
            // 
            // cmbfeild
            // 
            this.cmbfeild.DisplayMember = "Lastname";
            this.cmbfeild.FormattingEnabled = true;
            this.cmbfeild.Items.AddRange(new object[] {
            "Firstname",
            "Lastname",
            "Phoneno",
            "address"});
            this.cmbfeild.Location = new System.Drawing.Point(572, 6);
            this.cmbfeild.Name = "cmbfeild";
            this.cmbfeild.Size = new System.Drawing.Size(121, 27);
            this.cmbfeild.TabIndex = 17;
            this.cmbfeild.Text = "Lastname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search For:";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(572, 43);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(121, 27);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(581, 84);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(93, 33);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(365, 152);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(341, 6);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 105);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 22;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            this.pic1.MouseLeave += new System.EventHandler(this.pic1_MouseLeave);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Enabled = false;
            this.BtnBrowse.Location = new System.Drawing.Point(341, 117);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(100, 30);
            this.BtnBrowse.TabIndex = 23;
            this.BtnBrowse.Text = "Browse...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 317);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbfeild);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tnnext);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.tnfirst);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.Bbtnnew);
            this.Controls.Add(this.txttell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bbtnnew;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button tnnext;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button tnfirst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbfeild;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

