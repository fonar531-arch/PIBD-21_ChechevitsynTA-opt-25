using otp_lab_25;
using Unity;

static class Program
{
    [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = ContainerConfig.GetContainer();
        Application.Run((MainForm)container.Resolve(typeof(MainForm)));
    }
    
}