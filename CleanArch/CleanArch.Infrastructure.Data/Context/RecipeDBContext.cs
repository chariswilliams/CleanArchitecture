using CleanArch.Domain.Models;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.EntityFrameworkCore;
using Amazon.DynamoDBv2;

namespace CleanArch.Infrastructure.Data.Context
{
    public class RecipeDBContext : DynamoDBContext
    {
        public RecipeDBContext(AmazonDynamoDBClient client, DynamoDBContextConfig options) : base(client, options)
        {
        }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
