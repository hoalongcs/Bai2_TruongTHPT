using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Main
{
    public class HocSinh
    {
        string strcon = @"Data Source=HOA_LONG\SQLEXPRESS; Initial Catalog=TruongTHPT; Integrated Security=true;";
        public DataTable Show()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblHocSinh", con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
    }
}
