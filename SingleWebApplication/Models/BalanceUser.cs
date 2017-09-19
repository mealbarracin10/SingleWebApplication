using System;
namespace SingleWebApplication.Models
{
    public class BalanceUser
    {
        public Guid idBalanceUser
        {
            get;
            set;
        }

        public Guid idUser
        {
            get;
            set;
        }

        public int MinutesAvailables
        {
            get;
            set;
        }




    }
}
