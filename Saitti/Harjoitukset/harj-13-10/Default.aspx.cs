using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Harjoitukset_harj_13_10_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //Käytetään XmlDocument luokkaa ja sen metodeja, ominaisuuksia
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            //haetaan kaikki item-elementit ja loopitetaan läpi
            XmlNodeList nodes = doc.SelectNodes("/tyontekijat/tyontekija");
            myDiv.InnerHtml = "<table><tr>" +
                "<th>Etunimi</th>" +
                "<th>Sukunimi</th>" +
                "<th>Numero</th>" +
                "<th>Työsuhde</th>" +
                "<th>Palkka</th></tr>";
            int summa = 0, lkm = 0;
            foreach (XmlNode item in nodes)
            {
                myDiv.InnerHtml += "<tr>";
                myDiv.InnerHtml += "<td>" + item["etunimi"].InnerText + "</td>";
                myDiv.InnerHtml += "<td>" + item["sukunimi"].InnerText + "</td>";
                myDiv.InnerHtml += "<td>" + item["numero"].InnerText + "</td>";
                myDiv.InnerHtml += "<td>" + item["tyosuhde"].InnerText + "</td>";
                if (item["tyosuhde"].InnerText == "vakituinen")
                {
                    lkm++;
                    summa += Convert.ToInt32(item["palkka"].InnerText);
                }
                myDiv.InnerHtml += "<td>" + item["palkka"].InnerText + "</td>";
                myDiv.InnerHtml += "</tr>";
            }
            myDiv.InnerHtml += "</table><br>" + "Vakituisia: " + lkm + "<br>Vakituisten palkat yhteensä: " + summa;
        }
        catch (Exception)
        {

            throw;
        }
    }
}