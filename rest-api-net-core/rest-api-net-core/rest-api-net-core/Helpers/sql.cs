using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api_net_core.Helpers
{
  public class sql
  {
    private readonly IConfiguration _conf;

    public sql(IConfiguration conf)
    {
      _conf = conf;
    }
    public SqlConnection getSqlConn()
    {
      string conn = _conf.GetConnectionString("localHost");
      SqlConnection sqlConn = new SqlConnection(conn);

      return sqlConn;
    }

    public int xQuery(SqlCommand cmd)
    {
      int ra = 0;
      using (SqlConnection sqlConn = getSqlConn())
      {
        if (sqlConn.State == ConnectionState.Open)
          sqlConn.Close();
        try
        {
          cmd.Connection = sqlConn;
          cmd.CommandTimeout = 0;
          sqlConn.Open();
          ra = cmd.ExecuteNonQuery();
          cmd.Dispose();
          sqlConn.Close();
          sqlConn.Dispose();
          return ra;
        }
        catch (Exception ex)
        {

          cmd.Dispose();
          sqlConn.Close();
          sqlConn.Dispose();
          return 0;
        }
      }
    }
  }
}
