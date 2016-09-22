using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_Harj2_Default : System.Web.UI.Page
{
    public string SecretMessage
    {
        get { return txtMessage.Text; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlMessages.Items.Add("Hello.");
            ddlMessages.Items.Add("Ping?");
            ddlMessages.Items.Add("Handshake?");
            ddlMessages.Items.Add("Goodbye!");
        }
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //we will use standard redirection with Redirect
        //Response.Redirect("Target.aspx");
        //Näkyy otsikko rivillä...
        Response.Redirect("Target.aspx?User=Esa&Message=" + txtMessage.Text);
    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        //kiurjoitetaan Sessioniin ja siirrytään toiselle sivulle
        Session["Message"] = txtMessage.Text;
        Response.Redirect("Target.aspx");
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        //luodaan keksi ja kirjoitetaan siihen viesti
        HttpCookie cookie = new HttpCookie("Message", txtMessage.Text);
        cookie.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(cookie);
        Response.Redirect("Target.aspx");
    }

    protected void btnPublicProperty_Click(object sender, EventArgs e)
    {
        Server.Transfer("Target.aspx");
    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMessage.Text = ddlMessages.Text.ToString();
    }
    
}