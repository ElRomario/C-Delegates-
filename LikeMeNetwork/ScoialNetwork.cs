using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeMeNetwork
{
    public delegate void EventHandler(string message);
    internal class ScoialNetwork
    {
        public EventHandler SubscriberEventHandler;

        public void SendHackerJournal()
        {
            SubscriberEventHandler?.Invoke("Hacker Journal Vol2");
        }
        public void SendGamingJournal()
        {
            SubscriberEventHandler?.Invoke("Gaming Journal Vol3");
        }
         
    }
}
