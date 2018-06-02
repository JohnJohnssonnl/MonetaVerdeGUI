using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonetaVerdeWalletGUI
{
    class LogManager
    {
        StreamWriter writeLog;
        String filePath;

        public void InitLog()
        {
            filePath = AppDomain.CurrentDomain.BaseDirectory + @"bin\\log.txt";
			if (File.Exists(filePath))
				{
					File.Delete(filePath);
				}
           // writeLog = File.AppendText(filePath);
        }

        public void Log(string logMessage, string _type, string _Origin)
        {
            return;
            writeLog.Write("\r\nLog Entry : ");
            writeLog.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
            writeLog.WriteLine("  :");
            writeLog.WriteLine("  :{0} {1} {2}", _type, _Origin, logMessage);
            writeLog.WriteLine("-------------------------------");
        }
    }
}
