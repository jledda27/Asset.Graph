using System;
using GraphQL;
using GraphQL.Types;

namespace GraphQLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.For(@"
                type Query {
                    id: String,
                    tamId:String,
                    status:String,
                    firstName: String,
                    lastName:String,
                    mobilePhone:String,
                    email: String,
                    company:String,
                    countryId:String,
                    countryIso31662: String,
                    countryName:String,
                    userTimeZone:String,
                    preferredTimeZone: String,
                    shortDateFormatId:String,
                    shortDateFormatName:String,
                    longDateFormatId: String,
                    longDateFormatName:String,
                    timeFormatId:String,
                    timeFormatName: String,
                    languageId:String,
                    languageIso6391:String,
                    hasEmailAlert: String,
                    hasPhoneAlert:String                   
                }
            ");

            var root = new { Id = "3fa85f64-5717-4562-b3fc-2c963f66afa6", TamId = "23432464-55557-4562-b3fc-2c963f66afa6" };
            var json = schema.Execute(x =>
            {
                x.Query = "{ id,tamId }";
                x.Root = root;
            });

            Console.WriteLine(json);
        }
    }
}