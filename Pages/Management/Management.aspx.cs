using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheRightPlace.Pages.Management
{
    public partial class Management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdRooms_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Get Selected Row
            GridViewRow row = grdRooms.Rows[e.NewEditIndex];

            //Get Id of selected room
            int rowId = Convert.ToInt32(row.Cells[1].Text);

            //Redirect user to ManageRooms along with the selected rowId
            Response.Redirect("~/Pages/Management/ManageRooms.aspx?id=" + rowId);

        }      
    }
}