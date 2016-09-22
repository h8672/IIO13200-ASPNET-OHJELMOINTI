using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_Harj2_Target : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string msg = "";
        //Vaihtoehto 1 - Query String
        msg += "<h3>QueryString</h3>";
        msg += "Urlissa välitetty viesti: " + Request.QueryString["Message"] + "<br />";

        //RequestQueryString on kokoelma, joka voidaan loopittaa
        foreach (string key in Request.QueryString)
        {
            msg += "Urlista löytyy avain: " + key + " ja sen arvo on " + Request.QueryString[key] + "<br />";
        }

        //Vaihtoehto 2 - Session
        msg += "<h3>Session</h3>";
        msg += "Sessionista haettu viesti: " + Session["Message"] + "<br />";

        //Vaihtoehto 3 - Cookie
        msg += "<h3>Cookie</h3>";

        foreach (string kex in Request.Cookies)
        {
            if(kex == "Message") msg += "Cookiesta haettu viesti: " + Request.Cookies[kex].Value;
        }

        //Vaihtoehto 4 - Secret message: luetaan edellisen sivun Property
        msg += "<h3>Propertyn lukeminen</h3>";
        var previouspage = PreviousPage;
        if(previouspage != null)
        {
            //Katsoo edelliselta sivulta tuota muuttujaa... valittaa virhettä, mutta pitäisi toimia
            msg += "Ed.sivun Property on " + previouspage.SecretMessage;
        }

        //Tulostus
        mytext.InnerHtml = msg;
    }
}