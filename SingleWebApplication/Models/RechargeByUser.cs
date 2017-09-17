using System;
namespace SingleWebApplication.Models
{
    public class RechargeByUser
    {
        public Guid idRecharge
        {
            get;
            set;
        }

        public Guid idUser
        {
            get;
            set;
        }

        public Guid idSiteRecharge
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
