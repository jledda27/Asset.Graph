using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalUser.Models
{
    public class GlobalUsersRepo
    {
        public static IEnumerable<GlobalUsers> GetGlobalUsers()
        {
            return new List<GlobalUsers>() {
                    new GlobalUsers(){Id = new Guid("479B094B-6830-EA11-A601-281878E92C65"), TamId = "EB27F2306251", Status = true, FirstName = "Luke", LastName = "I", MobilePhone = "09221212933", Email = "Light", Company = "Luke", CountryId = new Guid("8B173644-6730-EA11-A601-281878E92C65"), UserTimeZone = "Light", PreferredTimeZone = "(GMT+08:00) Kuala Lumpur, Singapore", ShortDateFormatId = new Guid("83183644-6730-EA11-A601-281878E92C65"), LongDateFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), TimeFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), LanguageId =  new Guid("8C183644-6730-EA11-A601-281878E92C65"), HasEmailAlert = true, HasPhoneAlert = true},
                    new GlobalUsers(){Id = new Guid("CB10502B-C732-EA11-A601-281878E92C65"), TamId = "YB27F2306251", Status = true, FirstName = "Mark", LastName = "II", MobilePhone = "095346124563", Email = "Light", Company = "Mark", CountryId =new Guid("D0173644-6730-EA11-A601-281878E92C65"), UserTimeZone = "Light", PreferredTimeZone = "(GMT+08:00) Kuala Lumpur, Singapore", ShortDateFormatId = new Guid("83183644-6730-EA11-A601-281878E92C65"), LongDateFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), TimeFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), LanguageId =  new Guid("8C183644-6730-EA11-A601-281878E92C65"), HasEmailAlert = true, HasPhoneAlert = true},
                    new GlobalUsers(){Id = new Guid("BEDDB87B-C732-EA11-A601-281878E92C65"), TamId = "TB27F2306251", Status = true, FirstName = "John", LastName = "III", MobilePhone = "09234353", Email = "Light", Company = "John", CountryId = new Guid("E4173644-6730-EA11-A601-281878E92C65"), UserTimeZone = "Light", PreferredTimeZone = "(GMT+08:00) Kuala Lumpur, Singapore", ShortDateFormatId = new Guid("83183644-6730-EA11-A601-281878E92C65"), LongDateFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), TimeFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"), LanguageId = new Guid("8C183644-6730-EA11-A601-281878E92C65"), HasEmailAlert = true, HasPhoneAlert = true},
            };
        }

        public static GlobalUsers GetGlobalUserDetail(int id)
        {
            return new GlobalUsers()
            {
                TamId = "EB27F2306251",
                Status = true,
                FirstName = "Luke",
                LastName = "I",
                MobilePhone = "09221212933",
                Email = "Light",
                Company = "Luke",
                CountryId = new Guid("8B173644-6730-EA11-A601-281878E92C65"),
                UserTimeZone = "Light",
                PreferredTimeZone = "(GMT+08:00) Kuala Lumpur, Singapore",
                ShortDateFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"),
                LongDateFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"),
                TimeFormatId = new Guid("82183644-6730-EA11-A601-281878E92C65"),
                LanguageId = new Guid("8C183644-6730-EA11-A601-281878E92C65"),
                HasEmailAlert = true,
                HasPhoneAlert = true,
            };
        }
    }
}
