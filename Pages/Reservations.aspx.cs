using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheRightPlace.Models;

namespace TheRightPlace.Pages
{
    public partial class Reservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            //Get a list of all products in db
            RoomModel roomModel = new RoomModel();
            List<Room> rooms = roomModel.GetAllRooms();

            //Make Sure products exist in the db
            if (rooms != null)
            {
                //Create a new panel with an imageButton and 2 labels for each product
                foreach (Room room in rooms)
                {
                    Panel roomPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblName = new Label();
                    Label lblPrice = new Label();

                    //Set child control properties
                    imageButton.ImageUrl = "~/Images/RoomImages/" + room.Image;
                    imageButton.CssClass = "roomImage";
                    imageButton.PostBackUrl = "~/Pages/Rooms.aspx?id=" + room.Id;

                    lblName.Text = room.Name;
                    lblName.CssClass = "roomName";

                    lblPrice.Text = "$ " + room.Price;
                    lblPrice.CssClass = "roomPrice";

                    //add child controls to panel
                    roomPanel.Controls.Add(imageButton);
                    roomPanel.Controls.Add(new Literal{Text = "<br />"});
                    roomPanel.Controls.Add(lblName);
                    roomPanel.Controls.Add(new Literal{Text = "<br />"});
                    roomPanel.Controls.Add(lblPrice);

                    //Add dynamic panels to static parent panel
                    pnlRooms.Controls.Add(roomPanel);


                }
            }
            else
            {
                //no rooms
                pnlRooms.Controls.Add(new Literal { Text = "No rooms found!" });
            }

        }
    }
}