using System;
using System.Collections.Generic;

namespace animehub
{
    // FEATURE: Class
    public class Anime
    {
        // FEATURE: Fields
        private string name;
        private int releaseYear;
        private string[] genres;
        private string synopsis;

        // FEATURE: Static field (Dictionary)
        private static Dictionary<string, Anime> allAnimes = new Dictionary<string, Anime>();

        // FEATURE: Constructor
        public Anime(string name, int releaseYear, string[] genres, string synopsis)
        {
            this.name = name;
            this.releaseYear = releaseYear;
            this.genres = genres;
            this.synopsis = synopsis;
        }

        // FEATURE: Method
        public string GetName()
        {
            return this.name;
        }

        // FEATURE: Method
        public int GetReleaseYear()
        {
            return this.releaseYear;
        }

        // FEATURE: Method
        public string[] GetGenres()
        {
            return this.genres;
        }

        // FEATURE: Method
        public string GetSynopsis()
        {
            return this.synopsis;
        }

        // FEATURE: Static method
        public static Dictionary<string, Anime> GetAllAnimes()
        {
            return allAnimes;
        }

        // FEATURE: Static method
        public static void AddAnime(Anime anime)
        {
            if (!allAnimes.ContainsKey(anime.GetName()))
            {
                allAnimes.Add(anime.GetName(), anime);
            }
        }

        // FEATURE: Static method
        public static void RemoveAnime(string name)
        {
            if (allAnimes.ContainsKey(name))
            {
                allAnimes.Remove(name);
            }
        }

        // FEATURE: Static constructor
        static Anime()
        {
            // FEATURE: Static method call and object creation
            AddAnime(new Anime("Naruto", 2002, new string[] { "Action", "Adventure" }, "A young ninja who seeks recognition from his peers and dreams of becoming the Hokage."));
            AddAnime(new Anime("One Piece", 1999, new string[] { "Action", "Adventure" }, "A group of pirates led by Monkey D. Luffy in search of the One Piece treasure."));
            AddAnime(new Anime("Attack on Titan", 2013, new string[] { "Action", "Drama" }, "Humanity fights for survival against giant humanoid Titans."));
            AddAnime(new Anime("Death Note", 2006, new string[] { "Mystery", "Psychological" }, "A high school student discovers a notebook that allows him to kill anyone whose name he writes in it."));
            AddAnime(new Anime("My Hero Academia", 2016, new string[] { "Action", "Adventure" }, "A world where nearly everyone has superpowers called 'Quirks'."));
        }
    }
}
