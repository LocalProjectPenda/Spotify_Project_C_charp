using System;
using SpotyFake.Time;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    enum NameSubs
    {
        Basic,
        Premium,
        Gold
    }
    internal class Subscription
    {
        public NameSubs _type { get; set; }
        public decimal _price { get; set; }
        public TimeSpan timeSub { get; set; }

        List<User>users { get; set; }
        public Subscription(NameSubs name, decimal price, TimeSpan duration)
        {
            _type = name;
            _price = price;
            this.timeSub = duration;
            users = new List<User>();
        }

        public void AddSubscrib(Subscription sub)
        {
            ConfigTime configTime = new ConfigTime();

            if (sub._type == NameSubs.Basic ) 
            {
                sub._price = 50;
                sub.timeSub = configTime.GenTimeSpanFromMinutes(100);

            }
            else if  (sub._type == NameSubs.Premium)
            {
                sub._price = 100;
                sub.timeSub = configTime.GenTimeSpanFromMinutes(100);
            }
            else
            {
                sub._price = 150;
                sub.timeSub = configTime.GenTimeSpanFromMinutes(100);
            }


        }
    }

}
