﻿using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class RecipeViewModel
    {
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}
