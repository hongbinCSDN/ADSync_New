using System;
using System.Collections.Generic;
using System.Text;

namespace ADSync_DML
{
    public class ResultVM
    {
        Int32 _Affected = 0;
        object _Data;

        public Boolean IsSuccess
        {
            get
            {
                if (_Data != null)
                {
                    return true;
                }
                return _Affected > 0;
            }
        }

        public Int32 Affected
        {
            get { return _Affected; }
            set { _Affected = value; }
        }

        public object Data
        {
            get { return _Data; }
            set { _Data = value; }
        }

        public String Message { get; set; }

        public void SetMessageJson(String key, String value)
        {
            this.Message = "{" + String.Format("'{0}':'{1}'", key, value) + "}";
        }

        public void SetMessageJson(IList<String> keys, IList<Object> values)
        {
            if (keys.Count < 1 || values.Count < 1 || keys.Count != values.Count)
            {
                this.Message = "";
            }

            StringBuilder error = new StringBuilder();
            error.Append("{");

            for (int i = 0; i < keys.Count; i++)
            {
                error.Append("'" + keys[i] + "':'" + values[i] + "',");
            }

            error.Remove(error.Length - 1, 1).Append("}");
            this.Message = error.ToString();
        }
    }
}
