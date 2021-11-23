using AndersonMvvm.BindHelpers;
using AndersonMvvm.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AndersonMvvm.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IMessageService _messageService;
        private IDialogService _dialogService;

        public MainViewModel(Dispatcher dispatcher)
            : this(dispatcher, new MessageService(), new DialogService())
        {
        }


        public void SaveExecute()
        {
            if(_messageService.QuestionOKCancel("保存しますか？")
                != DialogResult.OK)
            {
                return;
            }

            // ここから
            int intResult = 0;
            if (!int.TryParse(BBBTextBoxText, out intResult))
            {
                throw new InputException("数値を入力してください");
            }

            // ここまで

            //Save...
            AAALabelText = "SAVE!!";

            StatusLabelText = "Saveしました";
        }

       
    }
}
