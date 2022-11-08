using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfleveringFredag
{
    internal  class BilInfo
    {
        public string BilMærke { get; set; }
        public string BilModel { get; set; }
        public string BilÅrgang { get; set; }
        public DateTime BilSyn { get; set; }
        public DateTime SynDato { get; set; } = DateTime.Today;
        public string synshal()
        {
            return SynDato.ToString("D");
        }
    }
}

.