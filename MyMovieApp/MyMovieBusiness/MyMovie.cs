using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMovieData;

namespace MyMovieBusiness
{
    public class MyMovie
    {
        MyMovieData.MovieDataOperation MovieDataOperationObj = new MovieDataOperation();
        public string InsertMovie(movie moviedata)
        {
            string msg = MovieDataOperationObj.InsertMovie(moviedata);
            return msg;
        }
        public string UpdateMovie(movie moviedata)
        {
            string msg = MovieDataOperationObj.UpdateMovie(moviedata);
            return msg;
        }
        public movie EditMovieByid(int MovieId)
        {
            movie movie = MovieDataOperationObj.EditMovieByid(MovieId);
            return movie;

        }
        public string DeleteMovie(movie moviedata)
        {
            string msg = MovieDataOperationObj.DeleteMovie(moviedata);
            return msg;
        }
        public DataTable SelectMovies()
        {
            DataTable dtSelectMovies = MovieDataOperationObj.SelectMovies();
            return dtSelectMovies;
        }
        
    }
}

/*
 * UI -> Business layer -> Data Layer
 * UI <- Business layer <- Data Layer
 */