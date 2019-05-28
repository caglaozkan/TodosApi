using System.Collections.Generic;

namespace TodoApi.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public virtual List<Todo> Todos {get; set;}

    }
}
