using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafeyonetimi.objects
{
    internal class Table
    {
        public DateTime createdAt { get; set; }
        public int masano { get; set; }
        public int masahesap { get; set; }
        public string id { get; set; }
        public string kafelerId { get; set; }
    }
}
