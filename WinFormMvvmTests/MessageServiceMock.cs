using WindowsMvvm.BindHelpers;

namespace WinFormMvvmTests
{
    internal sealed class MessageServiceMock : IMessageService
    {
        public void OKOnly(string message)
        {
        }

        public System.Windows.Forms.DialogResult QuestionOKCancel(string message)
        {
            return System.Windows.Forms.DialogResult.OK;
        }
    }
}
