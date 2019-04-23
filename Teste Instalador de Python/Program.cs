using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Teste_Instalador_de_Python {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // Application.EnableVisualStyles();
            //  Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
                       

            RegistryKey registro = Registry.CurrentUser;

            string[] b = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Python\\PythonCore").GetSubKeyNames();

            registro = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Python\\PythonCore\\" + b[0] + "\\InstallPath");

            string valor = registro.GetValue("ExecutablePath").ToString();

            MessageBox.Show(valor);


                       
        }

    }


}

