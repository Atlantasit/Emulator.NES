using System;
using System.IO;
using System.Configuration;
using System.Reflection;

namespace dotNES
{    
    class log_output
    {
        public string log_time;

        public void write_nextLine(string message){
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string newLOGPath = outPutDirectory;
            string newlog_file = new Uri(newLOGPath).LocalPath;

            DateTime currentTime = DateTime.Now;
            log_time = currentTime.Year.ToString() + "-" + currentTime.Month.ToString() + "-" + currentTime.Day.ToString() + "_" + currentTime.Hour.ToString() + "." + currentTime.Minute.ToString();

            using (StreamWriter writer = new StreamWriter(newlog_file + "\\"+"log_"+ log_time +".txt", true)){
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }

    }
}