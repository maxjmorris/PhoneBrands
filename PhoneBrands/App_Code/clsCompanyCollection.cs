using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCompanyCollection
/// </summary>
public class clsCompanyCollection
{
    //create a new connection to the database with class level scope
    clsDataConnection Companies = new clsDataConnection();
    public clsCompanyCollection()
    {
        //execute the select all query
        Companies.Execute("sproc_tblCompany_SelectAll");
    }
    //this read only function gives us the count property 
    public Int32 Count
    {
        get
        {
            //return the count of data from the database
            return Companies.Count;
        }
    }
    public List<clsCompany> AllCompanies
    {

        get
        {
            //create an instance of a list called allCompanies
            List<clsCompany> mAllCompanies = new List<clsCompany>();
            //var to store the index for the loop
            Int32 Index = 0;
            //while the index is less that the number of records process
            while (Index < Companies.Count)
            {
                //set up the new entry to be added to the list
                clsCompany NewCompany = new clsCompany();
                //get the company number from the database
                NewCompany.CompanyNo = Convert.ToInt32(Companies.DataTable.Rows[Index]["CompanyNo"]);
                //get the company name from the database
                NewCompany.Company = Convert.ToString(Companies.DataTable.Rows[Index]["Company"]);
                //add the new entry to the list
                mAllCompanies.Add(NewCompany);
                //increment the index
                Index++;
            }
            //return the query results from the database
            return mAllCompanies;
        }
    }
}