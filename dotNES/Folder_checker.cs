using System;
using System.IO;
using System.Reflection;

namespace dotNES{
    public class Folder_checker{

        public Logger logger;

        public folder_gen(Logger loggerFromApp)
        {
            logger = loggerFromApp;
        }
        const string[14] folders = {
            @"\games",
            @"\config",
            @"\games\001 - Super Mario Bros",
            @"\games\002 - Dr. Mario",
            @"\games\003 - Super Mario Bros 2",
            @"\games\004 - Super Mario Bros 3",
            @"\games\005 - Super Mario World",
            @"\games\006 - Mario Kart",
            @"\games\007 - Yoshis Island",
            @"\games\008 - Donky Kong Country",
            @"\games\009 - Kirbys Adventure",
            @"\games\010 - Street Fighter",
            @"\games\011 - Paper Boy",
            @"\games\012 - Giana Sisters",
        };

        public void check_folders(){
            string folder_path;

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string newPath = outPutDirectory;

            foreach (var dir in folders)
            {
                logger.WriteLineToLog("Checking if folder " + dir + " is present");
                this.folder_path = new Uri(newPath).LocalPath + dir;

                if(!Directory.Exists(folder_path)){
                    logger.WriteLineToLog("Fail! Folder " + dir + " is not present");
                    logger.WriteLineToLog("Generating Folder at: " + dir);
                    Directory.CreateDirectory(folder_path);
                }
                else{
                    logger.WriteLineToLog("Success! Folder " + dir + " is present");
                }
            }
        }
    }
}