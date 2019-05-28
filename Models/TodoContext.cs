using Microsoft.EntityFrameworkCore;  
namespace TodoApi.Models {     
public class TodoContext : DbContext     
  {         
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)         
{         
}       
    public DbSet<Kisiler> TodoItems { get; set; }   
    public DbSet<User> Users  { get; set; }  
    public DbSet<Todo> Todos { get; set; }
  
   } 
}