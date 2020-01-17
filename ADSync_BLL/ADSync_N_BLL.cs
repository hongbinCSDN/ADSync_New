using ADSync_New.ADSync_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADSync_BLL
{
    public class ADSync_N_BLL
    {
        private ADSync_N_DAL _ADSync_DAL;
        protected ADSync_N_DAL DA
        {
            get
            {
                return _ADSync_DAL ?? (_ADSync_DAL = new ADSync_N_DAL());
            }
        }
        /// <summary>
        /// 查询部门数据
        /// </summary>
        /// <returns></returns>
        public DataSet QueryDepartData()
        {
            return DA.QueryDepartData();
        }
    }
}
