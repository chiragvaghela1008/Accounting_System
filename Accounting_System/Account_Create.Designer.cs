namespace Accounting_System
{
    partial class Account_Create
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Create));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlledgertype = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtpanno = new System.Windows.Forms.TextBox();
            this.txtaadharno = new System.Windows.Forms.TextBox();
            this.txtgstidno = new System.Windows.Forms.TextBox();
            this.ddlcity = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtopeningbalance = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblpanno = new System.Windows.Forms.Label();
            this.lblaadharno = new System.Windows.Forms.Label();
            this.lblgstidno = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblmobileno = new System.Windows.Forms.Label();
            this.txtnarration = new System.Windows.Forms.TextBox();
            this.lblnarration = new System.Windows.Forms.Label();
            this.lblopeningbalance = new System.Windows.Forms.Label();
            this.lblsubgroupname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtledgercode = new System.Windows.Forms.TextBox();
            this.lbluniquekey = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aDMLEDGERTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMLEDGERTYPEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.ddlledgertype);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.txtpanno);
            this.groupBox1.Controls.Add(this.txtaadharno);
            this.groupBox1.Controls.Add(this.txtgstidno);
            this.groupBox1.Controls.Add(this.ddlcity);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtmobileno);
            this.groupBox1.Controls.Add(this.txtopeningbalance);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.lblpanno);
            this.groupBox1.Controls.Add(this.lblaadharno);
            this.groupBox1.Controls.Add(this.lblgstidno);
            this.groupBox1.Controls.Add(this.lblcity);
            this.groupBox1.Controls.Add(this.lbladdress);
            this.groupBox1.Controls.Add(this.lblmobileno);
            this.groupBox1.Controls.Add(this.txtnarration);
            this.groupBox1.Controls.Add(this.lblnarration);
            this.groupBox1.Controls.Add(this.lblopeningbalance);
            this.groupBox1.Controls.Add(this.lblsubgroupname);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.txtledgercode);
            this.groupBox1.Controls.Add(this.lbluniquekey);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 429);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ddlledgertype
            // 
            this.ddlledgertype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlledgertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlledgertype.FormattingEnabled = true;
            this.ddlledgertype.Location = new System.Drawing.Point(214, 136);
            this.ddlledgertype.Name = "ddlledgertype";
            this.ddlledgertype.Size = new System.Drawing.Size(305, 33);
            this.ddlledgertype.TabIndex = 59;
            this.ddlledgertype.SelectedIndexChanged += new System.EventHandler(this.ddlledgertype_SelectedIndexChanged);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(740, 358);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 55);
            this.btnsave.TabIndex = 58;
            this.btnsave.Text = "Save";
            this.btnsave.UseCompatibleTextRendering = true;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(740, 358);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 55);
            this.btnupdate.TabIndex = 57;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.brnupdate_Click);
            // 
            // txtpanno
            // 
            this.txtpanno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpanno.Location = new System.Drawing.Point(670, 306);
            this.txtpanno.Name = "txtpanno";
            this.txtpanno.Size = new System.Drawing.Size(303, 30);
            this.txtpanno.TabIndex = 56;
            // 
            // txtaadharno
            // 
            this.txtaadharno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaadharno.Location = new System.Drawing.Point(670, 263);
            this.txtaadharno.Name = "txtaadharno";
            this.txtaadharno.Size = new System.Drawing.Size(303, 30);
            this.txtaadharno.TabIndex = 55;
            // 
            // txtgstidno
            // 
            this.txtgstidno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgstidno.Location = new System.Drawing.Point(670, 220);
            this.txtgstidno.Name = "txtgstidno";
            this.txtgstidno.Size = new System.Drawing.Size(303, 30);
            this.txtgstidno.TabIndex = 54;
            // 
            // ddlcity
            // 
            this.ddlcity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlcity.FormattingEnabled = true;
            this.ddlcity.Location = new System.Drawing.Point(669, 174);
            this.ddlcity.Name = "ddlcity";
            this.ddlcity.Size = new System.Drawing.Size(305, 33);
            this.ddlcity.TabIndex = 53;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(671, 93);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(303, 68);
            this.txtaddress.TabIndex = 52;
            this.txtaddress.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // txtmobileno
            // 
            this.txtmobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobileno.Location = new System.Drawing.Point(670, 50);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(303, 30);
            this.txtmobileno.TabIndex = 51;
            // 
            // txtopeningbalance
            // 
            this.txtopeningbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopeningbalance.Location = new System.Drawing.Point(214, 182);
            this.txtopeningbalance.Name = "txtopeningbalance";
            this.txtopeningbalance.Size = new System.Drawing.Size(303, 30);
            this.txtopeningbalance.TabIndex = 50;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(213, 93);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(303, 30);
            this.txtname.TabIndex = 48;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(861, 358);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(110, 55);
            this.btnclear.TabIndex = 46;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblpanno
            // 
            this.lblpanno.AutoSize = true;
            this.lblpanno.BackColor = System.Drawing.Color.Transparent;
            this.lblpanno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpanno.ForeColor = System.Drawing.Color.White;
            this.lblpanno.Location = new System.Drawing.Point(567, 306);
            this.lblpanno.Name = "lblpanno";
            this.lblpanno.Size = new System.Drawing.Size(88, 25);
            this.lblpanno.TabIndex = 26;
            this.lblpanno.Text = "Pan No :";
            this.lblpanno.Click += new System.EventHandler(this.lblpanno_Click);
            // 
            // lblaadharno
            // 
            this.lblaadharno.AutoSize = true;
            this.lblaadharno.BackColor = System.Drawing.Color.Transparent;
            this.lblaadharno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaadharno.ForeColor = System.Drawing.Color.White;
            this.lblaadharno.Location = new System.Drawing.Point(533, 261);
            this.lblaadharno.Name = "lblaadharno";
            this.lblaadharno.Size = new System.Drawing.Size(117, 25);
            this.lblaadharno.TabIndex = 24;
            this.lblaadharno.Text = "Aadhar No :";
            // 
            // lblgstidno
            // 
            this.lblgstidno.AutoSize = true;
            this.lblgstidno.BackColor = System.Drawing.Color.Transparent;
            this.lblgstidno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgstidno.ForeColor = System.Drawing.Color.White;
            this.lblgstidno.Location = new System.Drawing.Point(536, 220);
            this.lblgstidno.Name = "lblgstidno";
            this.lblgstidno.Size = new System.Drawing.Size(119, 25);
            this.lblgstidno.TabIndex = 22;
            this.lblgstidno.Text = "GST ID No :";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.BackColor = System.Drawing.Color.Transparent;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.ForeColor = System.Drawing.Color.White;
            this.lblcity.Location = new System.Drawing.Point(598, 178);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(57, 25);
            this.lblcity.TabIndex = 20;
            this.lblcity.Text = "City :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.White;
            this.lbladdress.Location = new System.Drawing.Point(559, 100);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(96, 25);
            this.lbladdress.TabIndex = 18;
            this.lbladdress.Text = "Address :";
            // 
            // lblmobileno
            // 
            this.lblmobileno.AutoSize = true;
            this.lblmobileno.BackColor = System.Drawing.Color.Transparent;
            this.lblmobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobileno.ForeColor = System.Drawing.Color.White;
            this.lblmobileno.Location = new System.Drawing.Point(544, 53);
            this.lblmobileno.Name = "lblmobileno";
            this.lblmobileno.Size = new System.Drawing.Size(111, 25);
            this.lblmobileno.TabIndex = 16;
            this.lblmobileno.Text = "Mobile No :";
            // 
            // txtnarration
            // 
            this.txtnarration.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnarration.Location = new System.Drawing.Point(214, 225);
            this.txtnarration.Multiline = true;
            this.txtnarration.Name = "txtnarration";
            this.txtnarration.Size = new System.Drawing.Size(303, 105);
            this.txtnarration.TabIndex = 15;
            this.txtnarration.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblnarration
            // 
            this.lblnarration.AutoSize = true;
            this.lblnarration.BackColor = System.Drawing.Color.Transparent;
            this.lblnarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnarration.ForeColor = System.Drawing.Color.White;
            this.lblnarration.Location = new System.Drawing.Point(97, 224);
            this.lblnarration.Name = "lblnarration";
            this.lblnarration.Size = new System.Drawing.Size(102, 25);
            this.lblnarration.TabIndex = 14;
            this.lblnarration.Text = "Narration :";
            // 
            // lblopeningbalance
            // 
            this.lblopeningbalance.AutoSize = true;
            this.lblopeningbalance.BackColor = System.Drawing.Color.Transparent;
            this.lblopeningbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopeningbalance.ForeColor = System.Drawing.Color.White;
            this.lblopeningbalance.Location = new System.Drawing.Point(25, 183);
            this.lblopeningbalance.Name = "lblopeningbalance";
            this.lblopeningbalance.Size = new System.Drawing.Size(174, 25);
            this.lblopeningbalance.TabIndex = 12;
            this.lblopeningbalance.Text = "Opening Balance :";
            // 
            // lblsubgroupname
            // 
            this.lblsubgroupname.AutoSize = true;
            this.lblsubgroupname.BackColor = System.Drawing.Color.Transparent;
            this.lblsubgroupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubgroupname.ForeColor = System.Drawing.Color.White;
            this.lblsubgroupname.Location = new System.Drawing.Point(60, 140);
            this.lblsubgroupname.Name = "lblsubgroupname";
            this.lblsubgroupname.Size = new System.Drawing.Size(139, 25);
            this.lblsubgroupname.TabIndex = 10;
            this.lblsubgroupname.Text = "Ledger Type  :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(58, 96);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(141, 25);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Ledger Name :";
            // 
            // txtledgercode
            // 
            this.txtledgercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtledgercode.Location = new System.Drawing.Point(212, 50);
            this.txtledgercode.Name = "txtledgercode";
            this.txtledgercode.Size = new System.Drawing.Size(303, 30);
            this.txtledgercode.TabIndex = 7;
            this.txtledgercode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbluniquekey
            // 
            this.lbluniquekey.AutoSize = true;
            this.lbluniquekey.BackColor = System.Drawing.Color.Transparent;
            this.lbluniquekey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluniquekey.ForeColor = System.Drawing.Color.White;
            this.lbluniquekey.Location = new System.Drawing.Point(67, 51);
            this.lbluniquekey.Name = "lbluniquekey";
            this.lbluniquekey.Size = new System.Drawing.Size(132, 25);
            this.lbluniquekey.TabIndex = 2;
            this.lbluniquekey.Text = "Ledger code :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(222, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 17);
            this.lblID.TabIndex = 60;
            this.lblID.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(985, 348);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // aDMLEDGERTYPEBindingSource
            // 
            this.aDMLEDGERTYPEBindingSource.DataSource = typeof(Accounting_System.ADM_LEDGER_TYPE);
            // 
            // Account_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 784);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Account_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_create";
            this.Load += new System.EventHandler(this.Account_Create_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMLEDGERTYPEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbluniquekey;
        private System.Windows.Forms.TextBox txtnarration;
        private System.Windows.Forms.Label lblnarration;
        private System.Windows.Forms.Label lblopeningbalance;
        private System.Windows.Forms.Label lblsubgroupname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtledgercode;
        private System.Windows.Forms.Label lblmobileno;
        private System.Windows.Forms.Label lblpanno;
        private System.Windows.Forms.Label lblaadharno;
        private System.Windows.Forms.Label lblgstidno;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtopeningbalance;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.TextBox txtpanno;
        private System.Windows.Forms.TextBox txtaadharno;
        private System.Windows.Forms.TextBox txtgstidno;
        private System.Windows.Forms.ComboBox ddlcity;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox ddlledgertype;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aDMLEDGERTYPEBindingSource;
        private System.Windows.Forms.Label lblID;
    }
}