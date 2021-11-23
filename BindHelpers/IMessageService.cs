using System.Windows.Forms;

namespace WindowsMvvm.BindHelpers
{
    public interface IMessageService
    {
        void OKOnly(string message);
        DialogResult QuestionOKCancel(string message);
    }
}
