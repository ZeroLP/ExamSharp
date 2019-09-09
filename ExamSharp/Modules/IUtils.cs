using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExamSharp.Modules
{
    class IUtils
    {
        /// <summary>
        /// Searches a window with the title <paramref name="WindowTitle"/> in
        /// all running processes.
        /// </summary>
        /// 
        /// <param name="WindowTitle">Title of the window to search.</param>
        /// 
        /// <returns>
        /// <code>IntPtr.Zero</code> if the window is not found.
        /// Otherwise, returns the window handle.
        /// </returns>
        public static Process GetProcessByTitle(string WindowTitle)
        {
            Process handle = null;

            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle.Equals(WindowTitle))
                {
                    handle = process;
                    break;
                }
            }

            return handle;
        }
    }
}
