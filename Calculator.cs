namespace DotNetSimpleCodeQuality
{
    class Calculator
    {
        public int firstnumber { get; set; }
        public int secondnumber { get; set; }

        public void add()
        {
            result = firstnumber + secondnumber;
        }

        public void subtract()
        {
            result = firstnumber - secondnumber;
        }

        public int result{get;set;}
    }

    class CalculateThreethings
    {
        public int firstnumber { get; set; }
        public int secondnumber { get; set; }
        public int thirdnumber {get;set;}

        public void add()
        {
            result = firstnumber + secondnumber + thirdnumber;
        }

        public void subtract()
        {
            result = firstnumber - secondnumber - thirdnumber;
        }

        public int result{get;set;}
    }

    class Stringcounter
    {
        public int length {get;set;}
        public string myString {get;set;}
        public void CountmyString()
        {
            length = myString.Length;
        }
        public string TellmeAboutit()
        {
            if (length == 0)
                return "Your string is empty";
            else if(length > 0 && length < 10)
                return "your string is short";
            else if (length >10 && length<20)
                return "string is medium";
            else if (length > 20 && length < 30)
                return "quite big";
            else if (length >30 && length > 40)
                return "massive string";

            return "WOAH BIG BOY!!!!";
        }

    }
}