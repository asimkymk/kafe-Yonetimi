using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafeyonetimi.objects
{
    internal class Cafe
    {
        public DateTime createdAt { get; set; }
        public string kafename { get; set; }
        public string kaferesim { get; set; }
        public string kafeil { get; set; }
        public string kafeilce { get; set; }
        public int kafemasasayisi { get; set; }
        public int kafebosmasasayisi { get; set; }
        public string id { get; set; }
    }
}
