using System.Media;
using System.Reflection.Metadata.Ecma335;
using WMPLib;
namespace Chessgame
{
    internal static class Program
    {
       
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AudioManager.Play("BACKGROUNDAUDIO.mp3");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}