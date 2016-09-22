using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtävät_Teht1_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        tbPinta.InnerHtml = "Ikkunan Pinta-ala: " + (1.00 * 0) + " m2";
        tbPiiri.InnerHtml = "Karmin Piiri: " + (1.00 * 0) + " m2";
        tbTarjous.InnerHtml = "Tarjoushinta(Ilman ALV): " + (1.00 * 0) + " €";
        
    }


    protected void btnLaske_Click(object sender, EventArgs e)
    {
        double leveys = textToDouble(inLeveys.Value);
        double korkeus = textToDouble(inKorkeus.Value);
        double karmi = textToDouble(inKarmi.Value);
        double pinta = leveys * korkeus;
        double piiri = (leveys + korkeus) * 2;
        tbPinta.InnerHtml = String.Format("Ikkunan Pinta-ala: {0} m2", pinta);
        tbPiiri.InnerHtml = String.Format("Karmin Piiri: {0} m2", piiri);   //neliöhinta    alumiini      kate     menekki
        double nelio = 45; // € / m2
        double alumiini = 100; // € / m2
        double kate = 30; // %
        double menekki = 150; // € / ikkuna
        double ilmanALV = (1.0 + kate / 100) * ((pinta * nelio) + (piiri * alumiini) + menekki);
        tbTarjous.InnerHtml = String.Format("Tarjoushinta(Ilman ALV): {0} €", ilmanALV);
        //int pinta_ala = inLeveys.Value * inKorkeus.Value;
    }
    
    //Replaces dot to dottee nad converts string to double! Also converts to mm!
    private double textToDouble(string intext)
    {
        return Convert.ToDouble(intext.Replace(".", ","))/1000;
    }
}