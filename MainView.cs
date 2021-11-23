using System;
using System.Windows.Forms;
using WindowsMvvm.ViewModels;

namespace WindowsMvvm.Views
{
    public partial class MainView : Form
    {
        private MainViewModel view_model_ = new MainViewModel()
;       public MainView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.MyTextBox.DataBindings.Add("Text", this.view_model_, "MyTextBoxText");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text = MyTextBox.Text;
            this.view_model_.Call();
        }
    }
}
