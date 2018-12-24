using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    //var to store the PhoneNo
    Int32 PhoneNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the variable
        PhoneNo = Convert.ToInt32(Request.QueryString["PhoneNo"]);
        //if the PhoneNo is not -1 then display the data from the record
        if (PhoneNo != -1)
        {
            if (IsPostBack != true)
            {
                //display the data for this Phone
                DisplayBrand(PhoneNo);
            }
        }
    }
       
    


    protected void btnYes_Click(object sender, EventArgs e)
    {
       //this function handles the click even of the yes button

        //create an instance of the class clsPhoneCollection called This phone
        clsPhoneCollection MyPhoneBook = new clsPhoneCollection();
        //declare a boolean variable for Found
        Boolean Found;
        //try and find the record to delete
        Found = MyPhoneBook.ThisPhone.Find(PhoneNo);
        //if the record is found
        if (Found)
        {
            //invoke the delete method 
            MyPhoneBook.Delete();
        }
        Response.Redirect("Default.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //send back to default page
        Response.Redirect("Default.aspx");
    }
    void DisplayBrand(Int32 PhoneNo)
    {
     
    }
}