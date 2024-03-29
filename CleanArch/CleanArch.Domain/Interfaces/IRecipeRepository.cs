﻿using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Interfaces
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetRecipes();
    }
}
