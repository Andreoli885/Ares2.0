using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares2._0
{
    class ffmpeg
    {
        public static void enviarcmd (string cmd)
        {
            

            //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
             //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
             System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + cmd);



             //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
             procStartInfo.CreateNoWindow = true;
             //Inicializa el proceso
             System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //ocultar cmd
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo = procStartInfo;
             proc.Start();
            


        }

    }
    
}
