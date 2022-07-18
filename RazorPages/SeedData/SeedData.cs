using System;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Order == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Order.Any())
                {
                    return;   // DB has been seeded
                }

                context.Order.AddRange(
                    new Order
                    {
                        StartCity = "Москва",
                        FinishCity = "Санкт-Петербург",
                        StartAdress = "Новолитовская 35",
                        FinishAdress = "Литейная 31",
                        Weight = 450,
                        Date = DateTime.Parse("2022-4-11")
                    },


                    new Order
                    {
                        StartCity = "Лондон",
                        FinishCity = "Париж",
                        StartAdress = "Карла Маркса 3",
                        FinishAdress = "Наполеоновская 9",
                        Weight = 800,
                        Date = DateTime.Parse("2022-5-12")
                    }

                 
                    
                );
                context.SaveChanges();
            }
        }
    }
}

