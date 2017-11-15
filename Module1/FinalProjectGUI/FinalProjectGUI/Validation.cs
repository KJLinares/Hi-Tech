  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProjectGUI
{
    public static class Validation
    {
        public static bool IsValidID( string id)
        {
            bool valid = false;

            if (id.Length== 4 || Regex.IsMatch(id, @"[0-9]"))
            {
                valid = true;
            }

            return valid;
        }

        public static bool IsValidPassword(String pss)
        {
            bool valid = false;

            if (Regex.IsMatch(pss, @"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$"))
            {
                valid = true;
            }

            return valid;
        }

        public static bool IsValidJobTitle(string jobTitle)
        {
            bool valid = false;

            if (jobTitle == "MIS Manager" || jobTitle == "Sales Manager" || jobTitle == "Inventory Controller" || jobTitle == "Order Clerk")
            {
                valid = true;
            }

            return valid;
        }

        public static bool ISValidText(string input)
        {
            bool valid = false;

            if ( input  == "" || input == " " || input == "   " || input == "." )
            {
                valid = true;
            }

            return valid;

        }
    }
}
