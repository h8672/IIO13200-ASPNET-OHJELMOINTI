using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
   Tee ASP.NET-sovellus lottorivien arvontaa varten.
    Käyttäjä voi valita montako riviä arvotaan.
    Lotto-vaihtoehtoja Suomessa on kaksi: Suomi ja VikingLotto.
    Suomi-lotossa arvotaan seitsemän (7) numero 39:sta, Viking Lotossa arvotaan kuusi (6) numeroa 48:sta.
    Toteuta käyttöliittymä ASP.NET-teknologialla.

*/

public class Lotto
{
    List<int> arvot;
    int nostot;
    int maxarvo;

    public string Tyyppi
    {
        get
        {
            if (nostot == 7) return "Suomi";
            else if (nostot == 6) return "Viking";
            else return "Väärä lottotyyppi: nostoja " + nostot + " ja max luku " + maxarvo;
        }
    }

    public int PieninNumero
    {
        get { return arvot.Min(); }
    }
    public int SuurinNumero
    {
        get { return arvot.Max(); }
    }
    public int Nostot
    {
        get { return nostot; }
    }
    public Lotto()
    {
        //Automaattisesti Suomi lotto
        nostot = 7;
        maxarvo = 39;
    }
    
    public void SuomiLotto()
    {
        Arvot(6, 48);
    }
    public void VikingLotto()
    {
        Arvot(7, 39);
    }

    public List<int> ArvoRivi()
    {
        arvot = new List<int>();
        for(int i = 0; i < nostot; i++)
        {
            arvot.Add(new Random().Next(1, maxarvo));
        }
        return arvot;
    }

    private void Arvot(int nostot, int maxarvo)
    {
        this.nostot = nostot;
        this.maxarvo = maxarvo;
    }
}