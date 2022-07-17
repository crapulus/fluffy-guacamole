// public class WeatherQuery : ObjectGraphType
// {
//     private readonly ApplicationDbContext _appContext;
//     public WeatherQuery(ApplicationDbContext appContext)
//     {
//         this._appContext = appContext;
//         Name = "Query";
//         Field<ListGraphType<WeatherGraphType>>("w", "Returns a list of w", resolve: context => _appContext.Weathers.ToList());
//         // Field<WeatherGraphType>("w", "Returns a Single w",
//         //     new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Customer Id" }),
//         //         context => _appContext.Customers.Single(x => x.Id == context.Arguments["id"].GetPropertyValue<int>()));
//     }
// }