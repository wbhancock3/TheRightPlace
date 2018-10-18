using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheRightPlace.Models;

namespace TheRightPlace.Pages
{
    public partial class Rooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string clientId = Context.User.Identity.GetUserId();

                if (clientId != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    int amount = Convert.ToInt32(ddlAmount.SelectedValue);
                    Cart cart = new Cart
                    {
                        Amount = amount,
                        ClientID = clientId,
                        DatePurchased = DateTime.Now,
                        IsInCart = true,
                        RoomID = id
                    };

                    CartModel model = new CartModel();
                    lblResult.Text = model.InsertCart(cart);
                }
                else
                {
                    lblResult.Text = "Please Login to order items.";
                }
            }
        }

        private void FillPage()
        {
            //get selected room's data
            if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                RoomModel roomModel = new RoomModel();
                Room room = roomModel.GetRoom(id);

                //Fill page with data
                lblPrice.Text = "Price Per Day: <br />$" + room.Price;
                lblTitle.Text = room.Name;
                lblDescription.Text = room.Description;
                lblRoomNbr.Text = id.ToString();
                imgRoom.ImageUrl = "~/Images/RoomImages/" + room.Image;

                //fill amount ddl with numbers
                int[] amount = Enumerable.Range(1, 4).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();
            }
        }
    }
}