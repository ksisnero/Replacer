using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/*  Created 5/30/17 - Karina Sisnero
 *  Code that prints from 1-100 changing the values of the numbers based of their divisibilty
 */

namespace Intern_prototype
{
    public class MainViewModel
    {
        public virtual TextBoxContent Content { get; set; }
        public virtual string UserInput { get; set; }

        private PatientEvent _diagnoseEvent;
        private PatientEvent _registerEvent;

        public MainViewModel()
        {
            Content = ViewModelSource.Create(() => new TextBoxContent());
            _registerEvent = new PatientEvent(3, 5, "Register", "Patient");
            _diagnoseEvent = new PatientEvent(2, 7, "Diagnose", "Patient");
        }

        public void DiagnosePatient()
        {
            int highestNumberTranslated = GetUserInput();

            if (highestNumberTranslated > 0 && (highestNumberTranslated % 1 == 0))
            {
                Content.Text = _diagnoseEvent.ReplaceValues(highestNumberTranslated);
            }
        }

        public void RegisterPatient()
        {
            int highestNumberTranslate = GetUserInput();

            if (highestNumberTranslate > 0 && (highestNumberTranslate % 1 == 0))
            {
                Content.Text = _registerEvent.ReplaceValues(highestNumberTranslate);
            }
        }

        public int GetUserInput()
        {
            //get userinput and convert to int
            int highestNumberTranslated;

            try
            {
                highestNumberTranslated = int.Parse(UserInput);
            }
            catch (Exception)
            {
                MessageBox.Show("Input not valid!");
                highestNumberTranslated = 0;
            }
            return highestNumberTranslated;
        }
    }
}
   
