using System.Windows.Forms;
using WindowsMvvm.BindHelpers;

namespace WindowsMvvm.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IMessageService message_service_;
        //メッセージボックスのテスト
        public MainViewModel() : this(new MessageService())
        {
        }

        public MainViewModel(IMessageService messageService)
        {
            message_service_ = messageService;
        }

        private string my_textbox_text_ = string.Empty;
        public string MyTextBoxText
        {
            get { return my_textbox_text_; }
            set
            {
                SetProperty(ref my_textbox_text_, value, "MyTextBoxText");
            }
        }

        public void Save()
        {
            if(message_service_.QuestionOKCancel("保存しますか") != DialogResult.OK)
            {
                return;
            }

            //if (MessageBox.Show("保存しますか", "質問",MessageBoxButtons.OK, MessageBoxIcon.Question) != DialogResult.OK)
            //{
            //    return;
            //}
        }

        public void Call()
        {
            MyTextBoxText = "BBb";
        }
    }
}

//namespace WindowsMvvm.ViewModels
//{
//    public class MainViewModel
//    {
//        private string my_textbox_text_ = string.Empty;
//        public string MyTextBoxText
//        {
//            get { return my_textbox_text_; }
//            set
//            {
//            }
//        }

//        public void Call()
//        {
//            MyTextBoxText = "BBb";
//        }
//    }
//}
