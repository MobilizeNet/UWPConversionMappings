using System;


namespace WindowsPhoneUWP.UpgradeHelpers
{


    public class RunWorkerCompletedEventArgsHelper : System.ComponentModel.AsyncCompletedEventArgs
    {
        private object result;


        public object Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return this.result;
            }
        }



        public new object UserState
        {
            get
            {
                return base.UserState;
            }
        }

        public RunWorkerCompletedEventArgsHelper(object result, Exception error, bool cancelled)
          : base(error, cancelled, (object)null)
        {
            this.result = result;
        }
    }
}