using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_Tuntiharjoituksia_To6_10_TestMySQL : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetCities_Click(object sender, EventArgs e)
    {
        try
        {
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["OmaSQL"].ConnectionString;
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetCitysFromMySQL(cs);
            gvCities.DataSource = dt;
            gvCities.DataBind();
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}