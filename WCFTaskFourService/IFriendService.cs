using System.ServiceModel;
using WCFTaskFourService.Domains.FriendsManagement;

namespace WCFTaskFourService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFriendService" in both code and config file together.
    [ServiceContract]
    public interface IFriendService
    {
        [OperationContract]
        string AddFriend(Friend friend);

        [OperationContract]
        string GetBirthdayFriends()
    }
}
