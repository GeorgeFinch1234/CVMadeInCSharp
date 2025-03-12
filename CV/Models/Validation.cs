using System.Text.RegularExpressions;
using System;

namespace CV.Models
{
  
    public class Validation : IValidation
    {
        // need to double check regex is correct
        String safeString = "^[a-zA-Z0-9@ \\.]*$";
        public Validation()
        {

        }

        public String validateOptionalString(String DataToTest)
        {
            String result = "";
            //just so it doesnt cause any issues with the other testfrom being null
            if(DataToTest == null || DataToTest == "")
            {

            }
            else if (DataToTest.Length > 50){
                result = "input is to long";

            } else if (!Regex.IsMatch(DataToTest, safeString))
            {
                return  "only numbers, letter, dot and @ allowed";
            }

            return result;
        }

        public String validateManditoryString(String DataToTest)
        {
            String result = "";
            result = validateOptionalString(DataToTest);
            if(DataToTest == null || DataToTest.Length <=0)
            {
                result = "input is mandioty";
            }
            return result;
        }
        public String validatePhoneNumber(String DataToTest) {
            string result = "";
            //handles null
            if(DataToTest == null)
            {
                result = "input required";
            } else if (!(DataToTest.Length >= 9 && DataToTest.Length <= 10))
            {
                result = "must be between 9 and 10 digits.";
            }
            //regex not convert as chance will put in an int to big for it
            else if(!Regex.IsMatch(DataToTest, "^[0-9]*$"))
            {
               
                    result = "only numbers allowed";
                
            }

            return result;
        
        
        }



    }
}
