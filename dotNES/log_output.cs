using System;
using System.IO;

namespace dotNES
{    
    class log_output
    {   
        string log_file = "last_log.txt";
        
        public void write_nextLine(string message){

            string newMessage = message + Environment.NewLine;
            File.WriteAllText(log_file,newMessage);
        }
    }
}