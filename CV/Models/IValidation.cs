namespace CV.Models
{
    public interface IValidation
    {

        public String validateOptionalString(String DataToTest);
        public String validateManditoryString(String DataToTest);

        public String validatePhoneNumber(String DataToTest);

    }
}
