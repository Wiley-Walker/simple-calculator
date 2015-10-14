using System;

namespace Models
{
    public class CommandParser
    {
        public CommandParser()
        {
        }

        public decimal? Parse(string testInput)
        {
            decimal answer;
             
            if (testInput.Contains("-"))
            {
                var splitOnMinus = testInput.Split('-');
                var firstValue = Convert.ToInt32(splitOnMinus[0]);
                var secondValue = Convert.ToInt32(splitOnMinus[1]);
                answer = firstValue - secondValue;
                return firstValue - secondValue;

            }
            if (testInput.Contains("+"))
            {
                var splitOnAdd = testInput.Split('+');
                 var firstValue = Convert.ToInt32(splitOnAdd[0]);
                 var secondValue = Convert.ToInt32(splitOnAdd[1]);
                answer = firstValue + secondValue;
                return firstValue + secondValue;
            }
            if (testInput.Contains("*"))
            {
                var splitOnAdd = testInput.Split('*');
                var firstValue = Convert.ToInt32(splitOnAdd[0]);
                var secondValue = Convert.ToInt32(splitOnAdd[1]);
                answer = firstValue * secondValue;
                
                return answer;
                 

            }
            if (testInput.Contains("/"))
            {
                var splitOnAdd = testInput.Split('/');
                var firstValue = Convert.ToDecimal(splitOnAdd[0]);
                var secondValue = Convert.ToDecimal(splitOnAdd[1]);
                answer = (firstValue / secondValue);
                return answer;

            }
            if (testInput.Contains("%"))
            {
                var splitOnAdd = testInput.Split('%');
                var firstValue = Convert.ToInt32(splitOnAdd[0]);
                var secondValue = Convert.ToInt32(splitOnAdd[1]);
                return firstValue % secondValue;

            }
            if (testInput.Equals("quit"))
            {
                Console.Write("Goodbye!");
                return null;
                
            }
            if (testInput.Equals("last"))
            {
                 
                return null;
            }
            {
                throw new ApplicationException("ignore");
            }


            throw new ApplicationException("Command not recognized"); 
            
        }
    }
}