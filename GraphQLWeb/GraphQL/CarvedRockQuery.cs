using GraphQL.Types;
using GraphQLWeb.GraphQL.Types;
using GraphQLWeb.Models;

namespace GraphQLWeb.GraphQL
{
    public class CarvedRockQuery : ObjectGraphType
    {
        public CarvedRockQuery()
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => GlobalUserRepo.GetGlobalUsers()
                );
        } 
    }
}