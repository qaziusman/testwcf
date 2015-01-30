using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnock.Util
{
    public class MathUtil
    {
        static int MAX_SAFE_FABONACCI_NUMBER = 92;

        public static Int64 GetNthFibonacci(Int64 n)
        {
            if (n == 0)
                return n;

            bool isNegativeInput = (n < 0);
            if (isNegativeInput)
                n = -n;

            if (n > MAX_SAFE_FABONACCI_NUMBER)
                throw new ArgumentOutOfRangeException("n", "Numbers greater than 92 would cause an out of range exception");

            Int64 previousNum = 0;
            Int64 nFibonacciNum = 1;
            Int64 buffer;

            for (Int64 i = 1; i < n; i++)
            {
                buffer = nFibonacciNum;
                nFibonacciNum += previousNum;
                previousNum = buffer;
            }

            return isNegativeInput ? (-nFibonacciNum) : nFibonacciNum;
        }

        public static TriangleType WhatShapeIsThis(Int32 a, Int32 b, Int32 c)
        {
            if ((a >= (b + c)) || (b >= (a + c)) || (c >= (a + b)))
                return TriangleType.Error;
            else if (a == b && b == c)
                return TriangleType.Equilateral;
            else if (a == b || a == c || b == c)
                return TriangleType.Isosceles;
            else
                return TriangleType.Scalene;
        }
    }
}