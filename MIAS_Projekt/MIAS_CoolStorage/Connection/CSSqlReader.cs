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
    class CSSqlReader : ICSDbReader
    {
        public readonly SqlDataReader Reader;

        public CSSqlReader(SqlDataReader reader)
        {
            Reader = reader;
        }

        public DataTable GetSchemaTable()
        {
            return Reader.GetSchemaTable();
        }

        public object this[int i]
        {
            get
            {
                return Reader[i];
            }
        }

        public int FieldCount
        {
            get
            {
                return Reader.FieldCount;
            }
        }

        public bool IsClosed
        {
            get
            {
                return Reader.IsClosed;
            }
        }

        public void Dispose()
        {
            Reader.Dispose();
        }

        public string GetName(int i)
        {
            return Reader.GetName(i);
        }

        public bool Read()
        {
            return Reader.Read();
        }
    }
}
