using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_Tuntiharjoituksia_To6_10_JSON : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGet_Click(object sender, EventArgs e)
    {
        //Haetaan jsonia ja näytetään UI:ssa
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP");
            ltResult.Text = json;
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }

    protected void btnGetPerson_Click(object sender, EventArgs e)
    {
        //Muutetaan luettu json Person-olioksi
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP");
            JAMK.IT.Person p = Newtonsoft.Json.JsonConvert.DeserializeObject<JAMK.IT.Person>(json);
            ltResult.Text = String.Format("Löytyi henkilö {0} syntynyt {1}", p.Name, p.Birthday);
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }

    protected void btnGetPolticis_Click(object sender, EventArgs e)
    {
        //Muutetaan json Politician-oliokokoelmaksi
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");
            string ret = "<h2>Suomen vankka hallitus</h2><ul>";
            List<JAMK.IT.Politician> hallitus = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JAMK.IT.Politician>>(json);
            foreach (var ministeri in hallitus)
            {
                ret += String.Format("<li>{0} {1} {2}</li>", ministeri.Name, ministeri.Party, ministeri.Position);
            }
            ret += "</ul>";
            ltResult.Text = ret;
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }

    protected string GetJsonFrom(string url)
    {
        using (WebClient wc = new WebClient())
        {
            var json = wc.DownloadString(url);
            return json;
        }
    }
    
}