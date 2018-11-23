using System.ServiceModel;
namespace BankClassLibrary
{
    [ServiceContract]
    public interface IBank
    {
        [OperationContract]
        string Diposite();
        [OperationContract]
        string Withdraw();
        [OperationContract]
        string Increment();
    }
}