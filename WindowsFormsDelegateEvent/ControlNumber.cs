using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDelegateEvent
{
    public class ControlNumber
    {
        //Binding a method from one class to event in another class.
        public delegate void ControlNumberHandler();
        //Events receives delegates as a type.
        public event ControlNumberHandler NumberState;

        public string NumberStateMessage { get; set; } = "Negative integers are not accepted. Enter a number greater than or equal to zero.";

        public bool IsControlNumberSuccess { get; set; }

        private int _number;

        public int Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
                if(_number < 0)
                {
                    //let event execute
                    //Event will execute ControlNumberHandler's delegate method.
                    if (NumberState != null)
                    {
                        IsControlNumberSuccess = false;
                        NumberState();
                    }

                }
                else
                {
                    IsControlNumberSuccess = true;
                }
            }
        }
    }
}
