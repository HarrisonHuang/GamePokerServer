using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Common
{
    public class CustomException : Exception
    {
        public ExceptionLevel Level { set; get; }
        public string Msg { set; get; }
        public CustomException(string msg, ExceptionLevel level = ExceptionLevel.Normal)
        {
            Msg = msg;
            Level = Level;
        }
        public override string Message
        {
            get
            {
                return Msg;
            }
        }
    }

    public enum ExceptionLevel
    {
        Normal = 0,
        Debug,
        Trace,
        Info,
        Warn,
        Error,
        Fatal
    }
}
