using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using NativeCallingBottom;

namespace PurePCLViewModel
{
    public class Model : INotifyPropertyChanged
    {
        public string TheAnswer { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly NativeCaller _modelModel;

        public Model()
        {
            _modelModel = new NativeCaller();
        }

        public void AskTheQuestion()
        {
            TheAnswer = $"The Answer is {_modelModel.AnswerValue()}";
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("TheAnswer"));  // normally woudl be setter
        }
    }
}
