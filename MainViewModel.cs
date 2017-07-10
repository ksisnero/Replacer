using System;
using System.Windows;
using DevExpress.Mvvm.POCO;
using CC1;

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
            int HighestNumberTranslate = GetUserInput();

            if (HighestNumberTranslate > 0 && (HighestNumberTranslate % 1 == 0))
            {
                Content.Text = _diagnoseEvent.ReplaceValues(HighestNumberTranslate);
            }
        }

        public void RegisterPatient()
        {
            int HighestNumberTranslate = GetUserInput();

            if (HighestNumberTranslate > 0 && (HighestNumberTranslate % 1 == 0))
            {
                Content.Text = _registerEvent.ReplaceValues(HighestNumberTranslate);
            }
        }

        public int GetUserInput()
        {
            //get userinput and convert to int
            int x = 100;
            try
            {
                x = int.Parse(UserInput.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Input not valid!");
                x = 0;
            }
            return x;
        }
    }
}
   
