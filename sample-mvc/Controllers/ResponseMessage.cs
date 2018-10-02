using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sample_mvc.Controllers
{
    public class ResponseMessage
    {
        public ResponseMessage()
        {
            this.Msg = "Success";
            this.Status = 200;
        }
        public int Status { get; set; }
        public string Msg { get; set; }
        public object Data { get; set; }
        public void Error()
        {
            this.Status = 400;
            this.Msg = "Error";
        }
        public void Success( object data)
        {
            this.Data = data;
        }
    }
}