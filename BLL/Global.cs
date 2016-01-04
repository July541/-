using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL
{
    public class Global
    {
        public bool ageCheck(string age)
        {
            Regex reg = new Regex(@"^([0-9]|[0-9]{2}|100)$");
            bool ismatch = reg.IsMatch(age);
            return ismatch;
        }
    }
}
