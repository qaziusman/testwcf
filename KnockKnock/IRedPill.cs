using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KnockKnock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRedPill" in both code and config file together.
    [ServiceContractAttribute(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        [FaultContract(typeof(ArgumentOutOfRangeException), Name = "ArgumentOutOfRangeException")]
        Int64 FibonacciNumber(Int64 n);

        [OperationContract]
        TriangleType WhatShapeIsThis(Int32 a, Int32 b, Int32 c);

        [OperationContract]
        [FaultContract(typeof(ArgumentNullException), Name = "ArgumentNullException")]
        string ReverseWords(string s);
    }
}
