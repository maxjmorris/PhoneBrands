using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this first appearance of this form
        if(IsPostBack==false)
            {
            //display all the addresses
            DisplayBrands("");
        }
       

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 PhoneNo;
        //check the list has been clicked first
        if (lstPhones.SelectedIndex != -1)
        {
            //get the primary key value from the list
            PhoneNo = Convert.ToInt32(lstPhones.SelectedValue);
            //redirect to the delete page
            Response.Redirect("Delete.aspx?PhoneNo=" + PhoneNo);
        }
        else
        {
            //display an error message
            lblError.Text = "You must select an item of the list to edit it";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session to indicate this is a new record
        Session["PhoneNo"] = -1;
        //send to  the add page
        Response.Redirect("APhone.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 PhoneNo;
        //check the list has been clicked first
        if (lstPhones.SelectedIndex != -1)
        {
            //get the primary key value from the list
            PhoneNo = Convert.ToInt16(lstPhones.SelectedValue);
            //redirect to the editing page 
            Response.Redirect("APhone.aspx?PhoneNo=" +PhoneNo);
        }
        else
        {
            //display an error message
            lblError.Text = "You must select an item of the list to edit it";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display phones
       lblError.Text = "Records found:" + DisplayBrands("");
    }

    Int32 DisplayBrands(string BrandFilter)
    {
        Int32 PhoneNo;//var to store the primary key
        string PhoneName;//var to store the PhoneName
        string Brand;// var to store the Brand
        ;//create an instance of the phone book class
        clsPhoneCollection PhoneBook = new clsPhoneCollection();
        PhoneBook.FilterByBrand(BrandFilter); //filter by brand
        Int32 RecordCount;//var store the count of records
        Int32 Index = 0;//var to store the index for the loop
        RecordCount = PhoneBook.Count;//get the count of records
        lstPhones.Items.Clear(); //clear the list box
        while (Index < RecordCount)//while there are records to process
        {
            PhoneNo = PhoneBook.PhoneList[Index].PhoneNo;//get the primary key
            PhoneName = PhoneBook.PhoneList[Index].PhoneName;//get the phonename
            Brand = PhoneBook.PhoneList[Index].Brand;//get the brand
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(Brand +" "+ PhoneName, PhoneNo.ToString());
            lstPhones.Items.Add(NewEntry); // add the phone to the list
            Index++; // move the index to the next record

        }
     return RecordCount;
    }

    protected void lstPhones_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //display only brands matching the text in the brand box
        DisplayBrands (txtPhoneBrands.Text);
    }
}
