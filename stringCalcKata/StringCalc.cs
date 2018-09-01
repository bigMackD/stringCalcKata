using System;
using System.Collections.Generic;
using System.Text;

namespace stringCalcKata
{
   public class StringCalc
    {
        public int Add (string input)
        {
            if (input == "")
            {
                return 0;
            }
            else if (input.Contains(",") == false)
            {
                return int.Parse(input);
            }

            else
            {
                string[] splitCharsArray = new string[3] { ",", "\n" , "///()" };
                string[] numbersArray = input.Split(splitCharsArray, StringSplitOptions.None);
                int sum = 0;
                for(int i = 0; i < numbersArray.Length; i++)
                {
                    if(Int16.Parse(numbersArray[i]) < 0)
                    {
                        //throw exeption
                        throw new System.ArgumentException("negatives not allowed!");
                    }
                    else
                    {
                        if (Int16.Parse(numbersArray[i]) < 1000)
                            sum += Int16.Parse(numbersArray[i]);
                    }
                }
                return sum;
            }
        }
    }
}
