using System;
using System.Data.Entity;



namespace SingleWebApplication.Models
{
    public class Company
    {
        public Guid idCompany
        {
            get;
            set;
        }

        public string NameCompany
        {
            get;
            set;
        }

        public DateTime DateCreated
        {
            get;
            set;
        }
        public DateTime DateModified
        {
            get;
            set;
        }

        class CompanyDbontext: DbContext 
        {
            public DbSet<Company> Companys {get; set; } 
        }

    }
}
