using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_CoolStorage.Connection
{
    class CSSqlCommand : ICSDbCommand
    {
        public readonly SqlCommand Command;

        public CSSqlCommand(SqlCommand command)
        {
            Command = command;
        }

        public string CommandText
        {
            get
            {
                return Command.CommandText;
            }

            set
            {
                Command.CommandText = value;
            }
        }

        public int CommandTimeout
        {
            get
            {
                return Command.CommandTimeout;
            }

            set
            {
                Command.CommandTimeout = value;
            }
        }

        public void Dispose()
        {
            Command.Dispose();
        }

        public int ExecuteNonQuery()
        {
            return Command.ExecuteNonQuery();
        }

        public ICSDbReader ExecuteReader()
        {
            return new CSSqlReader(Command.ExecuteReader());
        }

        public ICSDbReader ExecuteReader(CommandBehavior commandBehavior)
        {
            return new CSSqlReader(Command.ExecuteReader(commandBehavior));
        }
    }
}
