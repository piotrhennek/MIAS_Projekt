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
            logic.RunViciCoolStorageQuery();
            SetResults();
        }

        private void SetResults()
        {
            var results = logic.GetQueriesTimes();

            var viciSqlResult=results[DatabasesEnum.ViciSql];
                lbSqlServerCSTime.Text = viciSqlResult[0].ToString();
                lbSqlServerCSRows.Text = viciSqlResult[1].ToString();

            var viciOracleResult = results[DatabasesEnum.ViciOracle];
            lbOracleCSTime.Text = viciOracleResult[0].ToString();
            lbOracleCSRows.Text = viciOracleResult[1].ToString();

            logic.LogData();
        }
    }
}
