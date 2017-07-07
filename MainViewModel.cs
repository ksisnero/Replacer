﻿using System;
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
        public virtual string GetUserInput { get; set; }
        private int? x;

        public MainViewModel()
        {
            Content = ViewModelSource.Create(() => new TextBoxContent());
        }

        public void Counter1(int x)
        {
            string Display = "";

            for (int r = 0; r < x + 1; r++)
            {
                //if number divisable by 2, 7, or 2 AND 7 return output
                if (r % 2 == 0 && r % 7 == 0)
                    Display += "\nDiagnose Patient";

                else if (r % 2 == 0)
                    Display += "\nDiagnose";

                else if (r % 7 == 0)
                    Display += "\nPatient";

                else
                    Display += "\n" + r.ToString();

                Content.Text = Display;
            }
        }

        public void Counter2(int x)
        {
            RegisterPatient registerPatient = new RegisterPatient();
            Content.Text = registerPatient.ReplaceValues(x);
        }

        public void Button1()
        {
            //get userinput and convert to int
            int x = 100;
            try
            {
                x = int.Parse(GetUserInput.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Input not valid!");
                x = 0;
            }
            //if not negative or a decimal display answer
            if (x > 0 && (x % 1 == 0))
                Counter1(x);
        }

        public void Button2()
        {
            int x = 100;
            try
            {
                x = int.Parse(GetUserInput.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Input not valid!");
                x = 0;
            }
            //if not negative or a decimal display answer
            if (x > 0 && (x % 1 == 0))
                Counter2(x);
        }
    }
}
   
