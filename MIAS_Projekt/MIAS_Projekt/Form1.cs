using MIAS_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIAS_Projekt
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
            logic.Query = tbQuery.Text;
            logic.RunViciCoolStorageQueries();
            logic.RunEntityFrameworkQueries();
            logic.RunRepositoryQueries();
            SetResults();
        }

        private void SetResults()
        {
            var time = 0;
            var rows = 1;
            var results = logic.GetQueriesTimes();

            var viciSqlResult=results[DatabasesEnum.ViciSql];
                lbSqlServerCSTime.Text = viciSqlResult[time].ToString();
                lbSqlServerCSRows.Text = viciSqlResult[rows].ToString();

            var viciOracleResult = results[DatabasesEnum.ViciOracle];
                lbOracleCSTime.Text = viciOracleResult[time].ToString();
                lbOracleCSRows.Text = viciOracleResult[rows].ToString();

            var efSqlResult = results[DatabasesEnum.EntityFrameworkSql];
                lbEFSqlTime.Text = efSqlResult[time].ToString();
                lbEFSqlRows.Text = efSqlResult[rows].ToString();

            var repoSqlResult = results[DatabasesEnum.RepositorySql];
                lbRepoSqlTime.Text = repoSqlResult[time].ToString();
                lbRepoSqlRows.Text = repoSqlResult[rows].ToString();

            var repoOracleResult = results[DatabasesEnum.RepositoryOracle];
                lbRepoOracleTime.Text = repoOracleResult[time].ToString();
                lbRepoOracleRows.Text = repoOracleResult[rows].ToString();
            logic.LogData();
        }
    }
}
