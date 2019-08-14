using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



//Student Name: Wenxu Kang
//Student ID:300943385
//Description:
namespace FinalTest
{
    static class Program
    {

        public static CharacterGenerationForm characterForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGenerationForm();

            Application.Run(characterForm);
        }
    }
}
