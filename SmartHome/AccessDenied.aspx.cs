using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHome
{
    public partial class AccessDenied : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AddHeader("REFRESH", "5;URL=Default.aspx"); //Redirect them to Default.aspx in 5 seconds
        }
    }
}