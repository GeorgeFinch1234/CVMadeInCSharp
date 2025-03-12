namespace CV.Models
{
    public class Message
    {
        //String Name, String Company, String EmailAddress, String PhoneNumber, String Subject, String Messag
        public int ID { get; set; }
        public String Name { get; set; }
        public String? Company { get; set; }
        public String Email { get; set; }

        public String PhoneNumber { get; set; }
        public String Subject { get; set; }
        public String UserMessage { get; set; }

    }
}
