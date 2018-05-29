﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace Systeminfonetcore
{
 public static class LinuxBashHelper
    {

        /// <summary>
        /// clase para enviar commandos al 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>

        public static string Bash(this string cmd)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return result;
        }


    }
}
