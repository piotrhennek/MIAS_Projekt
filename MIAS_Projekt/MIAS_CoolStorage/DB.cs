using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_CoolStorage
{
    public static class DB
    {
        public const string CONTEXT = "mias";

        public static void InitDB(string connectionString, string context)
        {
            CSConfig.SetDB(new CSDataProviderSqlServer(connectionString), context);
            
            //InitDB();
        }

        public static void InitDB()
        {
            Type[] types = System.Reflection.Assembly.GetExecutingAssembly().GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].IsAbstract
                    && types[i].IsPublic
                    && types[i].BaseType.Name.Contains("CSObject"))
                {
                    try
                    {
                        types[i].InvokeMember("New", System.Reflection.BindingFlags.Default
                            | System.Reflection.BindingFlags.Static
                            | System.Reflection.BindingFlags.InvokeMethod
                            | System.Reflection.BindingFlags.Public
                            | System.Reflection.BindingFlags.FlattenHierarchy, null, null, null);
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine(ex.ToString());
                    }
                }
            }
        }
    }
}
