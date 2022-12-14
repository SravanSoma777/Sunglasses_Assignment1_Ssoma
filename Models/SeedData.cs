using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sunglasses_Assignment1_Ssoma.Data;


namespace Sunglasses_Assignment1_Ssoma.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSunglassesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcSunglassesContext>>()))
            {
                // Look for any movies.
                if (context.Sunglasses.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sunglasses.AddRange(
                    new Sunglasses
                    {
                        name = "Rectangle Glasses",
                        ReleaseDate = DateTime.Parse("2010-2-12"),
                        ShadeType = "Coolblue",
                        Price = 18.99M,
                        review="good",
                        reviewScale=3,
                        country="United States"
                    },

                    new Sunglasses
                    {
                        name = "Square Glasses",
                        ReleaseDate = DateTime.Parse("2011-8-19"),
                        ShadeType = "Red",
                        Price = 16.99M,
                        review = "excellent",
                        reviewScale = 5,
                        country = "India"
                    },

                    new Sunglasses
                    {
                        name = "Rectangle Glasses",
                        ReleaseDate = DateTime.Parse("2011-2-17"),
                        ShadeType = "Green",
                        Price = 6.99M,
                        review = "poor",
                        reviewScale = 1,
                        country = "Canada"
                    },

                    new Sunglasses
                    {
                        name = "Circle Glasses",
                        ReleaseDate = DateTime.Parse("2015-01-16"),
                        ShadeType = "transparent",
                        Price = 12.99M,
                        review = "very good",
                        reviewScale = 4,
                        country = "United Kingdom"
                    },

                    new Sunglasses
                    {
                        name = "Cat-Eye Sunglasses",
                        ReleaseDate = DateTime.Parse("2017-06-20"),
                        ShadeType = "Transparent",
                        Price = 11.99M,
                        review = "good",
                        reviewScale = 3,
                        country = "Australia"
                    },

                    new Sunglasses
                    {
                        name = "Aviator Glasses",
                        ReleaseDate = DateTime.Parse("2017-05-15"),
                        ShadeType = "Grey",
                        Price = 9.99M,
                        review = "excellent",
                        reviewScale = 5,
                        country = "India"
                    },

                    new Sunglasses
                    {
                        name = "Aviator Glasses",
                        ReleaseDate = DateTime.Parse("2018-04-10"),
                        ShadeType = "Black",
                        Price = 10.99M,
                        review = "Very good",
                        reviewScale = 4,
                        country = "Dubai"
                    },

                    new Sunglasses
                    {
                        name = "Keyhole Bridge Glasses",
                        ReleaseDate = DateTime.Parse("2011-05-14"),
                        ShadeType = "white",
                        Price = 8.99M,
                        review = "good",
                        reviewScale = 3,
                        country = "Israel"
                    },

                    new Sunglasses
                    {
                        name = "Circle Glasses",
                        ReleaseDate = DateTime.Parse("2012-03-19"),
                        ShadeType = "Orange",
                        Price = 7.99M,
                        review = "good",
                        reviewScale = 3,
                        country = "Ukraine"
                    },

                    new Sunglasses
                    {
                        name = "Over-sized Glasses",
                        ReleaseDate = DateTime.Parse("2019-09-12"),
                        ShadeType = "Light Red",
                        Price = 6.99M,
                        review = "good",
                        reviewScale = 3,
                        country = "India"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
