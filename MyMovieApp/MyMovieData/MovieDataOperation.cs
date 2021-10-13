using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieData
{
    public class MovieDataOperation
    {
        MyMovieEntities MyMovieEntities = new MyMovieEntities();
        public string InsertMovie(movie moviedata)
        {
            MyMovieEntities.movies.Add(moviedata);
            MyMovieEntities.SaveChanges();
            return "Movie data inserted";
        }
        public string UpdateMovie(movie moviedata)
        {
            MyMovieEntities.Entry(moviedata).State = EntityState.Modified;
            MyMovieEntities.SaveChanges();
            return "Updated";

        }
        public movie EditMovieByid(int MovieId)
        {
            movie movie = new movie();
            var result = MyMovieEntities.movies.ToList().Find(obj => obj.Id == MovieId);
            movie.Id = result.Id;
            movie.Name = result.Name;
            movie.MovieType = result.MovieType;
            movie.MovieDesc = result.MovieDesc;
            return movie;

        }
        public string DeleteMovie(movie moviedata)
        {
            MyMovieEntities.Entry(moviedata).State = EntityState.Deleted;
            MyMovieEntities.SaveChanges();
            return "Deleted movie";

        }
        public DataTable SelectMovies()
        {
            var result = MyMovieEntities.movies.ToList();
            DataTable dtSelectMovies = new DataTable();
            dtSelectMovies = ToDataTable<movie>(result);

            //IEnumerable<DataRow> query = from data in result.AsEnumerable()
            //                             select data;
            return dtSelectMovies;
        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
