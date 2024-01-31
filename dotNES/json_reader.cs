using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;

namespace dotNES{

    public class json_reader{
        private int ID {get; set;}
        private string path {get; set;}
        private string path_rom {get; set;}
        private int user_ID {get; set;}
        public void json_read(){
            
        }

        public void json_to_file(object Object, string path){

            using (StreamReader r = new StreamReader("load_dis_game.json")){
                string json = r.ReadToEnd();
                List<Item> items = JsonConverter.DeserializeObject<List<items>>(json);
            }
        }

        public void getitems(string path){


        }

        
        
    }
}