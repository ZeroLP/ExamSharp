using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamSharp.Modules
{
    class Config
    {
        /// <summary>
        /// For Error Return Case
        /// </summary>
        public static DateTime NullDate = DateTime.MinValue;

        /// <summary>
        /// Gets Start Date of the exam period from config file
        /// </summary>
        /// <returns>DateTime</returns>
        public static DateTime GetStartDate()
        {
            try
            {
                string Path = Directory.GetCurrentDirectory() + "\\Config.txt";
            }
            catch (Exception e)
            {
                ILogService.Log($"Cannot find config file\n{e.ToString()}", ILogService.LogLevel.Error);
                return NullDate;
            }

            string ConfigPath = Directory.GetCurrentDirectory() + "\\Config.txt";

            try
            {
                string[] Date = File.ReadAllLines(ConfigPath).SkipWhile(line => !line.StartsWith("[Start Date]")).TakeWhile(line => !string.IsNullOrEmpty(line)).ToArray();
                Convert.ToDateTime(Date[0].Replace("[Start Date](", "").Replace(")", ""));
            }
            catch(Exception e)
            {
                ILogService.Log($"Cannot fetch the start date of the exam\n{e.ToString()}", ILogService.LogLevel.Error);
                return NullDate;
            }

            string[] StartDate = File.ReadAllLines(ConfigPath).SkipWhile(line => !line.StartsWith("[Start Date]")).TakeWhile(line => !string.IsNullOrEmpty(line)).ToArray();

            return Convert.ToDateTime(StartDate[0].Replace("[Start Date](", "").Replace(")", ""));
        }

        /// <summary>
        /// Gets End Date of the exam period from config file
        /// </summary>
        /// <returns>DateTime</returns>
        public static DateTime GetEndDate()
        {
            try
            {
                string Path = Directory.GetCurrentDirectory() + "\\Config.txt";
            }
            catch (Exception e)
            {
                ILogService.Log($"Cannot find config file\n{e.ToString()}", ILogService.LogLevel.Error);
                return NullDate;
            }

            string ConfigPath = Directory.GetCurrentDirectory() + "\\Config.txt";

            try
            {
                string[] Date = File.ReadAllLines(ConfigPath).SkipWhile(line => !line.StartsWith("[End Date]")).TakeWhile(line => !string.IsNullOrEmpty(line)).ToArray();
                Convert.ToDateTime(Date[0].Replace("[End Date](", "").Replace(")", ""));
            }
            catch(Exception e)
            {
                ILogService.Log($"Cannot fetch the end date of the exam\n{e.ToString()}", ILogService.LogLevel.Error);
                return NullDate;
            }

            string[] EndDate = File.ReadAllLines(ConfigPath).SkipWhile(line => !line.StartsWith("[End Date]")).TakeWhile(line => !string.IsNullOrEmpty(line)).ToArray();

            return Convert.ToDateTime(EndDate[0].Replace("[End Date](", "").Replace(")", ""));
        }
    }
}
