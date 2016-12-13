using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace MIAS_Logic
{

    public abstract class BaseRepository
    {
        #region Private variables
        private readonly OracleConnection connection;
        #endregion

        #region Constructors
        protected BaseRepository(OracleConnection connection)
        {
            this.connection = connection;
        }
        #endregion

        #region Properties
        public OracleConnection Connection
        {
            get
            {
                return this.connection;
            }
        }
        #endregion

        #region Methods

        public virtual OracleDataReader ExecuteReader(OracleCommand command)
        {
            return command.ExecuteReader();
        }

        public virtual OracleDataReader ExecuteReader(OracleCommand command, CommandBehavior behavior)
        {
            return command.ExecuteReader(behavior);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Considered.")]
        public int ExecuteNonQuery(OracleCommand command)
        {
            return command.ExecuteNonQuery();
        }

        public OracleCommand CreateCommand()
        {
            return this.Connection.CreateCommand();
        }

        public OracleCommand CreateCommand(string commandText)
        {
            return this.SetCommandText(this.Connection.CreateCommand(), commandText);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "It is secure."), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Considered.")]
        public OracleCommand SetCommandText(OracleCommand command, string commandText)
        {
            command.CommandText = commandText;
            return command;
        }
        #endregion
    }
}

