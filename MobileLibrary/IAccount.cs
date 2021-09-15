using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    interface IAccount
    {
        void savingaccount();
        void currentaccount();
    }
    interface ISavingAccount
    {
        void showCustomer();
    }
    interface ICurrentAccount
    {
        void showCustomer();
    }

    class bank :Samsung, ISavingAccount, ICurrentAccount,IAccount
    {
        public void currentaccount()
        {
            
        }

        public void savingaccount()
        {
            
        }

        public void showCustomer()
        {
            Console.WriteLine("showcustomer");
        }
    }
}
