using System;
using System.IO;
using System.Collections.Generic;

namespace dotNES
{
    public class Auto_Cartrige{
        //Variables
        private string ID;
        private string path;

        //Methodes
        public void load_data(){
            
            string[] content = File.ReadAllLines(path_txt);

            this.ID         = content[1];
            this.path_game  = content[0];

        }

        public string get_ID(){
            return ID;
        }

        public string get_path(){
            return path;
        }
    }
}
