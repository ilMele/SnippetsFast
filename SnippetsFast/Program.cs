/*
 the var bool type: true -> file | false -> folder
 */

namespace SnippetsFast
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new System.Threading.Mutex(false, "SnippetsFast");
            try
            {
                if(mutex.WaitOne(0, false))
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new Form1());
                }
            }
            finally
            {
                if(mutex != null)
                {
                    mutex.Close();
                    mutex = null;
                }
            }
            
        }
    }
}