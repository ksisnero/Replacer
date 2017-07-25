using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_prototype
{
    public class PatientEvent
    {
        private int _firstNumberToReplace;
        private int _secondNumberToReplace;
        private string _replacementValue1;
        private string _replacementValue2;

        public PatientEvent(int firstNumberToReplace, int secondNumberToReplace, string replacementValue1, string replacementValue2)
        {
            _firstNumberToReplace = firstNumberToReplace;
            _secondNumberToReplace = secondNumberToReplace;
            _replacementValue1 = replacementValue1;
            _replacementValue2 = replacementValue2;
        }

        public string ReplaceValue(int valueToReplace)
        {
            if (valueToReplace % _firstNumberToReplace == 0 && valueToReplace % _secondNumberToReplace == 0)
                return _replacementValue1 + _replacementValue2;
            if (valueToReplace % _firstNumberToReplace == 0)
                return _replacementValue1;
            if (valueToReplace % _secondNumberToReplace == 0)
                return _replacementValue2;
            else
                return valueToReplace.ToString();
        }

        public string ReplaceValues(int highestTranslatingNumber)
        {
            string display = "";

            for (int r = 0; r <= highestTranslatingNumber; r++)
            {
                display += "\n" + ReplaceValue(r);
            }
            return display;
        }
    }
}
