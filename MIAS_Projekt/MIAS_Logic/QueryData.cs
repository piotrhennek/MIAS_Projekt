#region Usings

using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
#endregion

namespace MIAS_Logic
{

        public class QueryData
        {
            #region Constructors
            /// <summary>
            /// Initializes a new instance of the <see cref="QueryData"/> class.
            /// </summary>
            /// <param name="query">The query.</param>
            /// <exception cref="System.ArgumentNullException">query</exception>
            public QueryData(string query)
                : this()
            {
                if (string.IsNullOrEmpty(query))
                {
                    throw new ArgumentNullException("query");
                }

                this.Query = query;
            }

            /// <summary>
            /// Prevents a default instance of the <see cref="QueryData"/> class from being created.
            /// </summary>
            private QueryData()
            {
                this.Parameters = new List<OracleParameter>();
            }
            #endregion

            #region Properties
            /// <summary>
            /// Gets the parameters.
            /// </summary>
            /// <value>
            /// The parameters.
            /// </value>
            public List<OracleParameter> Parameters
            {
                get;
                private set;
            }

            /// <summary>
            /// Gets the query.
            /// </summary>
            /// <value>
            /// The query.
            /// </value>
            public string Query
            {
                get;
                private set;
            }
            #endregion
        }
    }

