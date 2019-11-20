
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        {
        }
    }
}
