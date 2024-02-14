using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace dotNES
{
    static class App
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Logger log = new Logger();
            log.CreateLog();

            FolderChecker checker = new FolderChecker(log);
            checker.check_folders();

            UI ui = new UI(log);
            Application.Run(ui);          
        
            //Emulator emu = new Emulator();
            //Console.WriteLine(emu.Cartridge);
            //for (int i = 0; i < 10000; i++)
            //{
            //   emu.CPU.Execute();
            //}
            //emu.PPU.ProcessFrame();
            //emu.PPU.ProcessFrame();
            //emu.PPU.ProcessFrame();
            //emu.PPU.ProcessFrame();
            //emu.PPU.ProcessFrame();
        }
    }
}
