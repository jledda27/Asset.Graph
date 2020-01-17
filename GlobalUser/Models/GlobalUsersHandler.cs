using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalUser.Models
{
    public class GlobalUsersHandler
    {
        [GraphQLMetadata("jedis")]
        public IEnumerable<GlobalUsers> GetJedis()
        {
            return GlobalUsersRepo.GetGlobalUsers();
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "hello worlds";
        }

        [GraphQLMetadata("jedi")]
        public GlobalUsers GetJedi(Guid id)
        {
            return GlobalUsersRepo.GetGlobalUsers().SingleOrDefault(j => j.Id == id);
        }
    }
}
