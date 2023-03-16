using Microsoft.EntityFrameworkCore;

namespace LinkedLists.Database
{
    public class LinkedListsContext : DbContext
    {
        public LinkedListsContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}