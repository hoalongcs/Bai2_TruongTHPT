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
        string strcon = @"Data Source=PHAMVANLUONG\SQLEXPRESS; Initial Catalog=TruongTHPT; Integrated Security=true;";
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
        public void ThemHocSinh(string HovaTen, string GT, DateTime NgaySinh, string DiaChi, string PhuHuynh, string MaLop)
        {
            string sql = "ADDHocSinh";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HovaTen", HovaTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@PhuHuynh", PhuHuynh);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
