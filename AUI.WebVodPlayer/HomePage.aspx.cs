using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseAccess;
using Microsoft.Win32;

namespace AUI.WebVodPlayer
{
    public partial class HomePage : System.Web.UI.Page
    {
        public static Movie selectedMovie;
        public static string kkk = "KKK";
        protected void Page_Load(object sender, EventArgs e)
        {
            selectedMovie = new Movie();
            MoviesList.DataSource = Global.database.Movies.ToList();
            MoviesList.DataBind();
        }

        protected void MoviesList_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
            MoviesList.SelectedIndex = e.NewSelectedIndex;
            MoviesList.DataBind();

        }

        protected void MoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = ((List<Movie>)MoviesList.DataSource)[MoviesList.SelectedIndex];
            selectedMovie = Global.database.Movies.FirstOrDefault(m => m.Id == t.Id);
            Response.Redirect("~/VideoPage.aspx");
        }
    }
}