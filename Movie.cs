using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Movie
    {
        private string moviename; 
        private string moviecategory;
        private int cnumber;
        #region properties
        public string Moviename
        {
            set { moviename = value; }   // used to change the value of the field

            get { return moviename; }    // used to return the value of the field
        }
            public int Cnumber
        {
            set { cnumber = value; }

            get { return cnumber; }


        }

        
        public string Moviecategory
        {
            set { moviecategory = value; }   // used to change the value of the field

            get { return moviecategory; }    // used to return the value of the field



        }
        #endregion


        #region methods

        public Movie(string name,string  categorie,int number )
        {
            Moviename = name;
            Moviecategory = categorie;
        Cnumber = number;

        }

        public Movie ():this("not provided", "not porvided",0)
        {

        }

        #endregion

    }
}
