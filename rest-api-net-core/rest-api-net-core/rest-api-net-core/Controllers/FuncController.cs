using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using rest_api_net_core.Helpers;
using rest_api_net_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api_net_core.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class FuncController : ControllerBase
  {
    private readonly IConfiguration _conf;

    public FuncController(IConfiguration conf)
    {
      _conf = conf;
    }

    [HttpPost]
    [Route("getASum")]
    //POST : /api/Funciones/getASum
    public JsonResult getASum(object jsonObj)
    {
      dynamic obj = JObject.Parse(jsonObj.ToString());
      var x = obj.x;
      var y = obj.y;

      var result = int.Parse(x.ToString()) + int.Parse(y.ToString());

      Results res = new Results();

      res.NumberIn1 = int.Parse(x.ToString());
      res.NumberIn2 = int.Parse(y.ToString());
      res.Funcion = "getASum";
      res.Resultado = result;

      func myFunc = new func(_conf);
      int ra = myFunc.AddNewRecordToResuls(res);


      return new JsonResult(new { myResult = result });
    }

    [HttpPost]
    [Route("getAProduct")]
    //POST : /api/Funciones/getAProduct
    public JsonResult getAProduct(object jsonObj)
    {
      dynamic obj = JObject.Parse(jsonObj.ToString());
      var a = obj.a;

      var result = int.Parse(a.ToString()) * 2;

      Results res = new Results();

      res.NumberIn1 = int.Parse(a.ToString());
      res.Funcion = "getAProduct";
      res.Resultado = result;

      func hlp = new func(_conf);
      int ra = hlp.AddNewRecordToResuls(res);


      return new JsonResult(new { myResult = result });
    }

    [HttpPost]
    [Route("getAPower")]
    //POST : /api/Funciones/getAPower
    public JsonResult getAPower(object jsonObj)
    {
      dynamic obj = JObject.Parse(jsonObj.ToString());
      var s = obj.s;

      double result = Math.Pow(int.Parse(s.ToString()), 2);

      Results res = new Results();

      res.NumberIn1 = int.Parse(s.ToString());
      res.Funcion = "getAPower";
      res.Resultado = (int)result;

      func hlp = new func(_conf);
      int ra = hlp.AddNewRecordToResuls(res);


      return new JsonResult(new { myResult = result });
    }
  }
}
