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
            this.gbSqlServer.SuspendLayout();
            this.gbSqlServerVici.SuspendLayout();
            this.gbOracle.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.gbSqlServerVici.ResumeLayout(false);
            this.gbSqlServerVici.PerformLayout();
            this.gbOracle.ResumeLayout(false);
            this.gbOracle.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
    }
}

