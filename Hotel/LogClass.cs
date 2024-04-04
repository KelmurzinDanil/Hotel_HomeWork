using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class LogClass
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        public void LogMethod()
        {
            // Я не понял, что с этим делать
            log.Trace("Trace message");
            log.Debug("Debug message");
            log.Info("Info message");
            log.Warn("Warn message");
            log.Error("Error message");
            log.Fatal("Fatal message");
        }
    }
}
