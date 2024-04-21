using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Movie_EFC.Entities;
using Movie_EFC.Context;

using (MovieContext context = new())
{

    Movie movie = new Movie();
    Subtitle subtitle = new Subtitle();
    Director director = new Director();




start:
    Console.WriteLine("You can do this type of operations:");
    Console.WriteLine("1.Add ");
    Console.WriteLine("2.Update");
    Console.WriteLine("3.Delete ");
    Console.Write("Enter Operation:");
    int operation = Convert.ToInt32(Console.ReadLine());


    switch (operation)
    {
        case 1:

            Console.WriteLine("Please Enter MovieName:");
            movie.MovieName = Console.ReadLine();
            movie.MovieReleaseDate = DateTime.Now;
            Console.WriteLine("Please Enter Description:");
            movie.Description = Console.ReadLine();
            Console.WriteLine("Please Enter DirectorId:");
            movie.DirectorId = Convert.ToInt32(Console.ReadLine());
            await context.Movies.AddAsync(movie);
            Console.WriteLine("Added!");
            await context.SaveChangesAsync();

            Console.WriteLine("Do you want to continue? ");
            string answerOne = Console.ReadLine().ToLower();
            if (answerOne == "yes")
            {
                goto start;
            }
            else
            {
                break;

            }

        case 2:

            Console.WriteLine("Please Enter Movie Id which you want to update:");
            int updateMovieId = Convert.ToInt32(Console.ReadLine());
            var updatedMovie = context.Movies.FirstOrDefault(x => x.Id == updateMovieId);
            Console.WriteLine("Please Enter MovieName which you want to update:");
            updatedMovie.MovieName = Console.ReadLine();
            Console.WriteLine("Please Enter Description which you want to update:");
            updatedMovie.Description = Console.ReadLine();
            context.Update(updatedMovie);
            Console.WriteLine("Updated!");
            await context.SaveChangesAsync();

            Console.WriteLine("Do you want to continue? ");
            string answerTwo = Console.ReadLine().ToLower();
            if (answerTwo == "yes")
            {
                goto start;
            }
            else
            {
                break;
            }

        case 3:
            Console.WriteLine("Please Enter Movie id which you want to delete");
            int deletedMovieId = Convert.ToInt32(Console.ReadLine()); ;
            var deletedMovie = context.Movies.FirstOrDefault(x => x.Id == deletedMovieId);
            context.Movies.Remove(deletedMovie);
            Console.WriteLine("Deleted!");
            await context.SaveChangesAsync();

            Console.WriteLine("Do you want to continue? ");
            string answerThree = Console.ReadLine().ToLower();
            if (answerThree == "yes")
            {
                goto start;
            }
            else
            {
                break;
            }

        default:
            Console.WriteLine("This kind of Status does not exist");
            break;
    }

}

