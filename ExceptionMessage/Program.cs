using System;
using System.Windows.Forms;
using AndersonMvvm.Exceptions;
using AndersonMvvm.Views;

namespace AndersonMvvm
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += Application_ThreadException;

            Application.Run(new MainView());
        }

        private static void Application_ThreadException(
            object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            var exception = e.Exception as ExceptionBase;
            if (exception != null)
            {
                if (exception.MessageKind == MessageKind.Info)
                {
                    MessageBox.Show(
                        e.Exception.Message,
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (exception.MessageKind == MessageKind.Warning)
                {
                    MessageBox.Show(
                        e.Exception.Message,
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }


                if (exception.MessageKind == MessageKind.Error)
                {
                    MessageBox.Show(
                        e.Exception.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show(
                         e.Exception.Message,
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
        }
    }
}
