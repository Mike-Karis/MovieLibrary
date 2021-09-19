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
        int x=0;
        string newID="";
        string newTitle="";
        string final="";
        while(x ==0){
            int idTaken=0;
            int titleTaken=0;
            Console.WriteLine("Enter Movie ID: ");
             newID = Console.ReadLine();
            for(int a =0;a<movieID.Count;a++){
                if(newID.Equals(movieID[a])){
                    Console.WriteLine("That ID is already taken.");
                    idTaken=1;
                    titleTaken=1;
                    break;
                }
                else{}
            }
            if(idTaken==0){
                    Console.WriteLine("Enter Movie Title: ");
                     newTitle = Console.ReadLine();
                    for(int b=0;b<title.Count;b++){
                         if(newTitle.Equals(title[b])){
                            Console.WriteLine("That Title is already taken.");
                            titleTaken=1;
                            break;
                        }
                        else{}
                        }
            }
            if(titleTaken==0){
                x=1;
                final = newID+","+newTitle+",";
            }  
            
            }
            Console.WriteLine("Enter Genres each divided by a | ");
            final = final+Console.ReadLine();
            Console.WriteLine(final);
             using (StreamWriter sw = File.AppendText("movies.csv")){
                            //sw.WriteLine();
                            sw.WriteLine(final);
                        }

        }
    }
}
