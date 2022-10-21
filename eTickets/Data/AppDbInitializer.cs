using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        //Seeding
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema One",
                            Logo =
                                "https://img.freepik.com/premium-vector/fast-movie-logo-cinema-logo-design-template_18099-726.jpg",
                            Description = "Description about the first Cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema Two",
                            Logo =
                                "https://img.freepik.com/premium-vector/cinema-logo-design-template_92405-24.jpg?w=2000",
                            Description = "Description about the second Cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema Three",
                            Logo =
                                "https://static.vecteezy.com/system/resources/thumbnails/005/188/413/small/cinema-logo-template-isolated-on-white-background-vector.jpg",
                            Description = "Description about the third Cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema Four",
                            Logo =
                                "https://img.freepik.com/premium-vector/cinema-logo-design-template_92405-24.jpg?w=2000",
                            Description = "Description about the fourth Cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema Five",
                            Logo =
                                "https://static.vecteezy.com/system/resources/thumbnails/005/188/413/small/cinema-logo-template-isolated-on-white-background-vector.jpg",
                            Description = "Description about the fifth Cinema."
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor One",
                            Bio = "This is the Bio of the first actor.",
                            ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor Twp",
                            Bio = "This is the Bio of the second actor.",
                            ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor Three",
                            Bio = "This is the Bio of the third actor.",
                            ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor Four",
                            Bio = "This is the Bio of the fourth actor.",
                            ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor Five",
                            Bio = "This is the Bio of the fifth actor.",
                            ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer One",
                            Bio = "Bio of the first Producer.",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer Two",
                            Bio = "Bio of the second Producer.",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer Three",
                            Bio = "Bio of the third Producer.",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer Four",
                            Bio = "Bio of the fourth Producer.",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer Five",
                            Bio = "Bio of the fifth Producer.",
                            ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Description of Scoob",
                            Price = 39.50,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon

                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Description of Ghost",
                            Price = 39.50,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror

                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Description of Race",
                            Price = 39.50,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary,

                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Description of Cold Soles",
                            Price = 39.50,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama

                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        }

                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
