using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCompany
/// </summary>
public class clsCompany
{
    public clsCompany()
    {
        //
        // TODO: Add constructor logic here
        //
    }
        private Int32 mCompanyNo;
        //public property for company no
        public Int32 CompanyNo
    {
        get
        {
            return mCompanyNo;
        }
        set
        {
            mCompanyNo = value;
        }
    }
    private string mCompany;
        //public property for company 
        public string Company
    {
        get
        {
            return mCompany;
        }
        set
        {
            mCompany = value;
        }
    }
    }
   