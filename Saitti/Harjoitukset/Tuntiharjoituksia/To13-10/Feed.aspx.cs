using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Harjoitukset_Tuntiharjoituksia_To13_10_Feed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetFeeds_Click(object sender, EventArgs e)
    {
        //Asetetaan xmldatasourcen datalähteeksi IS:n rssfeedi
        string url = "http://www.iltasanomat.fi/rss/tuoreimmat.xml";
        myDataSource.DataFile = url;
        GetFeeds();
    }
    

    private void GetFeeds()
    {
        try
        {
            //Käytetään XmlDocument luokkaa ja sen metodeja, ominaisuuksia
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            XmlNode node1 = doc.SelectSingleNode("/rss/channel");
            string title = node1["title"].InnerText;
            myDiv.InnerHtml = string.Format("<h1>{0} {1}</h1>", title, DateTime.Now.ToShortTimeString());
            //haetaan kaikki item-elementit ja loopitetaan läpi
            XmlNodeList nodes = doc.SelectNodes("/rss/channel/item");
            string cat;
            string link;
            string img = "";
            foreach (XmlNode item in nodes)
            {
                //haetaan kuvan url, jos sellainen on.
                if (item["enclosure"] != null) img = item["enclosure"].GetAttribute("url");
                else img = "http://student.labranet.jamk.fi/~salesa/pic/nope.png";
                myDiv.InnerHtml += string.Format("<img src='{0}' alt='' style='height:50px' />", img);
                //title, link, category luetaan elementeistä
                cat = item["category"].InnerText;
                title = item["title"].InnerText;
                link = item["link"].InnerText;
                myDiv.InnerHtml += string.Format("{0} <a href='{1}'>{2}</a><br>", cat, link, title);
            }
        }
        catch (Exception ex)
        {
            myDiv.InnerText = ex.Message;
        }
    }

    protected void btnGetFeedsYle_Click(object sender, EventArgs e)
    {
        //Asetetaan xmldatasourcen datalähteeksi IS:n rssfeedi
        string url = "http://feeds.yle.fi/uutiset/v1/recent.rss?publisherIds=YLE_UUTISET&concepts=18-819";
        myDataSource.DataFile = url;
        GetFeeds();
    }
}