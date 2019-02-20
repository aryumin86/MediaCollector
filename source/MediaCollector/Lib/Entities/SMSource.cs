using Lib.Enums;

namespace Lib.Entities
{
    public class SMSource
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public SMSourceTypes SourceType {get; set;}
    }
}