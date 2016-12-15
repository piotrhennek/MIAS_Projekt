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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEFSqlRows = new System.Windows.Forms.Label();
            this.lbEFSqlTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSqlServerVici = new System.Windows.Forms.GroupBox();
            this.lbSqlServerCSRows = new System.Windows.Forms.Label();
            this.lbSqlServerCSTime = new System.Windows.Forms.Label();
            this.gbOracle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbOracleCSRows = new System.Windows.Forms.Label();
            this.lbOracleCSTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbRepoSqlTime = new System.Windows.Forms.Label();
            this.lbRepoSqlRows = new System.Windows.Forms.Label();
            this.lbRepoOracleTime = new System.Windows.Forms.Label();
            this.lbRepoOracleRows = new System.Windows.Forms.Label();
            this.gbEFORacle = new System.Windows.Forms.GroupBox();
            this.lbEFOracleTime = new System.Windows.Forms.Label();
            this.lbEFOracleRows = new System.Windows.Forms.Label();
            this.gbSqlServer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSqlServerVici.SuspendLayout();
            this.gbOracle.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbEFORacle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(12, 361);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(376, 80);
            this.tbQuery.TabIndex = 0;
            // 
            // CheckTime
            // 
            this.CheckTime.Location = new System.Drawing.Point(420, 372);
            this.CheckTime.Name = "CheckTime";
            this.CheckTime.Size = new System.Drawing.Size(114, 58);
            this.CheckTime.TabIndex = 1;
            this.CheckTime.Text = "Sprawdź czas";
            this.CheckTime.UseVisualStyleBackColor = true;
            this.CheckTime.Click += new System.EventHandler(this.CheckTime_Click);
            // 
            // gbSqlServer
            // 
            this.gbSqlServer.Controls.Add(this.groupBox2);
            this.gbSqlServer.Controls.Add(this.groupBox1);
            this.gbSqlServer.Controls.Add(this.label2);
            this.gbSqlServer.Controls.Add(this.label1);
            this.gbSqlServer.Controls.Add(this.gbSqlServerVici);
            this.gbSqlServer.Location = new System.Drawing.Point(12, 12);
            this.gbSqlServer.Name = "gbSqlServer";
            this.gbSqlServer.Size = new System.Drawing.Size(376, 234);
            this.gbSqlServer.TabIndex = 3;
            this.gbSqlServer.TabStop = false;
            this.gbSqlServer.Text = "MSSQL server";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEFSqlRows);
            this.groupBox1.Controls.Add(this.lbEFSqlTime);
            this.groupBox1.Location = new System.Drawing.Point(6, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EntityFramework6";
            // 
            // lbEFSqlRows
            // 
            this.lbEFSqlRows.AutoSize = true;
            this.lbEFSqlRows.Location = new System.Drawing.Point(298, 18);
            this.lbEFSqlRows.Name = "lbEFSqlRows";
            this.lbEFSqlRows.Size = new System.Drawing.Size(42, 17);
            this.lbEFSqlRows.TabIndex = 1;
            this.lbEFSqlRows.Text = "Rows";
            // 
            // lbEFSqlTime
            // 
            this.lbEFSqlTime.AutoSize = true;
            this.lbEFSqlTime.Location = new System.Drawing.Point(152, 18);
            this.lbEFSqlTime.Name = "lbEFSqlTime";
            this.lbEFSqlTime.Size = new System.Drawing.Size(39, 17);
            this.lbEFSqlTime.TabIndex = 0;
            this.lbEFSqlTime.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Czas";
            // 
            // gbSqlServerVici
            // 
            this.gbSqlServerVici.Controls.Add(this.lbSqlServerCSRows);
            this.gbSqlServerVici.Controls.Add(this.lbSqlServerCSTime);
            this.gbSqlServerVici.Location = new System.Drawing.Point(6, 40);
            this.gbSqlServerVici.Name = "gbSqlServerVici";
            this.gbSqlServerVici.Size = new System.Drawing.Size(364, 66);
            this.gbSqlServerVici.TabIndex = 0;
            this.gbSqlServerVici.TabStop = false;
            this.gbSqlServerVici.Text = "ViciCoolStorage";
            // 
            // lbSqlServerCSRows
            // 
            this.lbSqlServerCSRows.AutoSize = true;
            this.lbSqlServerCSRows.Location = new System.Drawing.Point(302, 33);
            this.lbSqlServerCSRows.Name = "lbSqlServerCSRows";
            this.lbSqlServerCSRows.Size = new System.Drawing.Size(42, 17);
            this.lbSqlServerCSRows.TabIndex = 1;
            this.lbSqlServerCSRows.Text = "Rows";
            // 
            // lbSqlServerCSTime
            // 
            this.lbSqlServerCSTime.AutoSize = true;
            this.lbSqlServerCSTime.Location = new System.Drawing.Point(152, 33);
            this.lbSqlServerCSTime.Name = "lbSqlServerCSTime";
            this.lbSqlServerCSTime.Size = new System.Drawing.Size(39, 17);
            this.lbSqlServerCSTime.TabIndex = 0;
            this.lbSqlServerCSTime.Text = "Time";
            // 
            // gbOracle
            // 
            this.gbOracle.Controls.Add(this.gbEFORacle);
            this.gbOracle.Controls.Add(this.groupBox3);
            this.gbOracle.Controls.Add(this.label4);
            this.gbOracle.Controls.Add(this.label3);
            this.gbOracle.Controls.Add(this.groupBox4);
            this.gbOracle.Location = new System.Drawing.Point(410, 12);
            this.gbOracle.Name = "gbOracle";
            this.gbOracle.Size = new System.Drawing.Size(390, 234);
            this.gbOracle.TabIndex = 4;
            this.gbOracle.TabStop = false;
            this.gbOracle.Text = "Oracle server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Czas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbOracleCSRows);
            this.groupBox4.Controls.Add(this.lbOracleCSTime);
            this.groupBox4.Location = new System.Drawing.Point(10, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 66);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ViciCoolStorage";
            // 
            // lbOracleCSRows
            // 
            this.lbOracleCSRows.AutoSize = true;
            this.lbOracleCSRows.Location = new System.Drawing.Point(311, 33);
            this.lbOracleCSRows.Name = "lbOracleCSRows";
            this.lbOracleCSRows.Size = new System.Drawing.Size(42, 17);
            this.lbOracleCSRows.TabIndex = 1;
            this.lbOracleCSRows.Text = "Rows";
            // 
            // lbOracleCSTime
            // 
            this.lbOracleCSTime.AutoSize = true;
            this.lbOracleCSTime.Location = new System.Drawing.Point(171, 33);
            this.lbOracleCSTime.Name = "lbOracleCSTime";
            this.lbOracleCSTime.Size = new System.Drawing.Size(39, 17);
            this.lbOracleCSTime.TabIndex = 0;
            this.lbOracleCSTime.Text = "Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRepoSqlRows);
            this.groupBox2.Controls.Add(this.lbRepoSqlTime);
            this.groupBox2.Location = new System.Drawing.Point(6, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repository";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbRepoOracleRows);
            this.groupBox3.Controls.Add(this.lbRepoOracleTime);
            this.groupBox3.Location = new System.Drawing.Point(10, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 53);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repository";
            // 
            // lbRepoSqlTime
            // 
            this.lbRepoSqlTime.AutoSize = true;
            this.lbRepoSqlTime.Location = new System.Drawing.Point(152, 27);
            this.lbRepoSqlTime.Name = "lbRepoSqlTime";
            this.lbRepoSqlTime.Size = new System.Drawing.Size(39, 17);
            this.lbRepoSqlTime.TabIndex = 0;
            this.lbRepoSqlTime.Text = "Time";
            // 
            // lbRepoSqlRows
            // 
            this.lbRepoSqlRows.AutoSize = true;
            this.lbRepoSqlRows.Location = new System.Drawing.Point(298, 27);
            this.lbRepoSqlRows.Name = "lbRepoSqlRows";
            this.lbRepoSqlRows.Size = new System.Drawing.Size(42, 17);
            this.lbRepoSqlRows.TabIndex = 1;
            this.lbRepoSqlRows.Text = "Rows";
            // 
            // lbRepoOracleTime
            // 
            this.lbRepoOracleTime.AutoSize = true;
            this.lbRepoOracleTime.Location = new System.Drawing.Point(171, 18);
            this.lbRepoOracleTime.Name = "lbRepoOracleTime";
            this.lbRepoOracleTime.Size = new System.Drawing.Size(39, 17);
            this.lbRepoOracleTime.TabIndex = 0;
            this.lbRepoOracleTime.Text = "Time";
            // 
            // lbRepoOracleRows
            // 
            this.lbRepoOracleRows.AutoSize = true;
            this.lbRepoOracleRows.Location = new System.Drawing.Point(311, 18);
            this.lbRepoOracleRows.Name = "lbRepoOracleRows";
            this.lbRepoOracleRows.Size = new System.Drawing.Size(42, 17);
            this.lbRepoOracleRows.TabIndex = 1;
            this.lbRepoOracleRows.Text = "Rows";
            // 
            // gbEFORacle
            // 
            this.gbEFORacle.Controls.Add(this.lbEFOracleRows);
            this.gbEFORacle.Controls.Add(this.lbEFOracleTime);
            this.gbEFORacle.Location = new System.Drawing.Point(10, 112);
            this.gbEFORacle.Name = "gbEFORacle";
            this.gbEFORacle.Size = new System.Drawing.Size(374, 57);
            this.gbEFORacle.TabIndex = 4;
            this.gbEFORacle.TabStop = false;
            this.gbEFORacle.Text = "EntityFramework6";
            // 
            // lbEFOracleTime
            // 
            this.lbEFOracleTime.AutoSize = true;
            this.lbEFOracleTime.Location = new System.Drawing.Point(171, 18);
            this.lbEFOracleTime.Name = "lbEFOracleTime";
            this.lbEFOracleTime.Size = new System.Drawing.Size(39, 17);
            this.lbEFOracleTime.TabIndex = 0;
            this.lbEFOracleTime.Text = "Time";
            // 
            // lbEFOracleRows
            // 
            this.lbEFOracleRows.AutoSize = true;
            this.lbEFOracleRows.Location = new System.Drawing.Point(311, 18);
            this.lbEFOracleRows.Name = "lbEFOracleRows";
            this.lbEFOracleRows.Size = new System.Drawing.Size(42, 17);
            this.lbEFOracleRows.TabIndex = 1;
            this.lbEFOracleRows.Text = "Rows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 453);
            this.Controls.Add(this.gbOracle);
            this.Controls.Add(this.gbSqlServer);
            this.Controls.Add(this.CheckTime);
            this.Controls.Add(this.tbQuery);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSqlServer.ResumeLayout(false);
            this.gbSqlServer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSqlServerVici.ResumeLayout(false);
            this.gbSqlServerVici.PerformLayout();
            this.gbOracle.ResumeLayout(false);
            this.gbOracle.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbEFORacle.ResumeLayout(false);
            this.gbEFORacle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Button CheckTime;
        private System.Windows.Forms.GroupBox gbSqlServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSqlServerVici;
        private System.Windows.Forms.Label lbSqlServerCSRows;
        private System.Windows.Forms.Label lbSqlServerCSTime;
        private System.Windows.Forms.GroupBox gbOracle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbOracleCSRows;
        private System.Windows.Forms.Label lbOracleCSTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEFSqlRows;
        private System.Windows.Forms.Label lbEFSqlTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbRepoSqlRows;
        private System.Windows.Forms.Label lbRepoSqlTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbRepoOracleRows;
        private System.Windows.Forms.Label lbRepoOracleTime;
        private System.Windows.Forms.GroupBox gbEFORacle;
        private System.Windows.Forms.Label lbEFOracleRows;
        private System.Windows.Forms.Label lbEFOracleTime;
    }
}

