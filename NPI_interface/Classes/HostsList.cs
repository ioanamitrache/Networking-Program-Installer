using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPI_interface.Classes
{
    public sealed class HostsList
    {

        private static readonly object padlock = new object();
        private static HostsList instance = null;
        public static HostsList Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new HostsList();
            
                    return instance;    
                }
            }
        }

        HostsList()
        {

        }

        private List<Host> hList = new List<Host>();
        public List<Host> list
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("Null hosts list reference exception!");
                }

                this.hList = value;
            }
            get
            {
                return this.hList;
            }
        }

        public void Add(Host host)
        {
            if (host == null)
                throw new Exception("Null host reference exception!");

            hList.Add(host);
        }

        public void RemoveAt(int index)
        {
            if(index<0 || index>= hList.Count)
                throw new Exception("Index out of range exception!");
            hList.RemoveAt(index);
        }

        public void Delete(Host host)
        {
            if(host ==null)
                throw new Exception("Null host reference exception!");

            hList.Remove(host);
        }

        public void Clear()
        {
            hList.Clear();
        }

        public void RemoveUnconnectedHosts()
        {
            hList.RemoveAll(host => host.IsConnected == false);
        }

        public int Count()
        {
            if(hList != null)
                return list.Count;
            return 0;
        }

        public Host GetAt(int index)
        {
            if(index<0 || index >= hList.Count)
                throw new Exception("Index out of range exception!");

            return hList[index];
        }


    }
}
