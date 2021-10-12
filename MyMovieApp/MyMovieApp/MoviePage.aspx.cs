using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using MyMovieData;

namespace MyMovieApp
{
    public partial class MoviePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            MyMovieEntities myMovieEntities = new MyMovieEntities();
            movie movieObj = new movie();
            movieObj.Name = txtMoviename.Text;
            movieObj.MovieType = txtMovieType.Text;
            movieObj.MovieDesc = txtMovieDesc.Text;
            myMovieEntities.movies.Add(movieObj);
            myMovieEntities.SaveChanges();
            lblResult.Text = "Movied added successfully!!!";
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //select * from movie where movieid=txtEditMovieID.Text
            MyMovieEntities myMovieEntities = new MyMovieEntities();
            //sql query and execution
            var result = myMovieEntities.movies.ToList().Find(obj => obj.Id == Convert.ToInt32(txtEditMovieID.Text));//select * from movie where id=''
            txtMoviename.Text = result.Name;
            txtMovieType.Text = result.MovieType;
            txtMovieDesc.Text = result.MovieDesc;


            ////sql query
            //var result1 = myMovieEntities.movies.ToList().Where(obj => obj.Id == Convert.ToInt32(txtEditMovieID.Text));//select * from movie where id=''

            ////query execution start from here
            //foreach (var item in result1)
            //{
            //    txtMoviename.Text = item.Name;
            //    txtMovieType.Text = item.MovieType;
            //    txtMovieDesc.Text = item.MovieDesc;
            //}
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MyMovieEntities myMovieEntities = new MyMovieEntities();
            movie movieObj = new movie();
            movieObj.Id =Convert.ToInt32(txtEditMovieID.Text);
            movieObj.Name = txtMoviename.Text;
            movieObj.MovieType = txtMovieType.Text;
            movieObj.MovieDesc = txtMovieDesc.Text;
            myMovieEntities.Entry(movieObj).State = EntityState.Modified;
            myMovieEntities.SaveChanges();
            lblResult.Text = "Movie updated successfully!!!";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MyMovieEntities myMovieEntities = new MyMovieEntities();
            movie movieObj = new movie();
            movieObj.Id = Convert.ToInt32(txtEditMovieID.Text);
            movieObj.Name = txtMoviename.Text;
            movieObj.MovieType = txtMovieType.Text;
            movieObj.MovieDesc = txtMovieDesc.Text;
            myMovieEntities.Entry(movieObj).State = EntityState.Deleted;
            myMovieEntities.SaveChanges();
            lblResult.Text = "Movie deleted successfully!!!";
        }
    }
}