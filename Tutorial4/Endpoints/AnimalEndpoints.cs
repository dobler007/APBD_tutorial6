using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals-minimalapi/{id}", (int id) =>
        {
            // process data
            if (id != 1)
            {
                return Results.NotFound();
            }
    
            return Results.Ok();
        });

        // 200 - Ok
        // 201 - Created
        // 404 - Not Found

        app.MapPost("/animals-minimalapi", (Animal animal) =>
        {
            Console.WriteLine(animal.Id);
            Console.WriteLine(animal.FirstName);
            if (false)
            {
                return Results.BadRequest();
            }
            return Results.Created();
        });
    }
}