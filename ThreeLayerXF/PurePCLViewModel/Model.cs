using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PurePCLViewModel
{
    public class Model : INotifyPropertyChanged
    {
        public string TheAnswer { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AskTheQuestion()
        {
            // TODO call another PCL layer
            if (string.IsNullOrEmpty(TheAnswer))
                TheAnswer = "dunno";
            else 
                TheAnswer = "";

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("TheAnswer"));  // normally woudl be setter
        }
    }
}
