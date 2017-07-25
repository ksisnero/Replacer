using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_prototype
{
    public class RegisterPatient
    {
        public string ReplaceValue(int valueToReplace)
        {
            string replacementValue1 = "Register";
            string replacementValue2 = "Patient";

            if (valueToReplace % 3 == 0 && valueToReplace % 5 == 0)
                return replacementValue1 + replacementValue2;
            else if (valueToReplace % 3 == 0)
                return replacementValue1;
            else if (valueToReplace % 5 == 0)
                return replacementValue2;
            else
                return valueToReplace.ToString();
        }

        public string ReplaceValues(int highestTranslatingNumber)
        {
            string Display = "";

            for (int r = 0; r <= highestTranslatingNumber; r++)
            {
                Display += "\n" + ReplaceValue(r);
            }
            return Display;
        }
    }
}
