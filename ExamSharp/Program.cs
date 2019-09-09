using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using ExamSharp.Modules;

namespace ExamSharp
{
    class Program
    {
        static void Main(string[] args)
        {
                Thread OnDetectThread = new Thread(new ThreadStart(OnDetect));
                OnDetectThread.IsBackground = true;
                OnDetectThread.Start();

                Console.ReadLine();
        }

        /// <summary>
        /// Detection Thread
        /// </summary>
        public static void OnDetect()
        {
            while (true)
            {
                if (Config.GetStartDate().Ticks == 0 || Config.GetEndDate().Ticks == 0)
                {
                    Console.ReadLine();
                    return;
                }

                if (Calender.GetToday.InDateTime().Ticks >= Config.GetStartDate().Ticks && Calender.GetToday.InDateTime().Ticks <= Config.GetEndDate().Ticks)
                {
                    DetectionService.DetectFacebook();
                    DetectionService.DetectInstagram();
                }
            }
        }
    }
}
