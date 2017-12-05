using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigChange.General
{
    public static class RemoveCharsExtension
    {
        public static string RemoveConsecutiveChars(this string str, int NrChars)
        {
            string strResult = "";
            int iMatchCount = 0;
            int i = 0;

            // Make sure the NrChars is not invalid. 
            if (NrChars < 1 )
            {
                return str;
            }

            // Iterate through whole string. 
            for (i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    iMatchCount++;

                    // Ok, to copy. 
                    if (iMatchCount < NrChars)
                        strResult += str[i];
                }
                else
                {
                    // Reset match count as chars are different. 
                    iMatchCount = 0;

                    strResult += str[i];
                }
            }

            // Handle the end case (i.e. last char)
            if (str[i] == str[i - 1])
            {
                iMatchCount++;

                if (iMatchCount < NrChars)
                    strResult += str[i];
            }
            else
            {
                strResult += str[i];
            }

            // Set up return value...
            return strResult;
        }
    }

}
