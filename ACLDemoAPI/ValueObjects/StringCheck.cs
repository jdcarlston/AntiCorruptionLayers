using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ACLDemoAPI.ValueObjects
{
    public static class StringCheck

    {

        public enum Types
        {

            Solicitation, MarketingCode,

            FirstName, MiddleName, LastName, Ssn,

            MothersMaidenName, EmailAddress, Phone,

            Address, StreetNumber, StreetName,

            RuralRoute, BoxNumber, PoBox,

            Unit, City, State, Zip, BankAccount, BankRoutingNumber

        }



        public static List<string> GetRegexPatterns(Types type)

        {

            List<string> pattern = new List<string>();



            switch (type)

            {

                case Types.Address: pattern.Add(@"^[\w\d'\-\s\.\,\/\#]+$"); break;

                case Types.BankAccount: pattern.Add(@"^[0-9]{1,17}$"); break;

                case Types.BankRoutingNumber: pattern.Add(@"^[0-9]{9}$"); break;

                case Types.BoxNumber: pattern.Add(@"^[0-9\#][^\!\@\$\&\*\(\)_\'\;\:\?\,\\\/\s\#]{0,9}$"); break;

                case Types.City: pattern.Add(@"^[a-zA-Z0-9][^\!\@\$\&\*\(\)_\'\;\:\?\,\\\/]{1,25}$"); break;

                case Types.EmailAddress: pattern.Add(@"^(([^<>()\[\]\\.,;:\s@""]+(\.[^<>()\[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$"); break;

                case Types.FirstName: pattern.Add(@"^[a-zA-Z]{1}[a-zA-Z\s-\']{0,24}$"); break;

                case Types.LastName: pattern.Add(@"^[a-zA-Z]{1}[a-zA-Z\s-\']{0,23}[a-zA-Z]{1}$"); break;

                case Types.MarketingCode: pattern.Add(@"^[A-Z0-9]{10}$"); break;

                case Types.MiddleName: pattern.Add(@"^[a-zA-Z]{0,1}$"); break;

                case Types.MothersMaidenName: pattern.Add(@"^[a-zA-Z][a-zA-Z\s-\']{0,24}[a-zA-Z]{1,}$"); break;

                case Types.Phone: pattern.Add(@"^$|^(\(?[2-9][0-9]{2}\)?[\s]?|[2-9][0-9]{2}[\-\s\.]?)[2-9][0-9]{2}[\-\s\.]?[0-9]{4}$"); break;

                case Types.PoBox: pattern.Add(@"(?:P(?:ost(?:al)?)?m?[\.\-\s]*(?:(?:O(?:ffice)?[\.\-\s]*)?B(?:ox|in|x|o|\b|\d)|o(?:ffice|\b)(?:[-\s]*\d)|code)|box(?:[-\s|\#])*\d)"); break;

                case Types.RuralRoute: pattern.Add(@"^[0-9a-zA-Z\#][^\-\!\@\$\&\*\(\)_\'\;\:\?\,\\\/\#]{0,15}$"); break;

                case Types.Solicitation: pattern.Add(@"^[0-9A-Z]{12}$"); break;

                case Types.Ssn: pattern.Add(@"^(?!(([0123456789])\2{2}-?\2{2}-?\2{4}))(?!(000|9))\d{3}-?(?!00)\d{2}-?(?!0000)\d{4}$"); break;

                case Types.State: pattern.Add(@"^A[AEKLPRSZ]|C[AOT]|D[CE]|FL|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEINOPST]|N[CDEHJMVY]|O[HKR]|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY]$"); break;

                case Types.StreetName: pattern.Add(@"^[A-Z0-9a-z'\-\s\.\/\#]{2,25}$"); break;

                case Types.StreetNumber: pattern.Add(@"^[0-9\/\s-\#]{1,10}$"); break;

                case Types.Unit: pattern.Add(@"^[a-zA-Z0-9\/\s-\#]{1,10}$"); break;

                case Types.Zip: pattern.Add(@"^(?!0{5})(\d{5})(?!-?0{4})(|-?\d{4})?$"); break;

            }



            return pattern;

        }



        public static bool IsValid(string value, Types type, RegexOptions options)

        {

            List<string> patterns = GetRegexPatterns(type);



            foreach (string pattern in patterns)

            {

                if (!Regex.IsMatch(value, pattern, options))

                {

                    return false;

                }

            }



            return true;

        }



        public static bool IsValidSolicitation(string value)

        {

            return IsValid(value, Types.Solicitation, RegexOptions.IgnoreCase);

        }

        public static bool IsValidMarketingCode(string value)

        {

            return IsValid(value, Types.MarketingCode, RegexOptions.None);

        }

        public static bool IsValidFirstName(string value)

        {

            return IsValid(value, Types.FirstName, RegexOptions.IgnoreCase);

        }

        public static bool IsValidMiddleName(string value)

        {

            return IsValid(value, Types.MiddleName, RegexOptions.IgnoreCase);

        }

        public static bool IsValidLastName(string value)

        {

            return IsValid(value, Types.LastName, RegexOptions.IgnoreCase);

        }

        public static bool IsValidSsn(string value)

        {

            return IsValid(value, Types.Ssn, RegexOptions.IgnoreCase);

        }

        public static bool IsValidMothersMaidenName(string value)

        {

            return IsValid(value, Types.MothersMaidenName, RegexOptions.IgnoreCase);

        }

        public static bool IsValidEmailAddress(string value)

        {

            return IsValid(value, Types.EmailAddress, RegexOptions.IgnoreCase);

        }

        public static bool IsValidPhone(string value)

        {

            return IsValid(value, Types.Phone, RegexOptions.IgnoreCase);

        }

        public static bool IsValidAddress(string value)

        {

            return IsValid(value, Types.Address, RegexOptions.IgnoreCase);

        }

        public static bool IsValidStreetNumber(string value)

        {

            return IsValid(value, Types.StreetNumber, RegexOptions.IgnoreCase);

        }

        public static bool IsValidStreetName(string value)

        {

            return IsValid(value, Types.StreetName, RegexOptions.IgnoreCase);

        }

        public static bool IsValidRuralRoute(string value)

        {

            return IsValid(value, Types.RuralRoute, RegexOptions.IgnoreCase);

        }

        public static bool IsValidBoxNumber(string value)

        {

            return IsValid(value, Types.BoxNumber, RegexOptions.IgnoreCase);

        }

        public static bool IsValidPoBox(string value)

        {

            return IsValid(value, Types.PoBox, RegexOptions.IgnoreCase);

        }

        public static bool IsValidUnit(string value)

        {

            return IsValid(value, Types.Unit, RegexOptions.IgnoreCase);

        }

        public static bool IsValidCity(string value)

        {

            return IsValid(value, Types.City, RegexOptions.IgnoreCase);

        }

        public static bool IsValidState(string value)

        {

            return IsValid(value, Types.State, RegexOptions.IgnoreCase);

        }

        public static bool IsValidZip(string value)

        {

            return IsValid(value, Types.Zip, RegexOptions.IgnoreCase);

        }

        public static bool IsValidRoutingNumber(string value)

        {

            return IsValid(value, Types.BankRoutingNumber, RegexOptions.IgnoreCase);

        }

        public static bool IsValidBankAccount(string value)

        {

            return IsValid(value, Types.BankAccount, RegexOptions.IgnoreCase);

        }

    }
}