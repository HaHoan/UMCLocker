using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMCLocker.Entities
{
    public class ResultInfo
    {
        public int code { get; set; }
        public string message { get; set; }

        public ResultInfo() { }
        public ResultInfo(int code, string message)
        {
            this.code = code;
            this.message = message;
        }
     
    }
}
