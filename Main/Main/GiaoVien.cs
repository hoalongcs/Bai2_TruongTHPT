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
        string strcon = @"Data Source=HOA_LONG\SQLEXPRESS; Initial Catalog=TruongTHPT; Integrated Security=true;";
        public DataTable Show()
        {
            string sql = "select gv.MaGV, gv.HoTen, gv.GT, gv.DiaChi, gv.NgaySinh, gv.Luong, gv.SDT, mh.TenMon from tblGiaoVien gv, tblMonHoc mh where gv.MaMon = mh.MaMon";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable Insert(string _ten, string _gt, int _sdt, DateTime _ns, string _monhoc, long _luong)
        {
            //string str = string.Format("insert into tblGiaoVien (")
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

        //Sua 
        public void Sua_GV(string MaGV, string HoTen, string GT, string NgaySinh, string DiaChi, string SDT, string Luong, string Mon)
        {
            string sql = "Sua_GV";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@Luong", Luong);
            cmd.Parameters.AddWithValue("@MaMon", Mon);
            cmd.Parameters.AddWithValue("@MaGV", MaGV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        //Xoa
        public void Xoa_GV(string MaGV)
        {
            string sql = "Xoa_GV";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaGV", MaGV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public DataTable LayThongTinMonHoc()
        {
            string sql = "SELECT * FROM tblMonHoc";
            SqlConnection con = new SqlConnection(strcon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}
