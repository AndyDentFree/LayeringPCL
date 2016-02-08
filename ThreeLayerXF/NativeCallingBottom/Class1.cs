using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeCallingBottom
{
    public class NativeCaller
    {
        private int fakeNativeValue;// will be replaced very shortly by a native call

        public NativeCaller()
        {
            fakeNativeValue = 42;
        }

        public int AnswerValue()
        {
            return fakeNativeValue++;
        }
    }
}
