using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>
        {
            new() {
                Title = "Hiking Adventure",
                Date = DateTime.UtcNow.AddMonths(1),
                Description = "Join us for a scenic hike through the national park. Bring water and comfortable shoes.",
                Category = "Outdoor",
                isCancelled = false,
                City = "Denver",
                Venue = "Rocky Mountain National Park",
                Latitude = 40.3428,
                Longitude = -105.6836
            },
            new() {
                Title = "Tech Conference 2025",
                Date = DateTime.UtcNow.AddMonths(2),
                Description = "Annual gathering for developers, engineers, and tech enthusiasts.",
                Category = "Technology",
                isCancelled = false,
                City = "San Francisco",
                Venue = "Moscone Center",
                Latitude = 37.7833,
                Longitude = -122.4006
            },
            new() {
                Title = "Jazz Night",
                Date = DateTime.UtcNow.AddDays(10),
                Description = "Enjoy live jazz music with local and international artists.",
                Category = "Music",
                isCancelled = false,
                City = "New Orleans",
                Venue = "Preservation Hall",
                Latitude = 29.9584,
                Longitude = -90.0643
            },
            new() {
                Title = "Art Exhibition: Modern Expressions",
                Date = DateTime.UtcNow.AddDays(45),
                Description = "Showcasing modern art from emerging and established artists.",
                Category = "Art",
                isCancelled = false,
                City = "New York",
                Venue = "Metropolitan Museum of Art",
                Latitude = 40.7794,
                Longitude = -73.9632
            },
            new() {
                Title = "Food Festival 2025",
                Date = DateTime.UtcNow.AddMonths(3),
                Description = "Taste delicacies from around the world with live cooking demonstrations.",
                Category = "Food",
                isCancelled = false,
                City = "Chicago",
                Venue = "Grant Park",
                Latitude = 41.8763,
                Longitude = -87.6190
            },
            new() {
                Title = "City Marathon",
                Date = DateTime.UtcNow.AddMonths(4),
                Description = "Run through the city’s landmarks with thousands of participants.",
                Category = "Sports",
                isCancelled = false,
                City = "Boston",
                Venue = "Boston Common",
                Latitude = 42.3550,
                Longitude = -71.0656
            },
            new() {
                Title = "Book Fair",
                Date = DateTime.UtcNow.AddMonths(5),
                Description = "Meet authors, explore rare books, and attend literary talks.",
                Category = "Literature",
                isCancelled = false,
                City = "London",
                Venue = "Olympia London",
                Latitude = 51.4952,
                Longitude = -0.2103
            },
            new() {
                Title = "Film Premiere: The Last Horizon",
                Date = DateTime.UtcNow.AddDays(25),
                Description = "Exclusive first screening of the sci-fi epic, with cast appearances.",
                Category = "Film",
                isCancelled = false,
                City = "Los Angeles",
                Venue = "TCL Chinese Theatre",
                Latitude = 34.1020,
                Longitude = -118.3400
            },
            new() {
                Title = "Wine Tasting Evening",
                Date = DateTime.UtcNow.AddMonths(1).AddDays(5),
                Description = "Sample fine wines from around the world in an elegant setting.",
                Category = "Food & Drink",
                isCancelled = false,
                City = "Paris",
                Venue = "Le Grand Palais",
                Latitude = 48.8662,
                Longitude = 2.3125
            },
            new() {
                Title = "Yoga Retreat",
                Date = DateTime.UtcNow.AddMonths(6),
                Description = "A week of relaxation, mindfulness, and wellness activities.",
                Category = "Wellness",
                isCancelled = false,
                City = "Bali",
                Venue = "Ubud Wellness Center",
                Latitude = -8.5069,
                Longitude = 115.2625
            },
            new() {
                Title = "Startup Pitch Night",
                Date = DateTime.UtcNow.AddDays(20),
                Description = "Local entrepreneurs present their startups to potential investors.",
                Category = "Business",
                isCancelled = false,
                City = "Berlin",
                Venue = "Factory Berlin",
                Latitude = 52.5300,
                Longitude = 13.4000
            },
            new() {
                Title = "Photography Workshop",
                Date = DateTime.UtcNow.AddMonths(2).AddDays(15),
                Description = "Learn photography basics and advanced techniques from professionals.",
                Category = "Education",
                isCancelled = false,
                City = "Tokyo",
                Venue = "Shinjuku Gyoen National Garden",
                Latitude = 35.6852,
                Longitude = 139.7100
            }
        };


        context.Activities.AddRange(activities);
        await context.SaveChangesAsync();
    }
}
