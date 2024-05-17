using System;
using System.Collections.Generic;
using System.Linq;

namespace animehub
{
    class Program
    {
        // FEATURE: Data type (bool)
        private static bool appIsActive = true;
        // FEATURE: Array data type
        private static string[] pages = { "home", "browse", "add", "remove" };
        // FEATURE: String data type
        private static string currentPage = "home";
        // FEATURE: Array data type
        private static int[] actions;

        // FEATURE: Function
        private static void welcome()
        {
            Console.WriteLine(@"
                 _                  _    _       _     
     /\         (_)                | |  | |     | |    
    /  \   _ __  _ _ __ ___   ___  | |__| |_   _| |__  
   / /\ \ | '_ \| | '_ ` _ \ / _ \ |  __  | | | | '_ \ 
  / ____ \| | | | | | | | | |  __/ | |  | | |_| | |_) |
 /_/    \_\_| |_|_|_| |_| |_|\___| |_|  |_|\__,_|_.__/ 
                                                       
                                                       ");
            Console.WriteLine("Welcome to Anime Hub!");
        }

        // FEATURE: Function
        private static void setValidActions()
        {
            // FEATURE: if-else control flow statement
            if (currentPage == "home")
            {
                // FEATURE: Array data type
                actions = new int[] { 1, 2, 3, 0 };
            }
            else if (currentPage == "browse" || currentPage == "add" || currentPage == "remove")
            {
                actions = new int[] { 0 };
            }
        }

        // FEATURE: Function
        private static void listActions()
        {
            if (currentPage == "home")
            {
                // FEATURE: String concatenation
                Console.WriteLine("1. Browse animes");
                Console.WriteLine("2. Add a new anime");
                Console.WriteLine("3. Remove an anime");
                Console.WriteLine("0. Exit");
            }
            else if (currentPage == "browse")
            {
                Console.WriteLine("\nBrowsing all animes...\n");
                // FEATURE: Dictionary data type
                Dictionary<string, Anime> animes = Anime.GetAllAnimes();
                // FEATURE: foreach loop
                foreach (KeyValuePair<string, Anime> entry in animes)
                {
                    Anime anime = entry.Value;
                    // FEATURE: String concatenation
                    Console.WriteLine("----- " + anime.GetName() + " -----");
                    Console.WriteLine("Release Year: " + anime.GetReleaseYear());
                    Console.WriteLine("Genres: " + string.Join(", ", anime.GetGenres()));
                    Console.WriteLine("Synopsis: " + anime.GetSynopsis() + "\n");
                }
                Console.WriteLine("0. Go back to home");
            }
            else if (currentPage == "add")
            {
                Console.WriteLine("0. Go back to home");
            }
            else if (currentPage == "remove")
            {
                Console.WriteLine("0. Go back to home");
            }
        }

        // FEATURE: Function
        private static int promptUser()
        {
            Console.Write("\nWhat would you like to do?: ");
            int action;
            // FEATURE: Type casting (string to int)
            bool success = int.TryParse(Console.ReadLine(), out action);

            if (success)
            {
                // FEATURE: if-else control flow statement
                if (actions.Contains(action))
                {
                    return action;
                }
                else
                {
                    Console.WriteLine("\nOh, no! That's an invalid input!\n");
                    return 99;
                }
            }
            else
            {
                Console.WriteLine("\nOh, no! That's an invalid input!\n");
                return 99;
            }
        }

        // FEATURE: Function
        static void end()
        {
            appIsActive = false;
            Console.WriteLine("\nThanks for browsing Anime Hub!\nSee you next time!");
        }

        // FEATURE: Function
        static void handleAction(int action)
        {
            if (currentPage == "home")
            {
                // FEATURE: switch statement
                switch (action)
                {
                    case 1:
                        currentPage = "browse";
                        break;
                    case 2:
                        currentPage = "add";
                        addAnime();
                        break;
                    case 3:
                        currentPage = "remove";
                        removeAnime();
                        break;
                }
            }
            else if (currentPage == "browse")
            {
                currentPage = "home"; // Return to home after browsing
            }
            else if (currentPage == "add")
            {
                currentPage = "home"; // Return to home after adding
            }
            else if (currentPage == "remove")
            {
                currentPage = "home"; // Return to home after removing
            }
        }

        // FEATURE: Function
        static void addAnime()
        {
            Console.WriteLine("Enter the name of the anime:");
            // FEATURE: Null-coalescing operator
            string name = Console.ReadLine() ?? "Unknown";
            Console.WriteLine("Enter the release year of the anime:");
            // FEATURE: Type casting (string to int)
            int releaseYear = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the genres of the anime (comma-separated):");
            // FEATURE: Null-conditional operator
            string[] genres = Console.ReadLine()?.Split(',') ?? new string[] { "Unknown" };
            Console.WriteLine("Enter the synopsis of the anime:");
            // FEATURE: Null-coalescing operator
            string synopsis = Console.ReadLine() ?? "No synopsis available";

            // FEATURE: Object creation
            Anime anime = new Anime(name, releaseYear, genres, synopsis);
            Anime.AddAnime(anime);
            Console.WriteLine("Anime added successfully!");
        }

        // FEATURE: Function
        static void removeAnime()
        {
            Console.WriteLine("Enter the name of the anime to remove:");
            // FEATURE: Null-coalescing operator
            string name = Console.ReadLine() ?? "";

            // FEATURE: if-else control flow statement
            if (name != "") Anime.RemoveAnime(name);
            else Console.WriteLine("Invalid anime name provided.");
            Console.WriteLine("Anime removed successfully!");
        }

        // FEATURE: Main method
        static void Main(string[] args)
        {
            welcome();

            // FEATURE: while loop
            while (appIsActive)
            {
                listActions();
                setValidActions();
                int action = promptUser();

                if (action == 99)
                {
                    continue;
                }
                else if (currentPage == "home" && action == 0)
                {
                    end();
                    break;
                }
                else
                {
                    handleAction(action);
                }
            }
        }
    }
}
