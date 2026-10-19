using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerAPI.Data
{
    public class ExpenseTrackerContext : DbContext
    {
        public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options) : base(options)    
        { 
            
        }
    }
}


//public class LibraryDbContext : DbContext
//{
//    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
//        : base(options)
//    {
//    }

//    public DbSet<Book> Books { get; set; }
//}
