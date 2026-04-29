using System.Windows.Forms;

namespace ObjectMover
{
    public static class CrashDialog
    {
        public static void Show(ErrorCode code)
        {
            MessageBox.Show($"Что то пошло не так.\n\nError Code: {code}");
            Application.ExitThread();
        }
    }
}