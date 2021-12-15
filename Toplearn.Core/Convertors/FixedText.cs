    using System;
using System.Collections.Generic;
using System.Text;

namespace Toplearn.Core.Convertors
{
    public class FixedText
    {
        public static string FixedEmail(string emil)
        {
            return emil.Trim().ToLower();
        }
    }
}
