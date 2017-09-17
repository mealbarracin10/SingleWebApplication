using System;
namespace SingleWebApplication.Models
{
    public class SiteByRecharge
    {
        public Guid idSiteByRecharge
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
   
        public string Location
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
    
    }
}
