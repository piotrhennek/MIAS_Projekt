namespace MIAS_Projekt
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
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.CheckTime = new System.Windows.Forms.Button();
            this.gbSqlServer = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRepoSqlTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEFSqlTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSqlServerVici = new System.Windows.Forms.GroupBox();
            this.lbSqlServerCSTime = new System.Windows.Forms.Label();
            this.gbOracle = new System.Windows.Forms.GroupBox();
            this.gbEFORacle = new System.Windows.Forms.GroupBox();
            this.lbEFOracleTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbRepoOracleTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbOracleCSTime = new System.Windows.Forms.Label();
            this.lbQuery = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbSqlServer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSqlServerVici.SuspendLayout();
            this.gbOracle.SuspendLayout();
            this.gbEFORacle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(130, 229);
            this.tbQuery.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(470, 66);
            this.tbQuery.TabIndex = 0;
            // 
            // CheckTime
            // 
            this.CheckTime.Location = new System.Drawing.Point(514, 310);
            this.CheckTime.Margin = new System.Windows.Forms.Padding(2);
            this.CheckTime.Name = "CheckTime";
            this.CheckTime.Size = new System.Drawing.Size(86, 47);
            this.CheckTime.TabIndex = 1;
            this.CheckTime.Text = "Sprawdź czas";
            this.CheckTime.UseVisualStyleBackColor = true;
            this.CheckTime.Click += new System.EventHandler(this.CheckTime_Click);
            // 
            // gbSqlServer
            // 
            this.gbSqlServer.Controls.Add(this.groupBox2);
            this.gbSqlServer.Controls.Add(this.groupBox1);
            this.gbSqlServer.Controls.Add(this.label1);
            this.gbSqlServer.Controls.Add(this.gbSqlServerVici);
            this.gbSqlServer.Location = new System.Drawing.Point(9, 10);
            this.gbSqlServer.Margin = new System.Windows.Forms.Padding(2);
            this.gbSqlServer.Name = "gbSqlServer";
            this.gbSqlServer.Padding = new System.Windows.Forms.Padding(2);
            this.gbSqlServer.Size = new System.Drawing.Size(282, 190);
            this.gbSqlServer.TabIndex = 3;
            this.gbSqlServer.TabStop = false;
            this.gbSqlServer.Text = "MSSQL server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRepoSqlTime);
            this.groupBox2.Location = new System.Drawing.Point(4, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(273, 43);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repository";
            // 
            // lbRepoSqlTime
            // 
            this.lbRepoSqlTime.AutoSize = true;
            this.lbRepoSqlTime.Location = new System.Drawing.Point(114, 22);
            this.lbRepoSqlTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRepoSqlTime.Name = "lbRepoSqlTime";
            this.lbRepoSqlTime.Size = new System.Drawing.Size(30, 13);
            this.lbRepoSqlTime.TabIndex = 0;
            this.lbRepoSqlTime.Text = "Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEFSqlTime);
            this.groupBox1.Location = new System.Drawing.Point(4, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(273, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EntityFramework6";
            // 
            // lbEFSqlTime
            // 
            this.lbEFSqlTime.AutoSize = true;
            this.lbEFSqlTime.Location = new System.Drawing.Point(114, 15);
            this.lbEFSqlTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEFSqlTime.Name = "lbEFSqlTime";
            this.lbEFSqlTime.Size = new System.Drawing.Size(30, 13);
            this.lbEFSqlTime.TabIndex = 0;
            this.lbEFSqlTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Średni czas zapytania [ms]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbSqlServerVici
            // 
            this.gbSqlServerVici.Controls.Add(this.lbSqlServerCSTime);
            this.gbSqlServerVici.Location = new System.Drawing.Point(4, 32);
            this.gbSqlServerVici.Margin = new System.Windows.Forms.Padding(2);
            this.gbSqlServerVici.Name = "gbSqlServerVici";
            this.gbSqlServerVici.Padding = new System.Windows.Forms.Padding(2);
            this.gbSqlServerVici.Size = new System.Drawing.Size(273, 54);
            this.gbSqlServerVici.TabIndex = 0;
            this.gbSqlServerVici.TabStop = false;
            this.gbSqlServerVici.Text = "ViciCoolStorage";
            // 
            // lbSqlServerCSTime
            // 
            this.lbSqlServerCSTime.AutoSize = true;
            this.lbSqlServerCSTime.Location = new System.Drawing.Point(114, 27);
            this.lbSqlServerCSTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSqlServerCSTime.Name = "lbSqlServerCSTime";
            this.lbSqlServerCSTime.Size = new System.Drawing.Size(30, 13);
            this.lbSqlServerCSTime.TabIndex = 0;
            this.lbSqlServerCSTime.Text = "Time";
            // 
            // gbOracle
            // 
            this.gbOracle.Controls.Add(this.gbEFORacle);
            this.gbOracle.Controls.Add(this.groupBox3);
            this.gbOracle.Controls.Add(this.label3);
            this.gbOracle.Controls.Add(this.groupBox4);
            this.gbOracle.Location = new System.Drawing.Point(308, 10);
            this.gbOracle.Margin = new System.Windows.Forms.Padding(2);
            this.gbOracle.Name = "gbOracle";
            this.gbOracle.Padding = new System.Windows.Forms.Padding(2);
            this.gbOracle.Size = new System.Drawing.Size(292, 190);
            this.gbOracle.TabIndex = 4;
            this.gbOracle.TabStop = false;
            this.gbOracle.Text = "Oracle server";
            // 
            // gbEFORacle
            // 
            this.gbEFORacle.Controls.Add(this.lbEFOracleTime);
            this.gbEFORacle.Location = new System.Drawing.Point(8, 91);
            this.gbEFORacle.Margin = new System.Windows.Forms.Padding(2);
            this.gbEFORacle.Name = "gbEFORacle";
            this.gbEFORacle.Padding = new System.Windows.Forms.Padding(2);
            this.gbEFORacle.Size = new System.Drawing.Size(280, 46);
            this.gbEFORacle.TabIndex = 4;
            this.gbEFORacle.TabStop = false;
            this.gbEFORacle.Text = "EntityFramework6";
            // 
            // lbEFOracleTime
            // 
            this.lbEFOracleTime.AutoSize = true;
            this.lbEFOracleTime.Location = new System.Drawing.Point(128, 15);
            this.lbEFOracleTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEFOracleTime.Name = "lbEFOracleTime";
            this.lbEFOracleTime.Size = new System.Drawing.Size(30, 13);
            this.lbEFOracleTime.TabIndex = 0;
            this.lbEFOracleTime.Text = "Time";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbRepoOracleTime);
            this.groupBox3.Location = new System.Drawing.Point(8, 142);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(280, 43);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repository";
            // 
            // lbRepoOracleTime
            // 
            this.lbRepoOracleTime.AutoSize = true;
            this.lbRepoOracleTime.Location = new System.Drawing.Point(128, 15);
            this.lbRepoOracleTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRepoOracleTime.Name = "lbRepoOracleTime";
            this.lbRepoOracleTime.Size = new System.Drawing.Size(30, 13);
            this.lbRepoOracleTime.TabIndex = 0;
            this.lbRepoOracleTime.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Średni czas zapytania [ms]";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbOracleCSTime);
            this.groupBox4.Location = new System.Drawing.Point(8, 32);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(280, 54);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ViciCoolStorage";
            // 
            // lbOracleCSTime
            // 
            this.lbOracleCSTime.AutoSize = true;
            this.lbOracleCSTime.Location = new System.Drawing.Point(128, 27);
            this.lbOracleCSTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOracleCSTime.Name = "lbOracleCSTime";
            this.lbOracleCSTime.Size = new System.Drawing.Size(30, 13);
            this.lbOracleCSTime.TabIndex = 0;
            this.lbOracleCSTime.Text = "Time";
            // 
            // lbQuery
            // 
            this.lbQuery.AutoSize = true;
            this.lbQuery.Location = new System.Drawing.Point(12, 232);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(57, 13);
            this.lbQuery.TabIndex = 5;
            this.lbQuery.Text = "Zapytanie:";
            this.lbQuery.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ilość powtórzeń";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 368);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbQuery);
            this.Controls.Add(this.gbOracle);
            this.Controls.Add(this.gbSqlServer);
            this.Controls.Add(this.CheckTime);
            this.Controls.Add(this.tbQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSqlServer.ResumeLayout(false);
            this.gbSqlServer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSqlServerVici.ResumeLayout(false);
            this.gbSqlServerVici.PerformLayout();
            this.gbOracle.ResumeLayout(false);
            this.gbOracle.PerformLayout();
            this.gbEFORacle.ResumeLayout(false);
            this.gbEFORacle.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Button CheckTime;
        private System.Windows.Forms.GroupBox gbSqlServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSqlServerVici;
        private System.Windows.Forms.Label lbSqlServerCSTime;
        private System.Windows.Forms.GroupBox gbOracle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbOracleCSTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEFSqlTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbRepoSqlTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbRepoOracleTime;
        private System.Windows.Forms.GroupBox gbEFORacle;
        private System.Windows.Forms.Label lbEFOracleTime;
        private System.Windows.Forms.Label lbQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

