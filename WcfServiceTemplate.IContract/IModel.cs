using System.ServiceModel;
using WcfServiceTemplate.IContract.Contract;

namespace WcfServiceTemplate.IContract
{
    [ServiceContract(Namespace = "", Name = "")]
    public interface IModel
    {
        [OperationContract(Name = "", Action = "", ReplyAction = "")]
        Index Index();
    }
}
