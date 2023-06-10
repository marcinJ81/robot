using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace robot
{
    class SharedData
    {
        private object lockObject = new object();
        private string sharedVariable;
        private bool isSpecialString;

        public bool IsSpecialString
        {
            get
            {
                Monitor.Enter(lockObject);
                bool value = isSpecialString;
                Monitor.Exit(lockObject);
                return isSpecialString;
            }
            set
            {
                Monitor.Enter(lockObject);
                isSpecialString = value;
                Monitor.Exit(lockObject);
            }
        }

        public string SharedVariable
        {
            get
            {
                Monitor.Enter(lockObject);
                string value = sharedVariable;
                Monitor.Exit(lockObject);
                return sharedVariable;
            }
            set
            {
                Monitor.Enter(lockObject);
                sharedVariable = value;
                Monitor.Exit(lockObject);
            }
        }
    }
}
