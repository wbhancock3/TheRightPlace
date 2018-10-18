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
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get id of current logged in user and display items in cart
            string userId = User.Identity.GetUserId();
            GetPurchasesInCart(userId);
        }

        private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList selectedList = (DropDownList)sender;
            int quantity = Convert.ToInt32(selectedList.SelectedValue);
            int cartId = Convert.ToInt32(selectedList.ID);

            CartModel model = new CartModel();
            model.UpdateQuantity(cartId, quantity);

            Response.Redirect("~/Pages/ShoppingCart.aspx");

        }

        private void Delete_Item(object sender, EventArgs e)
        {
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("del", "");
            int cartId = Convert.ToInt32(link);

            CartModel model = new CartModel();
            model.DeleteCart(cartId);

            Response.Redirect("~/Pages/ShoppingCart.aspx");
        }

        private void GetPurchasesInCart(string userId)
        {
            CartModel model = new CartModel();
            double subTotal = 0;

            List<Cart> purchaseList = model.GetOrdersInCart(userId);
            CreateShopTable(purchaseList, out subTotal);

            //Add totals to webpage
            double discount = (subTotal * 0.15);

            double grandTotal = subTotal - discount;

            //display values

            litsubTotal.Text = "$ " + subTotal;
            litDiscount.Text = "$ " + discount;
            litGrandTotal.Text = "$ " + grandTotal;
        }

        private void CreateShopTable(List<Cart> purchaseList, out double subTotal)
        {
            subTotal = new Double();
            RoomModel model = new Models.RoomModel();
            foreach (Cart cart in purchaseList)
            {
                Room room = model.GetRoom(cart.RoomID);

                //crea the image button
                ImageButton btnImage = new ImageButton
                {
                    ImageUrl = string.Format("~/Images/RoomImages/{0}", room.Image),
                    PostBackUrl = string.Format("~/Pages/Rooms.aspx?id={0}", room.Id),
                    CssClass = "roomImage"
                };

                //create the delete link
                LinkButton lnkDelete = new LinkButton
                {
                    PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?roomId={0}", cart.ID),
                    Text = "Delete Item",
                    ID = "del" + cart.ID
                };

                //add an OnClick Event
                lnkDelete.Click += Delete_Item;

                //create the 'quantity ddl
                // generate list with numbers for each room available
                int[] amount = Enumerable.Range(1, 2).ToArray();
                DropDownList ddlAmount = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = cart.ID.ToString()

                };

                ddlAmount.DataBind();
                ddlAmount.SelectedValue = cart.Amount.ToString();
                ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

                //create HTML table wirh 2 rows
                Table table = new Table { CssClass = "cartTable" };
                TableRow a = new TableRow();
                TableRow b = new TableRow();

                //create 6 cells for row a
                TableCell a1 = new TableCell { RowSpan = 2, Width = 50 };
                TableCell a2 = new TableCell { Text = string.Format("<h4>{0}</h4><br/>{1}<br/>In Stock",
                    room.Name, "Item No: " + room.Id),
                    HorizontalAlign = HorizontalAlign.Left, Width =350};
                TableCell a3 = new TableCell { Text = "Unit Price<hr />" };
                TableCell a4 = new TableCell { Text = "Quantity<hr />" };
                TableCell a5 = new TableCell { Text = "Items Total<hr />" };
                TableCell a6 = new TableCell { };

                //create 6 cells for row a
                TableCell b1 = new TableCell { };
                TableCell b2 = new TableCell { Text = "$ " + room.Price };
                TableCell b3 = new TableCell { };
                TableCell b4 = new TableCell { Text = "$ " +Math.Round((cart.Amount * (double)room.Price), 2) };
                TableCell b5 = new TableCell { };
                TableCell b6 = new TableCell { };

                //set special controls
                a1.Controls.Add(btnImage);
                a6.Controls.Add(lnkDelete);
                b3.Controls.Add(ddlAmount);

                //Add cells to rows
                a.Cells.Add(a1);
                a.Cells.Add(a2);
                a.Cells.Add(a3);
                a.Cells.Add(a4);
                a.Cells.Add(a5);
                a.Cells.Add(a6);

                b.Cells.Add(b1);
                b.Cells.Add(b2);
                b.Cells.Add(b3);
                b.Cells.Add(b4);
                b.Cells.Add(b5);
                b.Cells.Add(b6);

                //Add rows to table
                table.Rows.Add(a);
                table.Rows.Add(b);

                //Add table to pnlShoppingCart
                pnlShoppingCart.Controls.Add(table);

                //add total amount of item in cart to subtotal
                subTotal += (cart.Amount * (double)room.Price);
        
            }

            //add current user's shopping cart to user specific  session
            Session[User.Identity.GetUserId()] = purchaseList;
        }

    }
}