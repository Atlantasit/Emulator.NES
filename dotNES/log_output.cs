using System;
using System.IO;
using System.Configuration;
using System.Reflection;

namespace dotNES
{    
    class log_output
    {
        private string log_time;
        private string log_path;
        private void log_setTime(){
            DateTime currentTime = DateTime.Now;
            this.log_time = currentTime.Year.ToString() + "-" + currentTime.Month.ToString() + "-" + currentTime.Day.ToString() + "_" + currentTime.Hour.ToString() + "." + currentTime.Minute.ToString();
        }

        public void log_create(){
            log_setTime();

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string newLOGPath = outPutDirectory;
            this.log_path = new Uri(newLOGPath).LocalPath + @"\Logs";

            if (!Directory.Exists(log_path)) {
                Directory.CreateDirectory(log_path);
            }
            write_nextLine("New log file created");
        }

        public void write_nextLine(string message){
            using (StreamWriter writer = new StreamWriter(log_path + "\\"+"log_"+ log_time +".txt", true)){
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }

    }
}