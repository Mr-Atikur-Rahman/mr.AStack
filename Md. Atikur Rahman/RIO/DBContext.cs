using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RIO
{
    public class DBContext
    {
        string connStr = "server=root;user=user;database=db;password=172126;";
        MySqlConnection conn = new MySqlConnection(connectionString:);

        string sql = "SELECT this FROM that";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        using (MySqlDataReader rdr = cmd.ExecuteReader())
        {
            while (Rdm.Read())
            {
                /* iterate once per row */
            }
    }
}
