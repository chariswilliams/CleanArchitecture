using Amazon.DynamoDBv2.DataModel;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CleanArch.Infrastructure.Data.Repository
{
    public class RecipesRepository : IRecipeRepository
    {
        private DynamoDBContext _context;

        public RecipesRepository(DynamoDBContext context)
        {
            _context = context;
        }

        IEnumerable<Recipe> IRecipeRepository.GetRecipes()
        {
            return new List<Recipe>(); // _context.Recipes;
        }
    }
}
