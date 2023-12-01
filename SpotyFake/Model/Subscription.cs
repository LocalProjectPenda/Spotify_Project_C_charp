using System;
using SpotyFake.Time;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
  public enum NameSubs
    {
        Basic,
        Premium,
        Gold
    }
    internal class Subscription
    {
        public NameSubs _type { get; set; }
        public decimal _price { get; set; }
        public double timeSub { get; set; }
       // public NameSubs _nameSubs;

        List<User>users { get; set; }
        public Subscription(NameSubs name, decimal price, double duration)
        {
            _type = name;
            _price = price;
            this.timeSub = duration;
            users = new List<User>();
            
        }

        public TimeSpan GetSubscrib(Subscription sub)
        {
            ConfigTime configTime = new ConfigTime();

            if (sub._type == NameSubs.Basic ) 
            {
                
                TimeSpan myTime = configTime.GenTimeSpanFromMinutes(100);
                return myTime;

            }
            else if  (sub._type == NameSubs.Premium)
            {
                
                TimeSpan myTime = configTime.GenTimeSpanFromMinutes(1000);
                return myTime;
            }
            else
            {
                TimeSpan myTime = configTime.GenTimeSpanFromMinutes(0);
                return myTime;
            }


        }
    }

}
