using System.ServiceModel;
using WcfServiceTemplate.IContract;
using WcfServiceTemplate.IContract.Contract;

namespace WcfServiceTemplate.Kernel
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class KernelRun : IModel
    {
        public Index Index()
        {
            return new Index {Param = "Default"};
        }
    }
}
