using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsMvvm.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string my_textbox_text_ = string.Empty;
        public string MyTextBoxText
        {
            get { return my_textbox_text_; }
            set
            {
                SetProperty(ref my_textbox_text_, value, "MyTextBoxText");
            }
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
