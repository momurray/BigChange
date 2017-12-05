using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigChange.General
{
    public static class FizzBuzz
    {
        public static (bool, List<string>, string Message) Calculate(int endvalue, int iFizz = 3, int iBuzz = 5)
        {
            // Create my empty list of strings, default return code, message....
            List<string> listResults = new List<string>();
            bool bRet = false;
            string Message = "";

            try
            {
                // Need to check I don't have any divide by zero errors. 
                if (iFizz < 1 || iBuzz < 1)
                {
                    return (bRet, listResults, $"ERROR : Fizz or Buzz values can't be less than 1. ({iFizz}, {iBuzz})");
                }

                // Also check main number isn't less than 1. 
                if (endvalue < 1 )
                {
                    return (bRet, listResults, $"ERROR : Main value must be at least 1. {endvalue}");
                }

                // Loop through all the numbers. 
                for (int i = 1; i <= endvalue; i++)
                {
                    bool bFizz = false;
                    string fbResult = "";

                    if (i % iFizz == 0)
                    {
                        int iNr = i / iFizz;

                        fbResult = "Fi" + new String('z', iNr);

                        bFizz = true;
                    }

                    if (i % iBuzz == 0)
                    {
                        int iNr = i / iBuzz;

                        if (bFizz)
                        {
                            fbResult += "-";
                        }

                        fbResult += "Bu" + new String('z', iNr);
                    }

                    if (fbResult != "")
                        listResults.Add($"{i}={fbResult}");
                    else
                        listResults.Add($"{i}");
                }

                bRet = true;
                Message = $"Success : {listResults.Count} results returned";
            }
            catch (Exception ex)
            {
                // This catches everything but could be tailored to just capture divide by zero for example. 
                Message = $"Runtime ERROR encountered.{ex.Message}";
            }

            return (bRet, listResults, Message);
        }
    }
}
