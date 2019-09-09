using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExamSharp.Modules
{
    class DetectionService
    {
        /// <summary>
        /// Detects running thread of Facebook
        /// </summary>
        public static void DetectFacebook()
        {
            Process FacebookWindow = IUtils.GetProcessByTitle("Facebook - Google Chrome");
            if (FacebookWindow != null)
            {
                FacebookWindow.Kill();
                ILogService.Log("Terminated Facebook", ILogService.LogLevel.Success);
            }
        }

        /// <summary>
        /// Detects running thread of Instagram
        /// </summary>
        public static void DetectInstagram()
        {
            Process InstagramWindow = IUtils.GetProcessByTitle("Instagram - Google Chrome");
            if (InstagramWindow != null)
            {
                InstagramWindow.Kill();
                ILogService.Log("Terminated Instagram", ILogService.LogLevel.Success);
            }
        }
    }
}
