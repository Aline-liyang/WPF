using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEmpty
{
    public partial class PremierWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Btn Disactivé";
            button.Enabled = true;
        }
    }
}