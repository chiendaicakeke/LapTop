﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

        public class DataProvider
        {
            private static DataProvider instance;

            public static DataProvider Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new DataProvider();
                    }
                    return instance;
                }
                private set => instance = value;
            }

            private DataProvider() { }


            string connectionStr = @"Data Source=DESKTOP-2JDBI71\SQLEXPRESS;Initial Catalog=QL_DOAN1;Integrated Security=True;TrustServerCertificate=True";

            public DataTable ExecuteQuery(string query, object[] parameters = null)
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string param in listPara)
                        {
                            if (param.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(param, parameters[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                    da.Dispose();
                }
                return dt;
            }
        }
}
