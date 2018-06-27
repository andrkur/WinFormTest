using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.DAL
{
    public class Service
    {
        SqlConnectionStringBuilder connectionStrBild;
        public Service()
        {
            connectionStrBild = new SqlConnectionStringBuilder();
            connectionStrBild.DataSource = @"KRUTINELLO-PC";
            connectionStrBild.InitialCatalog = "TestDb";
            connectionStrBild.IntegratedSecurity = true;
            connectionStrBild.Pooling = true;
        }

        public ArrayList GetAllProviders()
        {
            ArrayList allProviders = new ArrayList();
            using (SqlConnection sqlConnection = new SqlConnection(connectionStrBild.ConnectionString))
            {
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM PR_Sklad ORDER BY Kol Desc", sqlConnection);
                sqlConnection.Open();
                SqlDataReader dr = sqlCom.ExecuteReader();
                if (dr.HasRows)
                    foreach (DbDataRecord result in dr)
                        allProviders.Add(result);
                else
                    return null;
                return allProviders;
            }
        }
    }
}
