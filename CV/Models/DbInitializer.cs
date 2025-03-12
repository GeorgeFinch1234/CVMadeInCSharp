namespace CV.Models
{
    public class DbInitializer
    {
        public static void Initialize(MessageContext context)
        {
            

            
            context.Database.EnsureCreated();
            
            
        }
    }
}
