using System;

namespace Lib.Entities
{
    public class SMPublication
    {
        public long Id {get; set;}
        public string Title {get; set;}
        public string Content {get; set;}
        public DateTime PubDate {get; set;}
        public string AuthorName {get; set;}
        public int SourceId {get; set;}
        public SMSource Source {get; set;}
    }
}