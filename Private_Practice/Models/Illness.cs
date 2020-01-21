using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    public class Illness
    {
        // Pull Illness data from ilness API
        public Guid IllnessId { get; set; }
        public string IllnessName { get; set; }
    }
}