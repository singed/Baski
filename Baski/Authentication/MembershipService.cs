using System.Web.Mvc;
using System.Web.Security;
using Baski.Authentication.Models;

namespace Baski.Authentication
{
    public interface IMembershipService
    {
        bool LogOnUser(LogOnModel logOnModel);
    }
    public class MembershipService : IMembershipService
    {
        private readonly MembershipProvider _provider;
        private readonly IValidationService _validationService;
        public MembershipService(MembershipProvider provider)
            : this(provider, new ModelStateWrapper(new ModelStateDictionary()))
        {
        }

        public MembershipService(MembershipProvider provider, IValidationDictionary validationDictionary)
        {
            _provider = provider ?? Membership.Provider;
            _validationService = new ValidationService(validationDictionary, this);
        }

        public MembershipProvider Provider
        {
            get { return _provider; }
        }
        public IValidationService ValidationService
        {
            get { return _validationService; }
        }
        public bool LogOnUser(LogOnModel logOnModel)
        {
            return _validationService.UserLogOnValidation(logOnModel);
        }

       
    }
}