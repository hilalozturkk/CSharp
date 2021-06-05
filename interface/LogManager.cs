using System;

namespace Interface
{

    public class LogManager : ILogger
    {
        public ILogger _logger;//logger sınıfının instance yaratıyoruz -> interface in 

        public LogManager(ILogger logger)
        { //interface tipinde bir nesne aldırdık
            _logger = logger;

        }
        public void writeLog()
        {
            _logger.writeLog();
        }

    }

}