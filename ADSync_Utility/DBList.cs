using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace ADSync_Utility
{
    public class DBList<T>:List<T> where T : new()
    {
        //引用示例 DBList<StorageReport> dblist = new DBList<StorageReport>(dt);
        public DBList(DataTable dt)
        {
            foreach (T value in getItemValue<T>(dt))
            {
                this.Add(value);
            }
        }

        private List<T> getItemValue<T>(DataTable dt) where T : new()
        {
            List<T> items = new List<T>();
            T model = new T();

            //取出所有属性字段
            PropertyInfo[] propertys = model.GetType().GetProperties();
            foreach (DataRow dr in dt.Rows)
            {
                T item = new T();
                foreach (PropertyInfo pinfo in propertys)
                {
                    string value = dt.Columns.Contains(pinfo.Name) ? dr[pinfo.Name].ToString() : "";
                    pinfo.SetValue(item, value, null);
                }
                items.Add(item);
            }
            return items;
        }
    }
}
