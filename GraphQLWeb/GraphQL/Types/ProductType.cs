using GraphQL.Types;
using GraphQLWeb.Models;

namespace GraphQLWeb.GraphQL.Types
{
    public class ProductType : ObjectGraphType<GlobalUser>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.FirstName);
            Field(t => t.LastName);
        }
    }
}