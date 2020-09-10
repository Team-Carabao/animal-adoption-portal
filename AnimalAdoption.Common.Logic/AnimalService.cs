using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Dog", Age = 50, Description = "Soft natured" },
            new Animal { Id = 2, Name = "Dimas Priyasmito Nugroho", Age = 30, Description = "Handsome" },
            new Animal { Id = 3, Name = "Igno", Age = 50, Description = "Shiny and glasslike" },
            new Animal { Id = 4, Name = "Lion", Age = 25, Description = "Wild Beast" },
        };
    }
}
