﻿using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface IRecipeService
    {
        RecipeViewModel GetRecipes();
    }
}
