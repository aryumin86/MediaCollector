using System;
using System.Collections.Generic;
using System.Text;
using Lib.Enums;

namespace Lib.Entities
{
    public class MMSource
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public MMSourceTypes SourceType {get; set;}
        public string MainUrl {get; set;}
    }
}
