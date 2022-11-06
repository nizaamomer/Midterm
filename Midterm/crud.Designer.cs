namespace Midterm
{
    partial class crud
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chekurdish = new System.Windows.Forms.CheckBox();
            this.chekenglish = new System.Windows.Forms.CheckBox();
            this.chekfranch = new System.Windows.Forms.CheckBox();
            this.chekspain = new System.Windows.Forms.CheckBox();
            this.rmale = new System.Windows.Forms.RadioButton();
            this.rfemale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnfind = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(69, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(147, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(69, 92);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(147, 20);
            this.txtusername.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Song",
            "Write",
            "Run",
            "Gym",
            "Game",
            "GOT"});
            this.comboBox1.Location = new System.Drawing.Point(69, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // chekurdish
            // 
            this.chekurdish.AutoSize = true;
            this.chekurdish.Location = new System.Drawing.Point(73, 265);
            this.chekurdish.Name = "chekurdish";
            this.chekurdish.Size = new System.Drawing.Size(61, 17);
            this.chekurdish.TabIndex = 4;
            this.chekurdish.Text = "Kurdish";
            this.chekurdish.UseVisualStyleBackColor = true;
            // 
            // chekenglish
            // 
            this.chekenglish.AutoSize = true;
            this.chekenglish.Location = new System.Drawing.Point(169, 265);
            this.chekenglish.Name = "chekenglish";
            this.chekenglish.Size = new System.Drawing.Size(60, 17);
            this.chekenglish.TabIndex = 5;
            this.chekenglish.Text = "English";
            this.chekenglish.UseVisualStyleBackColor = true;
            // 
            // chekfranch
            // 
            this.chekfranch.AutoSize = true;
            this.chekfranch.Location = new System.Drawing.Point(73, 304);
            this.chekfranch.Name = "chekfranch";
            this.chekfranch.Size = new System.Drawing.Size(59, 17);
            this.chekfranch.TabIndex = 6;
            this.chekfranch.Text = "Franch";
            this.chekfranch.UseVisualStyleBackColor = true;
            // 
            // chekspain
            // 
            this.chekspain.AutoSize = true;
            this.chekspain.Location = new System.Drawing.Point(169, 304);
            this.chekspain.Name = "chekspain";
            this.chekspain.Size = new System.Drawing.Size(53, 17);
            this.chekspain.TabIndex = 7;
            this.chekspain.Text = "Spain";
            this.chekspain.UseVisualStyleBackColor = true;
            // 
            // rmale
            // 
            this.rmale.AutoSize = true;
            this.rmale.Location = new System.Drawing.Point(67, 135);
            this.rmale.Name = "rmale";
            this.rmale.Size = new System.Drawing.Size(48, 17);
            this.rmale.TabIndex = 8;
            this.rmale.TabStop = true;
            this.rmale.Text = "Male";
            this.rmale.UseVisualStyleBackColor = true;
            // 
            // rfemale
            // 
            this.rfemale.AutoSize = true;
            this.rfemale.Location = new System.Drawing.Point(163, 135);
            this.rfemale.Name = "rfemale";
            this.rfemale.Size = new System.Drawing.Size(59, 17);
            this.rfemale.TabIndex = 9;
            this.rfemale.TabStop = true;
            this.rfemale.Text = "Female";
            this.rfemale.UseVisualStyleBackColor = true;
            this.rfemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Favourite: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birth: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Language: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gender: ";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.Coral;
            this.btninsert.Location = new System.Drawing.Point(16, 369);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(78, 31);
            this.btninsert.TabIndex = 16;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnupdate.Location = new System.Drawing.Point(133, 369);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(83, 31);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.Location = new System.Drawing.Point(692, 60);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(80, 29);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 343);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.SeaGreen;
            this.btnfind.Location = new System.Drawing.Point(572, 60);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(96, 29);
            this.btnfind.TabIndex = 20;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(296, 65);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(246, 20);
            this.txtfind.TabIndex = 21;
            // 
            // crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rfemale);
            this.Controls.Add(this.rmale);
            this.Controls.Add(this.chekspain);
            this.Controls.Add(this.chekfranch);
            this.Controls.Add(this.chekenglish);
            this.Controls.Add(this.chekurdish);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtid);
            this.Name = "crud";
            this.Text = "crud2";
            this.Load += new System.EventHandler(this.crud2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chekurdish;
        private System.Windows.Forms.CheckBox chekenglish;
        private System.Windows.Forms.CheckBox chekfranch;
        private System.Windows.Forms.CheckBox chekspain;
        private System.Windows.Forms.RadioButton rmale;
        private System.Windows.Forms.RadioButton rfemale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox txtfind;
    }
}