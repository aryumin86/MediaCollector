﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Entities
{
    public class MMPublication
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Content {get; set;}
        public DateTime PubDate {get; set;}
        public string Url {get; set;}
    }
}
