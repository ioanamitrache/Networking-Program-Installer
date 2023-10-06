using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using CLR;

namespace NPI_interface.Classes
{
    public class ManagedManager : Manager
    {
        private static Manager instance = null;

        private ManagedManager()
        { }

        public new static Manager GetInstance()
        {
            if(instance == null)
            {
                instance = new ManagedManager();
                Manager.SetInstance(ref instance);
            }
            return instance;
        }

        public HostsConnectionControl ActiveHost { get; set; }

        public override void NotifyDownload(int percentage)
        {
            if(ActiveHost != null)
                ActiveHost.UpdateDownload(percentage);
        }
    }
}
