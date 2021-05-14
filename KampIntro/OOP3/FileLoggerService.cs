using System;

namespace OOP3
{
    class FileLoggerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
