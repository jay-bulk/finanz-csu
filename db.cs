using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FinanzDB {
  class Program {
    static void Main(string[] args) {

      //Set the connection string
      string connectionString = @"Server = cisbussql1901\cisweb; Database = Team106DB; Trusted_Connection = True;";

      try {
        using (SqlConnection connection = new SqlConnection(connectionString)) {
          string query = @"SELECT * FROM budget";

          SqlCommand cmd = new SqlCommand(query, conn);

          conn.Open();

          SqlDataReader dr = cmd.ExecuteReader();


          if (dr.HasRows) {
            while (dr.Read()) {
              dr
            }
          }
           dr.Close();
           conn.Close();
        }
      }

    }
  }
}
