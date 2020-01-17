using System;
using System.Collections.Generic;

namespace GraphQLWeb.Models
{
    public class GlobalUserRepo
    {
        public static IEnumerable<GlobalUser> GetGlobalUsers()
        {
            return new List<GlobalUser>()
            {
                new GlobalUser(){ Id = 1, FirstName = "Luke", LastName = "I"}

                //new GlobalUser(){ Id = 1, TamId = "EB27F2306251", Status = true, FirstName = "Luke", LastName = "I", MobilePhone = "09221212933", Email = "Light", Company = "Luke", CountryId = new Guid("8B173644-6730-EA11-A601-281878E92C65"), UserTimeZone = "Light", PreferredTimeZone = "(GMT+08:00) Kuala Lumpur, Singapore", ShortDateFormatId = new Guid("83183644-6730-EA11-A601-281878E92C65"), LongDateFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), TimeFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), LanguageId =  new Guid("8C183644-6730-EA11-A601-281878E92C65"), HasEmailAlert = true, HasPhoneAlert = true},
                //new GlobalUser(){ Id = 2, TamId = "YB27F2306251", Status = true, FirstName = "Mark", LastName = "II", MobilePhone = "095346124563", Email = "Light", Company = "Mark", CountryId =new Guid("D0173644-6730-EA11-A601-281878E92C65"), UserTimeZone = "Light", PreferredTimeZone = "(GMT+08:00) Kuala Lumpur, Singapore", ShortDateFormatId = new Guid("83183644-6730-EA11-A601-281878E92C65"), LongDateFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), TimeFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), LanguageId =  new Guid("8C183644-6730-EA11-A601-281878E92C65"), HasEmailAlert = true, HasPhoneAlert = true},
                //new GlobalUser(){ Id = 3, TamId = "TB27F2306251", Status = true, FirstName = "John", LastName = "III", MobilePhone = "09234353", Email = "Light", Company = "John", CountryId = new Guid("E4173644-6730-EA11-A601-281878E92C65"), UserTimeZone = "Light", PreferredTimeZone = "(GMT+08:00) Kuala Lumpur, Singapore", ShortDateFormatId = new Guid("83183644-6730-EA11-A601-281878E92C65"), LongDateFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), TimeFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), LanguageId = new Guid("8C183644-6730-EA11-A601-281878E92C65"), HasEmailAlert = true, HasPhoneAlert = true},
            };
        }
    }
}