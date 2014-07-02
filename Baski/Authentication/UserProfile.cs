using System.Web.Profile;
using System.Web.Security;

namespace Baski.Authentication
{
    public class UserProfile : ProfileBase
    {
        public virtual string Name
        {
            get
            {
                return ((string)(this.GetPropertyValue("Name")));
            }
            set
            {
                this.SetPropertyValue("Name", value);
            }
        }
        public virtual int BirthDate
        {
            get
            {
                return ((int)(this.GetPropertyValue("BirthDate")));
            }
            set
            {
                this.SetPropertyValue("BirthDate", value);
            }
        }
        public virtual int Country
        {
            get
            {
                return ((int)(this.GetPropertyValue("Country")));
            }
            set
            {
                this.SetPropertyValue("Country", value);
            }
        }
        public virtual int Ethnicity
        {
            get
            {
                return ((int)(this.GetPropertyValue("Ethnicity")));
            }
            set
            {
                this.SetPropertyValue("Ethnicity", value);
            }
        }
        public virtual string ZipCode
        {
            get
            {
                return ((string)(this.GetPropertyValue("ZipCode")));
            }
            set
            {
                this.SetPropertyValue("ZipCode", value);
            }
        }
        public static UserProfile GetUserProfile(string email)
        {
            return Create(email) as UserProfile;
        }

        public static UserProfile GetUserProfile()
        {
            return Create(Membership.GetUser().UserName) as UserProfile;
        }
       
    }
}