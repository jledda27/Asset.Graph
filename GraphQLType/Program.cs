using System;
using GraphQL;
using GraphQL.Types;
using GraphQLType.Models;

namespace GraphQLType
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.For(@"
                type GlobalUser { status: String, firstname: String,lastname: String,mobilephone: String,email: String, company: String, countryid: String, usertimezone: String,preferredtimezone: String, shortdateformatid: String, longdateformatid: String, timeformatid: String, languageid: String, hasemailalert: String, hasphonealert: String, id: ID } 
                type Query { hello: String, globalusers: [GlobalUser], globaluser(id: ID): GlobalUser}", 
                x => { x.Types.Include<Query>();
                });

            var param = "{ globalusers { status, company, firstname, lastname }, hello ,  globaluser(id: 3) { status, company }}";

            var json = schema.Execute(x =>
            {
                x.Query = param;
            });

            Console.WriteLine(json);
        }
    }
}