using System.Data.SqlClient;

namespace QLKhoHang.DAL
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(
            @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=quanlykhohang;Integrated Security=True"
        );
    }
}
