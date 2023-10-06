using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPI_interface.Classes
{
    [Serializable]
    public class Host
    {
        public string IPaddress { get; set; }
        public string HostName { get; set; }
        public Boolean IsConnected { get; set; }

        public Host(string _ipaddress)
        {
            this.IPaddress = _ipaddress;
            this.HostName = null;
            this.IsConnected = false;
        }

        private Host(string _ipaddress, string _hostname, Boolean _isconnected)
        {
            if(_ipaddress==null)
                throw new Exception("Null IP address name reference exeception!");
            this.IPaddress = _ipaddress;
            if (_hostname == null)
                throw new Exception("Null host name reference exeception!");
            this.HostName = _hostname;
            this.IsConnected = _isconnected;
        }

        //for XML serialization
        public Host() { }

        Boolean CheckConnectivity()
        {
            return false;
        }

        void WOL()
        {

        }



    }
}
