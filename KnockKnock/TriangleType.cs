using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KnockKnock
{
    [DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType
    {
        [EnumMemberAttribute()]
        Error,
        [EnumMemberAttribute()]
        Equilateral,
        [EnumMemberAttribute()]
        Isosceles,
        [EnumMemberAttribute()]
        Scalene,
    }
}