using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Phones : System.Web.UI.Page
{
    //var to store the PhoneNo
    Int32 PhoneNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query int to the text box PhoneNo
        PhoneNo = Convert.ToInt32(Request.QueryString["PhoneNo"]);
        
        //if this is not an instruction to add a new record
        if (PhoneNo != -1)
        {
            if (IsPostBack != true)
            {
                //update the contents of the drop down list
                DisplayCompanies();
                //display the existing data
                DisplayBrand(PhoneNo);
            }
            
                    //this a new record
            {
                //display companies for drop down list
                DisplayCompanies();
            }
        }
    }

    //this function displays the data for a phone on the web form
    void DisplayBrand (Int32 PhoneNo)
    {
        //create an instance of the phone class
        clsPhone MyPhoneBook = new clsPhone();
        //find the record we want to display
        MyPhoneBook.Find(PhoneNo);
        //display the phone name
        txtPhoneName.Text = MyPhoneBook.PhoneName;
        //display the brand
        txtBrand.Text = MyPhoneBook.Brand;
        //display the screen size
        txtScreenSize.Text = MyPhoneBook.ScreenSize;
        //display the operating system
        txtOperatingSystem.Text = MyPhoneBook.OperatingSystem;
        //display the back camera
        txtBackCamera.Text = MyPhoneBook.BackCamera;
        //display the battery size
        txtBatterySize.Text = MyPhoneBook.BatterySize;
        //display the release data
        txtReleaseDate.Text = MyPhoneBook.ReleaseDate.ToString("dd/MM/yyyy");
        //set the drop down list to display the Company No
        ddlCompany.SelectedValue = Convert.ToString(MyPhoneBook.CompanyNo);
        //display the active state
        chkDiscontinued.Checked = MyPhoneBook.Discontinued;
    }
    Int32 DisplayCompanies()
    {
        //create an instance of the company class
        clsCompanyCollection Companies = new clsCompanyCollection();
        //var to store the company no primary
        string CompanyNo;
        //var to store the company name
        String Company;
        //var to store the index for the loop      
        Int32 Index = 0;
        //while the infex is less that the number of records to process
        while (Index<Companies.Count)
        {
            //get the company number from the database
            CompanyNo = Convert.ToString(Companies.AllCompanies[Index].CompanyNo);
            //get the company name from the databse
            Company = Convert.ToString(Companies.AllCompanies[Index].Company);
            //set up the new row to be added to the list 
            ListItem NewCompany = new ListItem(Company, CompanyNo);
            //add the new row to the list
            ddlCompany.Items.Add(NewCompany);
            //increment the index
            Index++;

        }
        //return the number of records founds
        return Companies.Count;
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the phone page class
        clsPhone ThisPhone = new clsPhone();
        //var to store any error messages
        string ErrorMessage;
        //test the data on the web form
        ErrorMessage = ThisPhone.PhoneValid(
            txtPhoneName.Text,
            txtBrand.Text,
            txtScreenSize.Text,
            txtOperatingSystem.Text,
            txtBackCamera.Text,
            txtBatterySize.Text,
            txtReleaseDate.Text);
        if (ErrorMessage =="")

        {
            //create a new instance of the phone collection class
            clsPhoneCollection PhoneCollection = new clsPhoneCollection();
            //do something with the data - insert or update
            //
            //if the Phone Number is -1
            if (PhoneNo == -1)
            {
                //copy the data from the interface to the object
                ThisPhone.PhoneName = txtPhoneName.Text;
                ThisPhone.Brand = txtBrand.Text;
                ThisPhone.ScreenSize = txtScreenSize.Text;
                ThisPhone.OperatingSystem = txtOperatingSystem.Text;
                ThisPhone.BackCamera = txtBackCamera.Text;
                ThisPhone.BatterySize = txtBatterySize.Text;
                ThisPhone.CompanyNo = Convert.ToInt32(ddlCompany.SelectedValue);
                ThisPhone.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
                //add the new record
                PhoneCollection.Add();
            }
            else
            {
                //this is an existing record
                //copy the data from the interface to the object
                ThisPhone.PhoneNo = Convert.ToInt32(PhoneNo);
                ThisPhone.PhoneName = txtPhoneName.Text;
                ThisPhone.Brand = txtBrand.Text;
                ThisPhone.ScreenSize = txtScreenSize.Text;
                ThisPhone.OperatingSystem = txtOperatingSystem.Text;
                ThisPhone.BackCamera = txtBackCamera.Text;
                ThisPhone.BatterySize = txtBatterySize.Text;
                ThisPhone.CompanyNo = Convert.ToInt32(ddlCompany.SelectedValue);
                ThisPhone.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
                //update the exisiting record
                PhoneCollection.Update();
            }
            //redirect back to the main page
            Response.Redirect("Default.aspx");
}
        else
        {
            //display the error message
            lblError.Text = ErrorMessage;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to main page 
        Response.Redirect("Default.aspx");
    }
   
}