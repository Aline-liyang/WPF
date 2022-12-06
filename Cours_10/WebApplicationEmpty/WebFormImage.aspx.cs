using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEmpty
{
    public partial class WebFormImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Convert_ServerClick(object sender, ImageClickEventArgs e)
        {
            Result.InnerHtml = "Vous cliquez au point (" + e.X.ToString() + "," + e.Y.ToString() + ")";

            if( (e.X > 20 && e.X < 280) && (e.Y > 20 && e.Y < 120) )
            {
                Result.InnerText += " Vous cliquez à l'intérieur de l'image";
            }
            else
            {
                Result.InnerText += " Vous cliquez à l'extérieur de l'image";
            }

        }

    
    }
}