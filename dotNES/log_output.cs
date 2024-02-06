using System;
using System.IO;

namespace dotNES
{    
    class log_output
    {   
        private int log_length = 0;
        const string log_file = "/home/atlantasit/Documents/Daten/Github/Emulator.NES/log.txt";
        public void write_nextLine(string message){
            // Skipping the Header part of the LogFile
            string[] log_lines  = File.ReadAllLines(log_file);
            log_length = log_lines.Length+1;
            log_lines[log_length] = message;
            File.WriteAllLines(log_file, log_lines);
            
            
        }
    }
}