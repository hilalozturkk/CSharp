using System;

namespace Interface
{
    public class FileLogger : ILogger{

           public void writeLog()
        {
           // throw new NotImplementedException();
            Console.WriteLine("Dosyaya log yazar");
        }
    }
}