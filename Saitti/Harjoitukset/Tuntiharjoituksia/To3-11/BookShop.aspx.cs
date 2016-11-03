using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_Tuntiharjoituksia_To3_11_BookShop : System.Web.UI.Page
{
    protected static BookShopEntities ctx;
    protected void Page_Load(object sender, EventArgs e)
    {
        //ctx:n tiedot vain kerran
        if (!IsPostBack)
        {
            ctx = new BookShopEntities();
            FillControls();
        }
    }
    #region METHODS
    protected void ShowCustomersOrders(Customer customer)
    {
        //Näytetään asiakkaan tilaukset ja tilaukseen kuuluvat rivit eli kirjat
        string result = string.Format("Asiakkaalla {0} {1} on {2} tilausta",
            customer.firstname, customer.lastname, customer.Orders.Count);
        foreach (var o in customer.Orders)
        {
            result += string.Format("tilaus {0} sisältää {1} kirjaa", o.orderdate, o.Orderitems.Count);
            foreach(var oi in o.Orderitems)
            {
                result += string.Format("<br>-- kirjaa {0} {1} kpl {2}", oi.Book.name, oi.Book.author, oi.count);
            }
        }
        ltResult.Text = result;
    }
    protected void FillControls()
    {
        //Dropdownlist
        //var retval = (from c in ctx.Customers
        //             orderby c.lastname
        //             select c).ToList();
        //ddlSelect.DataSource = retval;
        //Ilman ToList() functiota
        //var retval = ctx.Customers;
        //var retval = from c in ctx.Customers
        //             orderby c.lastname
        //             select c;
        //var retval = ctx.Customers.ToList();
        var retval = ctx.Customers.OrderBy(x => x.lastname);
        ddlSelect.DataSource = retval.ToList();
        ddlSelect.DataTextField = "lastname";
        ddlSelect.DataValueField = "id";
        ddlSelect.DataBind();
    }
    protected void ShowCustomers()
    {
        gvCustomers.DataSource = ctx.Customers.ToList();
        gvCustomers.DataBind();
        int i = ctx.Customers.Count();
        lblMessages.Text = String.Format("Haettu {0} asiakkaan tiedot", i);
    }
    protected void ShowBooks()
    {
        gvBooks.DataSource = ctx.Books.ToList();
        gvBooks.DataBind();
        int i = ctx.Customers.Count();
        lblMessages.Text = String.Format("Haettu {0} kirjan tiedot", i);
    }
    #endregion

    protected void btnGetCustomers_Click(object sender, EventArgs e)
    {
        ShowCustomers();
    }

    protected void btnGetBooks_Click(object sender, EventArgs e)
    {
        ShowBooks();
    }

    protected void ddlSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Valitun asiakkaan indeksin perusteella
        int i = int.Parse(ddlSelect.SelectedValue);
        var ret = from c in ctx.Customers
                  where c.id == i
                  select c;
        Customer customer = ret.FirstOrDefault();
        ShowCustomersOrders(customer);
    }
}