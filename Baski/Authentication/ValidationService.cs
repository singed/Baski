using Baski.Authentication.Models;

namespace Baski.Authentication
{
    public interface IValidationService
    {
        bool UserLogOnValidation(LogOnModel logOnModel);
    }
    public class ValidationService : IValidationService
    {
        private MembershipService _membershipService;
        private IValidationDictionary _validationDictionary;

        public ValidationService(IValidationDictionary validationDictionary, MembershipService membershipService)
        {
            _validationDictionary = validationDictionary;
            _membershipService = membershipService;
        }

        public bool UserLogOnValidation(LogOnModel logOnModel)
        {
            return _membershipService.Provider.ValidateUser(logOnModel.Email, logOnModel.Password);
        }
    }
}