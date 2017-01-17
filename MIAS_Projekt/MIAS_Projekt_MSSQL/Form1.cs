using MIAS_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIAS_Projekt_MSSQL
{
    public partial class Form1 : Form
    {
        private RepositoriesLogic logic { get; set; }
        public Form1()
        {
            InitializeComponent();
            logic = new RepositoriesLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckTime_Click(object sender, EventArgs e)
        {
            logic.Replies = int.Parse(tbReplies.Text);
            logic.Query = tbQuery.Text;
            logic.RunViciCoolStorageSqlQuery();
            logic.RunEntityFrameworkSqlQuery();
            logic.RunRepoSqlQuery();
            SetResults();
        }

        private void SetResults()
        {
                        var results = logic.GetQueriesTimes();
            try
            {
                var viciSqlResult = results[DatabasesEnum.ViciSql];
                lbSqlServerCSTime.Text = viciSqlResult;
            }
            catch (Exception exc)
            {
                Trace.WriteLine($"Proba pobrania result {exc.Message}");
            }
            try
            {
                var viciOracleResult = results[DatabasesEnum.ViciOracle];
                lbOracleCSTime.Text = viciOracleResult;
            }
            catch (Exception exc)
            {
                Trace.WriteLine($"Proba pobrania result {exc.Message}");
            }
            try
            {
                var efSqlResult = results[DatabasesEnum.EntityFrameworkSql];
                lbEFSqlTime.Text = efSqlResult;
            }
            catch (Exception exc)
            {
                Trace.WriteLine($"Proba pobrania result {exc.Message}");
            }
            try
            {
                var efOracleResult = results[DatabasesEnum.EntityFrameworkOracle];
                lbEFOracleTime.Text = efOracleResult;
            }
            catch (Exception exc)
            {
                Trace.WriteLine($"Proba pobrania result {exc.Message}");
            }

            try
            {
                var repoSqlResult = results[DatabasesEnum.RepositorySql];
                lbRepoSqlTime.Text = repoSqlResult;
            }
            catch (Exception exc)
            {
                Trace.WriteLine($"Proba pobrania result {exc.Message}");
            }
            try
            {
                var repoOracleResult = results[DatabasesEnum.RepositoryOracle];
                lbRepoOracleTime.Text = repoOracleResult;
                
            }
            catch (Exception exc)
            {
                Trace.WriteLine($"Proba pobrania result {exc.Message}");
            }
            logic.LogData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
