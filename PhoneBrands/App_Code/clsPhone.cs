using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsPhone
/// </summary>


public class clsPhone
{
   
    //PhoneNo private member variable
    private Int32 mPhoneNo;
    //PhoneNo public property
    public Int32 PhoneNo
    {
        get
        {
            //this line of code sends data of the property
            return mPhoneNo;

        }
        set
        {
            //this line of code allows data into the property
            mPhoneNo = value;

        }
    }
    //PhoneName private member variable
    private string mPhoneName;
    //PhoneName public property
    public string PhoneName
    {
        get
        {
            return mPhoneName;
        }
        set
        {
            mPhoneName = value;
        }
    }

    //Brand private member variable
    private string mBrand;
    //Brand public property
    public string Brand
    {
        get
        {
            return mBrand;
        }
        set
        {
            mBrand = value;

        }
    }

    //ScreenSize private member variable
    private string mScreenSize;
    //ScreenSize public property
    public string ScreenSize
    {
        get
        {
            return mScreenSize;
        }
        set
        {
            mScreenSize = value;
        }
    }


    //OperatingSystem private member variable
    private string mOperatingSystem;
    //OperatingSystem public property
    public string OperatingSystem
    {
        get
        {
            return mOperatingSystem;
        }
        set
        {
            mOperatingSystem = value;
        }
    }

    //BackCamera private member variable
    private string mBackCamera;
    //BackCamera public property
    public string BackCamera
    {
        get
        {
            return mBackCamera;
        }
        set
        {
            mBackCamera = value;
        }
    }

    //ReleaseDate private member variable
    private DateTime mReleaseDate;
    //ReleaseDate public property
    public DateTime ReleaseDate
    {
        get
        {
            return mReleaseDate;
        }
        set
        {
            mReleaseDate = value;
        }
    }

    //active private member variable
    private Boolean mDiscontinued;
    //Active public property
    public Boolean Discontinued
    {
        get
        {
            return mDiscontinued;
        }
        set
        {
            mDiscontinued = value;
        }
    }

    //CompanyNo private member variable
    private Int32 mCompanyNo;
    //AddressNo public property
    public Int32 CompanyNo
    {
        get
        {
            //this line of code sends data out of the property
            return mCompanyNo;
        }
        set
        {
            //this line of code allows data into the property
            mCompanyNo = value;
        }
    }
    //BatterySize private member variable
    private string mBatterySize;
    //AddressNo public property
    public string BatterySize
    {
        get
        {
            //this line of code sends data out of the property
            return mBatterySize;
        }
        set
        {
            //this line of code allows data into the property
            mBatterySize = value;
        }
    }
    public string PhoneValid
    (
        string PhoneName,
        string Brand,
        string ScreenSize,
        string OperatingSystem,
        string BackCamera,
        string BatterySize,
        string ReleaseDate)
    ///this function is used to validate the data in a new address
    ///it accepts four parameters and returns a string containing the text of the errors 
    ///otherwise of no errors it returns a blank string
    {
        string ErrorMsg; //var to store any error message
        ErrorMsg = ""; //initialise the var with a blank string
        //check the min length of the Phone Name
        if (PhoneName.Length == 0)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The Phone name is blank";
        }
        //check the max length of the Phone Name
        if (PhoneName.Length > 20)
        {
            //record an error 
            ErrorMsg = ErrorMsg + "The Phone name must be less than 20 characters";
        }
        //check the min length of the brand 
        if (Brand.Length == 0)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The brand is blank";
        }
        //check the max length of the brand
        if (Brand.Length > 30)
        {
            ErrorMsg = ErrorMsg + "The Brand must be less than 30 characters";
        }
        //check the min length of the screen size
        if (ScreenSize.Length == 0)
        {
            //set the error message 
            ErrorMsg = ErrorMsg + "The Screen Size is blank";
        }
        //check the max length of the screen size
        if (ScreenSize.Length > 10)
        {
            ErrorMsg = ErrorMsg + "The Screen Size must be less than 10 characters";
        }

        //check the min length of the operating system
        if (OperatingSystem.Length == 0)
        {
            ErrorMsg = ErrorMsg + "The Operating System is blank";
        }
        //check the max length of the operating system
        if (OperatingSystem.Length > 30)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The Operating System must be less than 30 characters";
        }
        //check the min length of the operating system
        if (BackCamera.Length == 0)
        {
            ErrorMsg = ErrorMsg + "The Back Camera is blank";
        }
        //check the max length of the operating system
        if (BackCamera.Length > 10)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The Back Camera must be less than 10 characters";
        }
        //check the min length of the operating system
        if (BatterySize.Length == 0)
        {
            ErrorMsg = ErrorMsg + "The Battery Size is blank";
        }
        //check the max length of the operating system
        if (BatterySize.Length > 10)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The Battery Size must be less than 10 characters";
        }
        //test if the date is valid 
        try // try the operation
        {
            //var to store the date
            DateTime Temp;
            //assign the date to the temporary var
            Temp = Convert.ToDateTime(ReleaseDate);
        }
        catch //if it failed report an error

        {
            //set the error message
            ErrorMsg = ErrorMsg + "The Release Date is not valid";
        }
        //if there were no errors
        if (ErrorMsg == "")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "There were the following errors:" + ErrorMsg + ErrorMsg;

        }
    }
         //function for the find public method
    public Boolean Find(Int32 PhoneNo)
    {
        //initialised the db connection
        clsDataConnection dBConnection = new clsDataConnection();
        //add the phone No parameter
        dBConnection.AddParameter("@PhoneNo", PhoneNo);
        //execute the query
        dBConnection.Execute("sproc_tblPhone_FilterByPhoneNo");
        //if the record was found
        if (dBConnection.Count == 1)
        {
            //get the phone no
            mPhoneNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["PhoneNo"]);
            //get the phone name
            mPhoneName = Convert.ToString(dBConnection.DataTable.Rows[0]["PhoneName"]);
            //get the brand
            mBrand = Convert.ToString(dBConnection.DataTable.Rows[0]["Brand"]);
            //get the screen size
            mScreenSize = Convert.ToString(dBConnection.DataTable.Rows[0]["ScreenSize"]);
            //get the Operating System
            mOperatingSystem = Convert.ToString(dBConnection.DataTable.Rows[0]["OperatingSystem"]);
            //get the back camera
            mBackCamera = Convert.ToString(dBConnection.DataTable.Rows[0]["BackCamera"]);
            //get the battery size
            mBatterySize = Convert.ToString(dBConnection.DataTable.Rows[0]["BatterySize"]);
            //get the release date
            mReleaseDate = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["ReleaseDate"]);
            //get the company no
            mCompanyNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["CompanyNo"]);
            try
            {
                //get the Discontinued
                mDiscontinued = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Discontinued"]);
            }
            catch
            {
                mDiscontinued = true;
            }
            //return success
            return true;
        }
        else
        {
            //return failure
            return false;
        }

        }
    }



  










        