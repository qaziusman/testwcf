using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using KnockKnock.Util;

namespace KnockKnock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    public class RedPill : IRedPill
    {
        #region IRedPill Members

        public Guid WhatIsYourToken()
        {
            //return new Guid("9d6777fe-e564-4232-91c6-89654570993f");
            return Guid.Empty;
        }

        public Int64 FibonacciNumber(Int64 n)
        {
            return MathUtil.GetNthFibonacci(n);
        }

        public string ReverseWords(string s)
        {
            return StringUtil.ReverseWords(s) ;
        }

        public TriangleType WhatShapeIsThis(Int32 a, Int32 b, Int32 c)
        {
            return MathUtil.WhatShapeIsThis(a, b, c);
        }
        #endregion
    }
}
