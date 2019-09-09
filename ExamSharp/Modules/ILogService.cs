using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExamSharp.Modules
{
    class ILogService
    {
        public struct LogLevel
        {
            public const ConsoleColor Success = ConsoleColor.Cyan;
            public const ConsoleColor Warning = ConsoleColor.Yellow;
            public const ConsoleColor Error = ConsoleColor.Red;
            public const ConsoleColor Info = ConsoleColor.White;
        }

        /// <summary>
        /// Logs String witg Colour
        /// </summary>
        /// <param name="LogString"></param>
        /// <param name="LogColour"></param>
        public static void Log(string LogString, ConsoleColor LogColour)
        {
            Console.ForegroundColor = LogColour;

            if (String.IsNullOrEmpty(LogString))
            {
                Console.WriteLine($"[{Assembly.GetExecutingAssembly().GetName().Name}] StringNullOrEmpty Occured at ILogService.Log");
                return;
            }
            Console.WriteLine($"[{DateTime.Now.ToString("h:mm:ss tt")} - {Assembly.GetExecutingAssembly().GetName().Name}]: {LogString}");
        }
    }
}
