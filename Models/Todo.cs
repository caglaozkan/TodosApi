namespace TodoApi.Models
{
    public class Todo
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool isComplete { get; set; }
        public int Userid { get; set; }
        public virtual User User {get; set;}


    }
}