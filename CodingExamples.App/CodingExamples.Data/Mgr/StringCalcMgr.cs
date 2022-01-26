using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingExamples.Data.Constants;

namespace CodingExamples.Data.Mgr
{
    public class StringCalcMgr
    {
        private List<string> SEPERATORS = new List<string>() { ",", "\n" };

        public int Add(string numbers)
        {
            if (String.IsNullOrWhiteSpace(numbers))
                return StringCalcConst.DEFAULT_NUMBER;
            if (numbers.StartsWith(StringCalcConst.CUSTOM_SEPERATOR_INDICATOR))
            {
                numbers = AddCustomSeperators(numbers);
            }
            var cleanedNumbers = CleanNumbers(numbers);

            return cleanedNumbers.Sum();
        }

        private string AddCustomSeperators(string numbers)
        {
            string[] customSeperators = { StringCalcConst.CUSTOM_SEPERATOR_INDICATOR, "[", "]" };
            var customSeperator = numbers.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).First();

            numbers = numbers.Substring(customSeperator.Length, numbers.Length - customSeperator.Length);
            var allCustomSeperators = customSeperator.Split(customSeperators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sep in allCustomSeperators)
            {
                SEPERATORS.Add(sep);
            }
            return numbers;
        }

        private IList<int> CleanNumbers(string numbers)
        {
            var nums = numbers.Split(SEPERATORS.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            List<int> cleaned = new List<int>();
            foreach (var num in nums)
            {
                var cleanedNumber = int.Parse(num);
                if (cleanedNumber < 0)
                {
                    throw new ApplicationException("Number cannot be negative");
                }
                if (cleanedNumber <= StringCalcConst.MAX_NUMBER)
                {
                    cleaned.Add(cleanedNumber);
                }
            }
            return cleaned;
        }
    }
}
