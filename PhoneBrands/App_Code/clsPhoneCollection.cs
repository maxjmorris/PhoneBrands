using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsPhoneCollection
/// </summary>
//public ThisPhone Property


public class clsPhoneCollection
{
    clsDataConnection dBConnection = new clsDataConnection(); //create a connection
    //member var for current phones
    clsPhone mThisPhone = new clsPhone();
    public clsPhoneCollection()
    {
       
    }


    //public ThisPhone Property
    public clsPhone ThisPhone
    {
        get
        {
            return mThisPhone;
        }
        set
        {
            mThisPhone = value;
        }
    }
    //this function defines the FilterByBrand method
    public void FilterByBrand(string Brand)
    //it accepts a single parameter Brand returns no value 
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the parameter used by the stored procedure 
        dBConnection.AddParameter("@Brand", Brand);
        //execute the stored procedure to delete the phone
        dBConnection.Execute("sproc_tblPhoneBrands_FilterByBrand");
    }

    public Boolean Delete()
    {
        //this public function provides functionality for the delete method 

        try //try to delete the record
        {
            //create an instance of the data connection class called MyDatabase
            clsDataConnection MyDatabase = new clsDataConnection();
            //add the PhoneNo parameter passed to this function to the list of parameters to use in the database 
            MyDatabase.AddParameter("@PhoneNo", mThisPhone.PhoneNo);
            //execute the stored procedure in the database
            MyDatabase.Execute("sproc_tblPhoneBrands_Delete");
            // set the return value for the function 
            return true;
        }
        catch //do this only if the code above failed for some reason
        {
            //report back that there was an error
            return false;
        }
    }

    public List<clsPhone> PhoneList
    {
        get
        {
            List<clsPhone> mPhoneList = new List<clsPhone>(); //create an array list of clsPhone
            Int32 Index = 0;//var to store the count of records
           while(Index <dBConnection.Count)
            {

                //create a blank brand
                clsPhone BlankPage = new clsPhone();
                //copy the data from the table to the RAM
                BlankPage.PhoneNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["PhoneNo"]);
                BlankPage.PhoneName = Convert.ToString(dBConnection.DataTable.Rows[Index]["PhoneName"]);
                BlankPage.Brand = Convert.ToString(dBConnection.DataTable.Rows[Index]["Brand"]);
                BlankPage.ScreenSize = Convert.ToString(dBConnection.DataTable.Rows[Index]["ScreenSize"]);
                BlankPage.OperatingSystem = Convert.ToString(dBConnection.DataTable.Rows[Index]["OperatingSystem"]);
                BlankPage.BackCamera = Convert.ToString(dBConnection.DataTable.Rows[Index]["BackCamera"]);
                BlankPage.BatterySize = Convert.ToString(dBConnection.DataTable.Rows[Index]["BatterySize"]);
                BlankPage.ReleaseDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["ReleaseDate"]);
                BlankPage.CompanyNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["CompanyNo"]);
                BlankPage.Discontinued = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["Discontinued"]);
                mPhoneList.Add(BlankPage);//add the blank page to the array list
                Index++;//increase the index
            }
            //return the list as the return value of the function
            return mPhoneList;
        }
    }
        public Int32 Count
    //public read only property for the count of records found
    {
        get
        {
            //return the count of records
            return dBConnection.Count;
        }
    }
        public Int32 Add()
    ///thos function will add a new phone to the database
    ///it accepts a single parameter an object of type clsPhone
    ///once the record is added the function returns the primary key value of the new record
    ///                      ///
    //INSERT INTO tblPhoneBrands
    //(PhoneName,Brand,ScreenSize,OperatingSystem,BackCamera,BatterySize,ReleaseDate,CompanyNo,Discontinued )
    //SELECT
    //@PhoneName, @Brand, @ScreenSize, @OperatingSystem, @BackCamera, @BatterySize, @ReleaseDate, @CompanyNo, @Discontinued;

    {
        //conect to the database
        clsDataConnection NewDBPhone = new clsDataConnection();
        NewDBPhone.AddParameter("@PhoneName", mThisPhone.PhoneName);
        NewDBPhone.AddParameter("@Brand", mThisPhone.Brand);
        NewDBPhone.AddParameter("@ScreenSize", mThisPhone.ScreenSize);
        NewDBPhone.AddParameter("@OperatingSystem", mThisPhone.OperatingSystem);
        NewDBPhone.AddParameter("@BackCamera", mThisPhone.BackCamera);
        NewDBPhone.AddParameter("@BatterySize", mThisPhone.BatterySize);
        NewDBPhone.AddParameter("@ReleaseDate", mThisPhone.ReleaseDate);
        NewDBPhone.AddParameter("@CompanyNo", mThisPhone.CompanyNo);
        NewDBPhone.AddParameter("@Discontinued", mThisPhone.Discontinued);
        //execute the store procedure returning the primary key value of the new record
        return NewDBPhone.Execute("sproc_tblPhoneBrands_Insert");

    }
    public void Update()
    { 
        ///this function will update an existing phone in the database
        ///it accepts a single parameter an object of type clsPhonePage
        ///the PhoneNo property must have a valid value for this to work
        ///SET     PhoneName=@PhoneName,
        //         Brand = @Brand,
        //         ScreenSize = @ScreenSize,
        //         OperatingSystem = @OperatingSystem,
        //         BackCamera = @BackCamera,
        //         BatterySize = @BatterySize,
        //         ReleaseDate = @ReleaseDate,
        //         CompanyNo = @CompanyNo,
        //         Discontinued = @Discontinued
        //-- where the PhoneNo matches the value of @PhoneNo passed as the parameter
        //WHERE PhoneNo = @PhoneNo
        // connect to the database
        clsDataConnection ExistingDBPhone = new clsDataConnection();
        //add the parameters
        ExistingDBPhone.AddParameter("@PhoneNo", mThisPhone.PhoneNo);
        ExistingDBPhone.AddParameter("@PhoneName", mThisPhone.PhoneName);
        ExistingDBPhone.AddParameter("@Brand", mThisPhone.Brand);
        ExistingDBPhone.AddParameter("@ScreenSize", mThisPhone.ScreenSize);
        ExistingDBPhone.AddParameter("@OperatingSystem", mThisPhone.OperatingSystem);
        ExistingDBPhone.AddParameter("@BackCamera", mThisPhone.BackCamera);
        ExistingDBPhone.AddParameter("@BatterySize", mThisPhone.BatterySize);
        ExistingDBPhone.AddParameter("@ReleaseDate", mThisPhone.ReleaseDate);
        ExistingDBPhone.AddParameter("@CompanyNo", mThisPhone.CompanyNo);
        ExistingDBPhone.AddParameter("@Discontinued", mThisPhone.Discontinued);
        //execute the query
        ExistingDBPhone.Execute("sproc_tblPhoneBrands_Update");

    }
   

    } 









