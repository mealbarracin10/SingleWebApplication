using System;
namespace SingleWebApplication.Models
{
    public class Prices
    {
       public Guid idPrices
        {
            get;
            set;
        }
        public int PricesbyMinute
        {
            get;
            set;
        }
        public Guid idCompany
        {
            get;
            set;
        }

        public string UserModified
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
