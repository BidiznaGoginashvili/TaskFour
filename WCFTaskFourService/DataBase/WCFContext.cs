using System.Data.Entity;
using WCFTaskFourService.Domains.FriendsManagement;

namespace WCFTaskFourService.DataBase
{
    public class WCFContext : DbContext
    {
        public DbSet<Friend> Friend { get; set; }

        public WCFContext() : base(@"Server=DESKTOP-KCSUK0G\BIDZINASQL; Database=WCFTaskFour; Trusted_Connection=True")
        {

        }
    }
}