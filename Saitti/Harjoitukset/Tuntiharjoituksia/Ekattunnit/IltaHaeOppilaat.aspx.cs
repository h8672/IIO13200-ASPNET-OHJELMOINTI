using System;
using System.Data; //Sisälktää ADO.NETin kaikki data-perusluokat ml DataTable
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tuntiharjoituksia_IltaHaeOppilaat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGet3_Click(object sender, EventArgs e)
    {
        //Haetaan valmiilta luokan metodilta dataa ja kiinnitetään se kontrolliin
        DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
        gvStudents.DataSource = dt;
        gvStudents.DataBind();
    }

    protected void btnGetAll_Click(object sender, EventArgs e)
    {
        //Haetaan valmiilta luokan metodilta dataa ja kiinnitetään se kontrolliin
        string message;
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["oppilaat"].ConnectionString;
        try
        {
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetAllStudentsFromSQLServer(cs, "oppilaat", out message);
            gvStudents.DataSource = dt;
            gvStudents.DataBind();
        }
        catch (Exception ex)
        {
            //Mihin poikkeus kirjoitetaan
            message = ex.Message;
        }
        outMessage.InnerHtml = message;
    }

    protected void btnGet4_Click(object sender, EventArgs e)
    {
        //haetaan valmiista BL oppilas-olioita ja kiinnitetään ne kontrollin datasourceksi
        var oppilaat = new JAMK.ICT.BL.Oppilaat().Hae4TestiOppilasta();
        gvStudents.DataSource = oppilaat;
        gvStudents.DataBind();
    }
}