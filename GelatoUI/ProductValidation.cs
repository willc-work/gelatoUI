using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GelatoUI
{
    public static class ProductValidation
    {
        /// <summary>
        /// Checks if a product name is Valid. A valid product name must contain atleast one letter (TODO: Check spec)
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public static bool ValidateProductName(string productName)
        {
            Regex regex = new Regex("[a-zA-Z]", RegexOptions.IgnoreCase | RegexOptions.Singleline); //Match all letters
            Match match = regex.Match(productName);

            if (match.Success) //Does the product name match the regex?
                return true;

            return false;
        }

        /// <summary>
        /// Ensures the quantity value is between 1 and 100
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns>Boolean</returns>
        public static bool ValidateQuantity(int quantity)
        {
            if (quantity >= 1) //Is the quantity within the boundaries?
                return true;

            return false;
        }

    }
}
