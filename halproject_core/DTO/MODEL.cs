﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halproject_core.DTO
{
    public class MODEL
    {
        public int ID { get; set; }
        public string ADI { get; set; }
        public int MARKA_ID { get; set; }
        public DateTime CREATED_AT { get; set; }
        public int CREATED_BY { get; set; }
        public DateTime EDITED_AT { get; set; }
        public int EDITED_BY { get; set; }
    }
}
