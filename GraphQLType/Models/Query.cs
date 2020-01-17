using GraphQL;
using GraphQLType.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GraphQLType
{
    public class Query
    {
        public static HttpClient client = new HttpClient();

        //public async void GetGlod()
        //{
        //    var id = "88173644-6730-ea11-a601-281878e92c65";
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6InBpVmxsb1FEU01LeGgxbTJ5Z3FHU1ZkZ0ZwQSIsImtpZCI6InBpVmxsb1FEU01LeGgxbTJ5Z3FHU1ZkZ0ZwQSJ9.eyJhdWQiOiJkZWYyNjY3Zi1hNThiLTQxNjUtOWFkMS1lNmRiNTQ1Njk3ZDgiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC9kYWJkNWQ5MC04N2MyLTQ0YzktOTNjZC03ODNlMDMyMzZlNDAvIiwiaWF0IjoxNTc4OTA3ODM5LCJuYmYiOjE1Nzg5MDc4MzksImV4cCI6MTU3ODkxMTczOSwiYWNyIjoiMSIsImFpbyI6IjQyTmdZRERrMHc0Sy83SlRyRW1paW9mUjdMdkp0Mk1uMmZqUFNtUy9LUllwcm52ZTZnQUEiLCJhbXIiOlsicHdkIiwicnNhIl0sImFwcGlkIjoiOTYzZThlNzAtZmNmOS00NGUzLTg4MDYtOGVkMDc4YTEwZGVmIiwiYXBwaWRhY3IiOiIwIiwiZGV2aWNlaWQiOiIxODU4OWRiOS01MWZiLTQ4OWQtOWVjYi1lMTQ2MDEyMWJmMTMiLCJmYW1pbHlfbmFtZSI6IkxlZGRhIiwiZ2l2ZW5fbmFtZSI6IkpvaG4gQ2hyaXN0aWFuIiwiaW5fY29ycCI6InRydWUiLCJpcGFkZHIiOiIxMjEuNTguMjQ4Ljg0IiwibmFtZSI6IkpvaG4gQ2hyaXN0aWFuIExlZGRhIiwib2lkIjoiYWU2MGY3OGEtNmM4Yy00MmJjLTliODAtNDUyYzhiOWQxODM4Iiwib25wcmVtX3NpZCI6IlMtMS01LTIxLTQyNzIyNzc4NjYtMzE4NzY5MDg0Mi0xNjcyNTAyMDI4LTU1OTMzIiwic2NwIjoiRmlsZXMuUmVhZCB1c2VyX2ltcGVyc29uYXRpb24iLCJzdWIiOiI2OGhhSkZGd1haaXhGSndlS3NCMURDb3JMQkdKWERrSUxkeVdkc3dkZ2hnIiwidGlkIjoiZGFiZDVkOTAtODdjMi00NGM5LTkzY2QtNzgzZTAzMjM2ZTQwIiwidW5pcXVlX25hbWUiOiI3ODM2MEBncnVuZGZvcy5jb20iLCJ1cG4iOiI3ODM2MEBncnVuZGZvcy5jb20iLCJ1dGkiOiJzdkJQQS13YUNVV1RmaVlsZlgtUkFBIiwidmVyIjoiMS4wIn0.aXgFu-if9iIgkrnIAeyvmbU28KrmWpvczio_O6-0UJjnwEJEtigzwEvq3Onrg59cIEWmFFaCJnyiSG6r9pbGITtBsJqb2IOEZ_Gbdj2ZU3kBVOnlxPG-C2zb0wYxT9aTjrIfWTV4JhsxTUEsWWi7O5070evKESQoSe-_01EziqlPFxV05MGXgUSR8-WZYTqPDy5oRTdyQbssokwcLQlsKZDqSzKTYDba4HAOaVRB3jow53Du096AB3GtVrxPA4XoZmwP6kFyIiEjTQxKPvs5mnULtXGFOLDrmpbN9gGZgJPmPMUZgPuE-c8bCUZsHH6Udn6Ggadh4zV8mGL5j0BiEA");
        //    HttpResponseMessage response = await client.GetAsync(string.Format("https://localhost:44377/api/Countries/Get/{0}",id));
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var test = await response.Content.ReadAsStringAsync();
        //    }
        //}
  
        [GraphQLMetadata("globalusers")]
        public IEnumerable<GlobalUser> GetGlobalUsers()
        {
            return GlobalUserRepo.GetGlobalUsers();
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "hello worlds";
        }

        [GraphQLMetadata("globaluser")]
        public GlobalUser GetGlobalUser(int id)
        {
            return GlobalUserRepo.GetGlobalUsers().SingleOrDefault(j => j.Id == id);
        }
    }
}