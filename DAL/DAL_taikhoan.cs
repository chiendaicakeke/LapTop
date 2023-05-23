using System.Data;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        public DataTable layTaiKhoan(string tk, string mk)
        {
            string query = $"select * from TAIKHOAN where TENTK = '{tk}' and MK = '{mk}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}