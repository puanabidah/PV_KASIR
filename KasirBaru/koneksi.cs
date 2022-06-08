/*
 * Created by SharpDevelop.
 * User: Puan Abidah
 * Date: 24/05/2022
 * Time: 15:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KasirBaru
{
	class koneksi
    {
        public SqlConnection GetConn()
        {
        	SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=LAPTOP-A2KTCNSD\\SQLEXPRESS;Initial Catalog=Kasir;Integrated Security=True";
            return Conn;
        }
    }
}
