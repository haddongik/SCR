using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Apparelbase.MVVMBase;


namespace WpfApp
{
    class MainViewModel : ObservableObject
    {
        private ICommand plusCommand;
        public ICommand PlusCommand
        {
            get { return (this.plusCommand) ?? (this.plusCommand = new DelegateCommand(Plus, CanPlus)); }
        }

        private bool CanPlus()
        {
            if (true)
                return true;
            else
                return false;
        }

        private void Plus()
        {
            this.TestVal++;
        }

        private int testVal;
        public int TestVal
        {
            get
            {
                return this.testVal;
            }
            set
            {
                if (this.testVal != value)
                {
                    this.testVal = value;
                    this.RaisePropertyChanged("TestVal");
                }
            }
        }
    }
}
