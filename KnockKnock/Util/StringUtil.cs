using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnock.Util
{
    public class StringUtil
    {
        public static string ReverseWords(string sentence)
        {
            string retVal = "";

            if (sentence == null)
                throw new ArgumentNullException("s", "null value cannot be reversed");

            retVal = string.Join(" ",
                    sentence.Split(' ').Select(x => new String(x.Reverse().ToArray()))
                    .ToArray());

            return retVal;
        }

        static string UglyFasterReverseWords(string sentence)
        {
            if (sentence == null)
                throw new ArgumentNullException("s", "null value cannot be reversed");

            if (sentence == "")
                return "";

            char[] inputArray = sentence.ToCharArray();
            char[] outPutArray = new char[sentence.Length];
            char[] tempArray = new char[sentence.Length];

            int outArrayIndex = 0;
            
            int tempArrayIndex = 0;

            for (int idx = 0; idx < sentence.Length; idx++)
            {
                if (inputArray[idx] == ' ')
                {
                    if (tempArrayIndex > 0) //temp array has data
                    {
                        //Backword copy temp array to outPut array
                        //for (int j = tempArrayIndex - 1; j >= 0; j--)
                        //    outPutArray[outArrayIndex++] = tempArray[j];
                        RevCopyArray(ref tempArray, tempArrayIndex, ref outPutArray, ref outArrayIndex);
                        tempArrayIndex = 0;
                    }
                    outPutArray[outArrayIndex++] = ' ';
                }
                else
                {
                    tempArray[tempArrayIndex++] = inputArray[idx];

                    if (idx == sentence.Length - 1)
                    {
                        if (tempArrayIndex > 0) //temp array has data
                        {
                            //Backword copy temp array to outPut array
                            RevCopyArray(ref tempArray, tempArrayIndex, ref outPutArray, ref outArrayIndex);
                            tempArrayIndex = 0;
                        }
                    }
                }
            }

            return new string(outPutArray);
        }

        static void RevCopyArray(ref char[] inputArray, int inputArrayLength, ref char[] outPutArray, ref int outArrayIndex)
        {
            for (int j = inputArrayLength - 1; j >= 0; j--)
                outPutArray[outArrayIndex++] = inputArray[j];
        }
    }
}