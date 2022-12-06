using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cours_09_Exercice03
{
    public partial class BulletList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!Page.IsPostBack)
            {
                foreach(string style in Enum.GetNames(typeof(BulletStyle)))
                {
                    BulletList_1.Items.Add(style);
                }
            }
        }

        protected void BulletList_1_Click(object sender, BulletedListEventArgs e)
        {
            string nomStyle = BulletList_1.Items[e.Index].Text;
            BulletStyle style = (BulletStyle) Enum.Parse(typeof(BulletStyle), nomStyle);

            BulletList_1.BulletStyle = style;
        }
    }
}