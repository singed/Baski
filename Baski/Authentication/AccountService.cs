using System.Web.Security;

namespace Baski.Authentication
{
    public interface IAccountService
    {
        IMembershipService MembershipService { get;}
        IFormsAuthenticationService FormsAuthenticationService { get; }
    }

    public class AccountService : IAccountService
    {
        public IMembershipService MembershipService { get; private set; }
        public IFormsAuthenticationService FormsAuthenticationService { get; private set; }
        public AccountService(IValidationDictionary validationDictionary)
            : this(null, validationDictionary)
        {
        }

        public AccountService(MembershipProvider membershipProvider, IValidationDictionary validationDictionary)
        {
            MembershipService = new MembershipService(membershipProvider, validationDictionary);
            FormsAuthenticationService = new FormsAuthenticationService();
        }

    }
}