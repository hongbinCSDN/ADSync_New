using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADSync_BLL;
using ADSync_DML;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADSync_New.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private ADSync_N_BLL _ADSync_N_BLL;
        protected ADSync_N_BLL BL
        {
            get
            {
                return _ADSync_N_BLL ?? (_ADSync_N_BLL = new ADSync_N_BLL());
            }
        }

        public ResultVM QueryDepartData()
        {
            try
            {
                return new ResultVM { Data = BL.QueryDepartData(),Message = "Success" };
            }
            catch(Exception ex)
            {
                return new ResultVM { Message = ex.ToString() };
            }
        }
    }
}