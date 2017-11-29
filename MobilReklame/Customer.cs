using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class Customer
    {
        #region Instance Field
        private string _companyName;
        private string _phoneNumber;
        private string _adress;
        private string _email;
        private string _att;
        private string _cvr;
        #endregion

        #region Properties

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Att
        {
            get { return _att; }
            set { _att = value; }
        }

        public string Cvr
        {
            get { return _cvr; }
            set { _cvr = value; }
        }

        #endregion

        #region Constructor

        public Customer(string companyName, string phoneNumber, string adress, string email, string att, string cvr)
        {
            CompanyName = companyName;
            PhoneNumber = phoneNumber;
            Adress = adress;
            Email = email;
            Att = att;
            Cvr = cvr;
        }
        #endregion

        #region Customer ToString

        public override string ToString()
        {
            return $"{nameof(CompanyName)}: {CompanyName}, {nameof(PhoneNumber)}: {PhoneNumber}, {nameof(Adress)}: {Adress}, {nameof(Email)}: {Email}, {nameof(Att)}: {Att}, {nameof(Cvr)}: {Cvr}";
        }

        #endregion
    }
}
