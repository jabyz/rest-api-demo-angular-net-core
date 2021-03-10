using Microsoft.Extensions.Configuration;
using rest_api_net_core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api_net_core.Helpers
{
  public class func
  {
    private readonly IConfiguration _conf;
    public func(IConfiguration conf)
    {
      _conf = conf;
    }
    public int AddNewRecordToResuls(Results res)
    {
      string qry = "INSERT INTO Results (number_in_1,number_in_2,func,number_out) VALUES (@number_in_1,@number_in_2,@func,@number_out)";
      SqlCommand myCmd = new SqlCommand(qry);
      myCmd.Parameters.AddWithValue("@number_in_1", res.NumberIn1);
      myCmd.Parameters.AddWithValue("@number_in_2", res.NumberIn2);
      myCmd.Parameters.AddWithValue("@func", res.Funcion);
      myCmd.Parameters.AddWithValue("@number_out", res.Resultado);

      myCmd.CommandType = CommandType.Text;
      sql mySqlHelper = new sql(_conf);

      int ra = mySqlHelper.xQuery(myCmd);

      return ra;

    }
  }
}
