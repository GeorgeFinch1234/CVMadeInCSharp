
using Microsoft.EntityFrameworkCore;

namespace CV.Models
{
    public class MessageContext :DbContext
    {


        public MessageContext(DbContextOptions<MessageContext> options) : base(options) { }
        public DbSet<Message> messages { get; set; }
    }
}
