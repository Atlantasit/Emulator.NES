using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

namespace dotNES
{
    public class Auto_Cartrige{
        //Variables
        private string ID;
        private string path;

        //Methodes
        public void load_data(){
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string newPath = outPutDirectory;
            string path = newPath + @"\config\load_dis_game.txt";
            
            if(!Directory.Exists(path)){
                Directory.CreateDirectory(path);
            }

            string[] content = File.ReadAllLines(path);
            
            this.path       = content[0];
            this.ID         = content[1];
            
        }

        public string get_ID(){
            return ID;
        }

        public string get_path(){
            return path;
        }
    }
}
