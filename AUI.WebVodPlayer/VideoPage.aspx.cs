using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseAccess;

namespace AUI.WebVodPlayer
{
    public partial class VideoPage : System.Web.UI.Page
    {
        public static string movieUrl;
        public Movie SelectedMovie;
        protected void Page_Load(object sender, EventArgs e)
        {
            movieUrl = String.Empty;
            SelectedMovie = Global.database.Movies.FirstOrDefault(m => m.Id == HomePage.selectedMovie.Id);
            if (SelectedMovie != null)
            {
                movieUrl = SelectedMovie.Url;
            }
        }
    }
}