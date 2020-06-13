using System;
using System.Data.Entity.Validation;
using System.Linq;
using WCFTaskFourService.DataBase;
using WCFTaskFourService.Domains.FriendsManagement;

namespace WCFTaskFourService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FriendService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FriendService.svc or FriendService.svc.cs at the Solution Explorer and start debugging.
    public class FriendService : IFriendService
    {
        private readonly WCFContext _context;

        public FriendService()
        {
            _context = new WCFContext();
        }

        public string GetValidations(DbEntityValidationException exception)
        {
            var entityValidationErrors = exception.EntityValidationErrors
                      .SelectMany(validation => validation.ValidationErrors
                          .Select(error => error.ErrorMessage));

            return string.Join(";", entityValidationErrors.ToArray());
        }

        public string AddFriend(Friend friend)
        {
            try
            {
                _context.Friend.Add(friend);
                _context.SaveChanges();
                return "succeded";
            }
            catch (DbEntityValidationException exception)
            {
                return GetValidations(exception);
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string GetBirthdayFriends()
        {
            var birthdayedFriends = _context.Friend
                                       .Where(friend => friend.BirthDate == DateTime.Now)
                                         .Select(friend => friend.FriendName).ToArray();
            if(birthdayedFriends != null)
            {
                var result = string.Join(";", birthdayedFriends);
                return result;
            }

            return "";
        }
    }
}
