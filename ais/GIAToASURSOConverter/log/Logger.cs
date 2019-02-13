using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GIAToASURSOConverter.log
{
    class Logger
    {
        private static Logger instance = null;
        private List<String> messages;

        public static Logger getInstance()
        {
            if (Logger.instance == null)
                Logger.instance = new Logger();
            return Logger.instance;
        }

        public Logger()
        {
            this.messages = new List<string>();
        }

        public void log(String msg)
        {
            this.messages.Add(msg);
        }

        public String getAllLogs()
        {
            String msg = "";
            foreach (String m in this.messages)
                msg += System.Environment.NewLine + m;
            return msg;
        }

    }
}
