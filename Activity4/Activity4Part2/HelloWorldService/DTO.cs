using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HelloWorldService
{
    [DataContract]
    public class DTO
    {
        [DataMember]
        public int ErrorCode { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public List<UserModel> Data { get; set; }
    }
}