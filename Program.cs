using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie[] movielist = new Movie[10];
            movielist[0] = new Movie("Step Brothers", "comedy",1);
            movielist[1] = new Movie("Due Date", "comedy",1);
            movielist[2] = new Movie("Annabelle", "horrer",2);
            movielist[3] = new Movie("The Hangover", "comedy",1);
            movielist[4] = new Movie("Jurassic Park", "scifi",3);
            movielist[5] = new Movie("Anger Management", "comedy",1);
            movielist[6] = new Movie("Dispicable Me", "animated",4);
            movielist[7] = new Movie("Kidnap", "Thriller",5);
            movielist[8] = new Movie("Meet The Parents", "comedy",1);
            movielist[9] = new Movie("Star Wars", "scifi",3);
            // movielist.OrderBy(d => d.Cnumber);
            //llStatInfo.OrderByDescending(d => d.Date);
            //Array.Sort.

            do
            {
                var m = new List <string> ();
                Console.WriteLine("1.comedy\n2.horror\n3.scifi\n4.animated\n5.thriller\n");
                Console.WriteLine("enter the  number of the gategory you want to watch");

                int input = Validatenumber();
                for (int i = 0; i < movielist.Length; i++)
                {
                    if (movielist[i].Cnumber == input)
                        m.Add(movielist[i].Moviename);


                }
                m.Sort();
                for (int j = 0; j < m.Count; j++)
                {
                    Console.WriteLine(m[j]);
                }

            }
            while (Continuquestion());

            Console.WriteLine("Bye ");










        }
        public static bool Continuquestion()
        {
            string answer = ""; bool flag = true;
            Console.Write("continue?(y/n):    ");
            answer = Console.ReadLine();
            if (answer == "n" || answer == "N")
            {

                flag = false;
                return flag;


            }
            else if (answer == "y" || answer == "Y")



                return flag;

            else
            {
                Console.Write("try again invalid input   ");
                return Continuquestion();

            }

        }

        public static int Validatenumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || !(number >= 1 && number <= 5))
            {
                Console.WriteLine("enter a valid number between 1-5");
            }
            return number;
        }

        



    }

   

}
