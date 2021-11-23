using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsMvvm.ViewModels;

namespace WinFormMvvmTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vm = new MainViewModel(new MessageServiceMock());
            vm.Save();
            //Assert.AreEqual("SAVE!", vm.)
        }
    }
}
