using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using TheRightPlace.Models;

namespace TheRightPlace.Pages.Management
{
    public partial class ManageRooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetImages();

                //Check if the url contains an id parameter
                if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    FillPage(id);
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            RoomModel roomModel = new RoomModel();
            Room room = CreateRoom();

            //check if the url contains an id parameter
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //ID exists -> update existing row
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lblResult.Text = roomModel.UpdateRoom(id, room);
            }
            else
            {
                //ID does not exist -> create a new row
                lblResult.Text = roomModel.InsertRoom(room);
            }
        }

        private void FillPage(int id)
        {
            //Get selected room from db
            RoomModel roomModel = new RoomModel();
            Room room = roomModel.GetRoom(id);

            //Fill Textboxes
            txtDescription.Text = room.Description;
            txtName.Text = room.Name;
            txtPrice.Text = room.Price.ToString();

            //Set ddl values
            ddlImage.SelectedValue = room.Image;
            ddlType.SelectedValue = room.RoomTypeId.ToString();


        }
        private void GetImages()
        {
            try
            {
                //Get all filepaths
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/RoomImages/"));

                //Get all filenames and add them to an arraylist
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                //Set the arrayList as the dropdownview's datasource and refresh
                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();

            }
            catch (Exception e)
            {
                lblResult.Text = e.ToString();
            }

        }

        private Room CreateRoom()
        { 
            Room room = new Room();

            room.Name = txtName.Text;
            room.Price = Convert.ToInt32(txtPrice.Text);
            room.RoomTypeId = Convert.ToInt32(ddlType.SelectedValue);
            room.Description = txtDescription.Text;
            room.Image = ddlImage.SelectedValue;

            return room;
        }
        
    }

}
