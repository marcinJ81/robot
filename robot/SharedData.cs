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
        private bool isEmpty = true;
        private byte[] buffer;

        public byte[] Buffer
        {
            get
            {
                Monitor.Enter(lockObject);
                byte[] value = buffer;
                Monitor.Exit(lockObject);
                return buffer;
            }
            set
            {
                Monitor.Enter(lockObject);
                buffer = value;
                Monitor.Exit(lockObject);
            }
        }

        public bool IsEmpty
        {
            get
            {
                Monitor.Enter(lockObject);
                bool value = isEmpty;
                Monitor.Exit(lockObject);
                return isEmpty;
            }
            set
            {
                Monitor.Enter(lockObject);
                isEmpty = value;
                Monitor.Exit(lockObject);
            }
        }

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
