using System;
using System.IO;
using System.Configuration;
using System.Reflection;

namespace dotNES
{    
    class log_output
    {
        private string log_time;
        private string log_file;
        private void log_setTime(){
            DateTime currentTime = DateTime.Now;
            this.log_time = currentTime.Year.ToString() + "-" + currentTime.Month.ToString() + "-" + currentTime.Day.ToString() + "_" + currentTime.Hour.ToString() + "." + currentTime.Minute.ToString();
        }

        public void log_create(){
            log_setTime();

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string newLOGPath = outPutDirectory;
            string newlog_file = new Uri(newLOGPath).LocalPath;
        }

        public void write_nextLine(string message){
            using (StreamWriter writer = new StreamWriter(log_file + "\\"+"log_"+ log_time +".txt", true)){
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }

    }
}