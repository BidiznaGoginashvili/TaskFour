using System;
using System.Runtime.Serialization;

namespace WCFTaskFourService.Domains.FriendsManagement
{
    [DataContract]
    public class Friend
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FriendName { get; set; }
        [DataMember]
        public DateTime BirthDate {get;set;}
    }
}