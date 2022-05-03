using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Filip_Test_DB_20220305
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Faktury;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Faktury> GetFaktura()
        {
            List<Faktury> faktury = new List<Faktury>();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT * FROM Faktury";
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                            var faktura = new Faktury()
                            {
                                id = Convert.ToInt32(sqlDataReader["id"]),
                                datum = Convert.ToDateTime(sqlDataReader["datum"]),
                                cislo = Convert.ToInt32(sqlDataReader["cislo"]),
                                odberatel = Convert.ToString(sqlDataReader["odberatel"]),
                                nazev = Convert.ToString(sqlDataReader["nazev"]),
                                pocet = Convert.ToInt32(sqlDataReader["pocet"]),
                                cena = Convert.ToSingle(sqlDataReader["cena"]),

                            };
                                faktury.Add(faktura);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            return faktury;
            }
    }
}
