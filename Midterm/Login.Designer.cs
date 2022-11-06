namespace Midterm
{
    partial class Login
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.ForeColor = System.Drawing.Color.IndianRed;
            this.txtusername.Location = new System.Drawing.Point(206, 91);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(116, 21);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.ForeColor = System.Drawing.Color.IndianRed;
            this.txtpassword.Location = new System.Drawing.Point(206, 139);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(116, 21);
            this.txtpassword.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnlogin.Font = new System.Drawing.Font("Magnolia Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(206, 196);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(116, 35);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "go to Dynamic";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumOrchid;
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(321, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "go to Crud";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

