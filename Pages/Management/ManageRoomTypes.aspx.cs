using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheRightPlace.Models;

namespace TheRightPlace.Pages.Management
{
    public partial class ManageRoomTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            RoomTypeModel model = new RoomTypeModel();
            RoomType rt = createRoomType();

            lblResult.Text = model.InsertRoomType(rt);
        }

        private RoomType createRoomType()
        {
            RoomType r = new RoomType();
            r.Name = txtName.Text;

            return r;
        }
    }
}