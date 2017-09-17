using System;
namespace SingleWebApplication.Models
{
    public class User
    {
        public Guid idUser
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public Guid idPrices
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
