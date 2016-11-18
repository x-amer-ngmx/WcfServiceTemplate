using System.Runtime.Serialization;

namespace WcfServiceTemplate.IContract.Contract
{
    [DataContract]
    public class Index
    {
        [DataMember]
        public string Param { get; set; }
    }
}
