using ADSync_New.ADSync_DML;
using ADSync_New.ADSync_Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ADSync_New.ADSync_DAL
{
    public class ADSync_N_DAL
    {
        /// <summary>
        /// 查询部门数据
        /// </summary>
        /// <returns></returns>
        public DataSet QueryDepartData()
        {
            try
            {
                string sql = @"Select DEPTID,DESCR100_2,PARENT_NODE_NAME,DEPT_DESCR,IS_REAL,REAL_LVL,EFF_STATUS,MANAGER_ID,EFFDT From SYSADM.PS_C_DEPTDATA_VW ORDER BY REAL_LVL";
                DataSet ds = OracleDBHelper.GetDataSet(sql);
                return ds;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }            
          
            
        }
    }
}
