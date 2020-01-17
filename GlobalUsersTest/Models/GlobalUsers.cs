using System;
  
namespace GlobalUsersTest.Models
{
    public class GlobalUsers
    {
        public Guid Id { get; set; }
        public string TamId { get; set; }
        public bool Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public Guid? CountryId { get; set; }
        public string UserTimeZone { get; set; }
        public string PreferredTimeZone { get; set; }
        public Guid ShortDateFormatId { get; set; }
        public Guid LongDateFormatId { get; set; }
        public Guid TimeFormatId { get; set; }
        public Guid LanguageId { get; set; }
        public bool HasEmailAlert { get; set; }
        public bool HasPhoneAlert { get; set; }
    }
}