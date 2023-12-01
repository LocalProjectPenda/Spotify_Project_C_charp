using SpotyFake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Interface
{
    internal interface IMedia
    {
        public TimeSpan Play(Song song);
        public void Stop(Song song);
        public void Pause(Song song);
        public void Next(Song song);
        public void Prevew(Song song);
    }
}
