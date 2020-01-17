using System;

namespace GlobalUsersTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.For(@"
                type Jedi { name: String, side: String, id: ID } 
                type Query { hello: String, jedis: [Jedi], jedi(id: ID): Jedi}",
                x => {
                    x.Types.Include<GlobalUsersHandler>();
                });

            var json = schema.Execute(x =>
            {
                x.Query = "{ jedis { name, side }, hello ,  jedi(id: 3) { name, side }}";
            });

            Console.WriteLine(json);
        }
    }
}
