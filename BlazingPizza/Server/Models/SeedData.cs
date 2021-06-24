using BlazingPizza.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server.Models
{
    public static class SeedData
    {
        public static void Initialize(PizzaStoreContext context)
        {
            var specials = new PizzaSpecial[]
            {
                new PizzaSpecial
                {
                    Name = "Pizza Clasica de queso",
                    Descripcion = "Es de queso",
                    BasePrice = 189.99m,
                    ImageUrl = "Images/pizzas/cheese.jpg"
                },
                new PizzaSpecial()
                {
                    Name = "Tocinator",
                    Descripcion = "Tiene todo tipo de tocino",
                    BasePrice = 277.99m,
                    ImageUrl = "Images/pizzas/bacon.jpg"
                },
                new PizzaSpecial()
                {
                    Name = "Clasica de pepperoni",
                    Descripcion = "Es la pizza con la que creciste, ¡pero ardientemente deliciosa!",
                    BasePrice = 199.50m,
                    ImageUrl = "Images/pizzas/pepperoni.jpg"
                },
                new PizzaSpecial()
                {
                    Name = "Pollo bufalo",
                    Descripcion = "Pollo picante, salsa picante, garantizdo que entraras",
                    BasePrice = 278.75m,
                    ImageUrl = "Images/pizzas/meaty.jpg"
                },
                new PizzaSpecial()
                {
                    Name = "Amantes del champiñon",
                    Descripcion = "Tinene champiñones. ¿No es obvio?",
                    BasePrice = 289.00m,
                    ImageUrl = "Images/pizzas/mushroom.jpg"
                },
                new PizzaSpecial()
                {
                    Name = "Hawaiana",
                    Descripcion = "De piña, jamon y queso...",
                    BasePrice = 190.25m,
                    ImageUrl = "Images/pizzas/hawaiian.jpg"
                },
                new PizzaSpecial()
                {
                    Name = "Delicia vegetariana",
                    Descripcion = "Es como una ensalada, pero en una pizza",
                    BasePrice = 218.50m,
                    ImageUrl = "Images/pizzas/salad.jpg"
                },
                new PizzaSpecial()
                {
                    Name = "Margarita",
                    Descripcion = "Pizza Italiana tradicional con tomates y albahaca",
                    BasePrice = 189.99m,
                    ImageUrl = "Images/pizzas/margherita.jpg"
                },
            };

            context.Specials.AddRange(specials);
            context.SaveChanges();
        }
    }
}
