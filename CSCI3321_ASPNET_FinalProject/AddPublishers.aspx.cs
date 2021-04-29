using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static CSCI3321_ASPNET_FinalProject.SQLquery;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddPublishers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string commandText = "INSERT INTO Publishers VALUES ('" + txtPublisherName.Text + "', '" + txtAddress.Text 
                + "', '" + txtCity.Text + "', '" + txtPostalCode.Text + "', '" + txtCountry.Text + "', '" 
                + txtPhone.Text + "')";
            SQLquery.RunQuery(commandText);
        }
    }
}