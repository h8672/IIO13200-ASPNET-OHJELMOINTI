using System;
using System.Configuration; //Webconfigia varten
using System.Data;          //ADO.NETin luokkia varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Haetyontekijatilta : System.Web.UI.Page
{
    string xmlfilu;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Luetaan web.configista xml-tiedoston nimi
        xmlfilu = ConfigurationManager.AppSettings["tiedosto"];
        lblMessage.Text = xmlfilu;
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        //Luetaan xml-tiedostosta tt:n tiedot ja esitetään new gvData:ssa
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        //DataView ei pakollinen, mutta hieno kuulemma
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlfilu));
        dt = ds.Tables[0];
        dv = dt.DefaultView;

        //Syötetään data näkyville
        //gvData.DataSource = dt;
        gvData.DataSource = dv;
        gvData.DataBind();
        lblMessage.Text = string.Format("Työntekijöitä {0}.", dt.Rows.Count);
    }
}