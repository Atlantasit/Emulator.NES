using System;
using System.IO;
using System.Configuration;
using System.Reflection;

namespace dotNES
{    
    class log_output
    {   
        int log_time = DateTime.Now;
        public void new_log(){

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly(). CodeBase);
            var newLOGPath = Path.Combine(outPutDirectory, "\\Logs");
            string newlog_file = new UIntPtr(newLOGPath).localPath;
            //Creating the new log file
            using(FileStream fs = File.Create(newLOGPath + "[" + log_time + "]log.txt")){}
        }
        
        public void write_nextLine(string message){

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly(). CodeBase);
  
            var LOGPath = Path.Combine(outPutDirectory,"[" + log_time + "]log.txt");
            string log_path = new UIntPtr(LOGPath).localPath;

            using(StreamWriter writer = new StreamWriter(log_path,true)){
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }

    }
}