using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static CSCI3321_ASPNET_FinalProject.SQLquery;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddAuthors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAuthorSubmit_Click(object sender, EventArgs e)
        {
            string commandText = "INSERT INTO Authors VALUES ('" + txtLastName.Text + "', '" + txtFirstName.Text
                + "', '" + txtGender.Text + "', '" + txtBirthDate.Text + "')";
            SQLquery.RunQuery(commandText);
        }
    }
}