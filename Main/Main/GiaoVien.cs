using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Main
{
    public class GiaoVien
    {
        string strcon = @"Data Source=PHAMVANLUONG\SQLEXPRESS; Initial Catalog=TruongTHPT; Integrated Security=true;";
        public DataTable Show()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblGiaoVien", con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable Insert(string _ten, string _gt, int _sdt, DateTime _ns, string _monhoc, long _luong)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] para = new SqlParameter[6];
            //para[0].ParameterName = new SqlParameter("@ten", _ten);
            para[0].Value = _ten;
            //para[1].ParameterName = 
            da.Fill(ds);
            
            return ds.Tables[0];
        }
    }
}
