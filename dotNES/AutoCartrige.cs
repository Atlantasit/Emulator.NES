using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

namespace dotNES
{
    public class AutoCartrige{
        //Variables
        private string ID;
        private string path;

        public Logger logger;

        //Methodes
        public AutoCartrige(Logger loggerFromUI)
        {
            this.logger = loggerFromUI;
        }

        public void load_data(){
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string newPath = outPutDirectory;
            string path = newPath + @"\config\load_dis_game.txt";

            
            if(!File.Exists(path)){
                logger.WriteLineToLog("Config file load_dis_game.txt not found generation one!", "AutoCartige");
                logger.WriteLineToLog("File: " + path, "AutoCartige");// only temp

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine($"AutoCartrige config:");
                }
            }

            string[] content = File.ReadAllLines(path);
            
            this.path       = content[1];
            this.ID         = content[2];
        }

        public string get_ID(){
            return ID;
        }

        public string get_path(){
            return path;
        }
    }
}
