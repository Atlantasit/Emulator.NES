using System;
using System.IO;
using System.Collections.Generic;

namespace dotNES
{
    public class rom_selector{
        //Variables
        private string ID;
        private string path;
        private string path_game;
        private string user_ID;

        //Methodes
        public void Cartridge_to_load(string path_txt){
            
            string[] content = File.ReadAllLines(path_txt);

            this.ID         = content[0];
            this.path       = content[1];
            this.path_game  = content[2];
            this.user_ID    = content[3];

        }

        public string get_ID(){
            return ID;
        }

        public string get_path(){
            return path;
        }

        public string get_path_game(){
            return path_game;
        }

        public string get_user_ID(){
            return user_ID;
        }

    }
}
