using IKYS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.Domain.Entity
{
    public class Chef : PersonelBase
    {
        public int OffDay { get; set; }
        public int MounthWage { get; set; }
        public int Shift { get; set; }
        public bool? HauseRent { get; set; }
    }
}
