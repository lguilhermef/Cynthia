using System;
using System.Collections.Generic;

namespace cynthia_webapi.Models.Db
{
    public partial class FiverrItem
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public int IntPriority { get; set; }
        public string NvcDescription { get; set; }
        public string DtmDeadline { get; set; }
        public bool BitIsDone { get; set; }
    }
}
