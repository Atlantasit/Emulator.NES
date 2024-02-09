using System;
using System.IO;

namespace dotNES
{    
    class log_output
    {   
        public void write_nextLine(string message){

            string log_path = ConfigurationManager.AppSettings["logPath"];

            using(StreamWriter writer = new StreamWriter(log_path,true)){
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }

    }
}