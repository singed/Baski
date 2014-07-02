namespace Baski.Authentication
{
    /*public interface IDataAccessor
    {
        Guid GetUserIdByEmail(string userEmail);
        string CreateAndGetResetPasswordLink(string userEmail);
        string CreateAndGetConfirmRegistrationLink(string userEmail);
        bool CheckIfUserAllowChangePassword(Guid userId, Guid mark);
        void SetChangePasswordLinkToExpire(string userEmail);
        bool ConfirmRegistration(Guid userId, Guid mark);
        string GetUserEmailById(Guid userId);
    }
    public class LinqToSqlDataAccessor : IDataAccessor
    {
        private PocDataContext _dataContext = new PocDataContext();
        
        public Guid GetUserIdByEmail(string userEmail)
        {
            return (from t in _dataContext.aspnet_Memberships where t.Email == userEmail select t.UserId).FirstOrDefault();
        }
        public string GetUserEmailById(Guid userId)
        {
            return (from t in _dataContext.aspnet_Memberships where t.UserId == userId select t.Email).FirstOrDefault();
        }
     
    }*/
}