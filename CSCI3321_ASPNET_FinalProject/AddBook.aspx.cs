using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static CSCI3321_ASPNET_FinalProject.SQLquery;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBookSubmit_Click(object sender, EventArgs e)
        {
            string commandText = "INSERT INTO Books VALUES ('" + txtTitle.Text + "', " 
                + ddlAuthor.SelectedValue + ", " + txtPrice.Text + ", '" + txtPublishDate.Text
                + "', " + ddlPublisher.SelectedValue + ", " + ddlGenre.SelectedValue + ", " 
                + txtWordCount.Text + ")";
            SQLquery.RunQuery(commandText);
        }
    }
}