namespace Lib.Entities
{
    public class SmBlog
    {
        public int Id {get; set;}
        public string Url {get; set;}
        public string Title {get; set;}
        public int SourceId {get; set;}
        public SMSource SMSource {get; set;}
    }
}