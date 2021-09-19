using System;
using NLog.Web;
using System.IO;
using System.Collections;

namespace Movie_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines;
            var movieID = new ArrayList();
            var title = new ArrayList();
            var genres = new ArrayList();
            // List<string> movieID = new List<string>();
            // List<string> title = new List<string>();
            // List<string> genres = new List<string>();



            using (StreamReader sr = new StreamReader(File.OpenRead("movies.csv")))
        {

            while (sr.EndOfStream == false)
            {
            string line = sr.ReadLine();
            lines = line.Split(',');
            movieID.Add(lines[0]);
            title.Add(lines[1]);
            genres.Add(lines[2]);

             
            }
        }

        Console.WriteLine(title[4]);
        }
    }
}
