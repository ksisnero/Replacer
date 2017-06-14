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
        public virtual ObservableCollection<TextBoxContent> TextList { get; set; }
        public MainViewModel()
        {
            TextList = new ObservableCollection<TextBoxContent>();
        }

        public virtual void Button1()
        {
            TextBoxContent content;
            TextList.Clear();
            string Display;

            for (int r = 0; r < 101; r++)
            {
                if (r % 2 == 0 && r % 7 == 0)
                    Display = "Diagnose Patient";
                else if (r % 2 == 0)
                    Display = "Diagnose";

                else if (r % 7 == 0)
                    Display = "Patient";
                else
                    Display = r.ToString();

                content = new TextBoxContent() { contentOfTextbox = Display };

                TextList.Add(content);

            }
        }

        //public virtual void Button2()
        //{
        //    TextBoxContent content2;
        //    TextList.Clear();

        //    string Display2;

        //    for (int r = 0; r < 101; r++)
        //    {
        //        if (r % 3 == 0 && r % 5 == 0)
        //            Display2 = "Register Patient";

        //        else if (r % 3 == 0)
        //            Display2 = "Register";

        //        else if (r % 5 == 0)
        //            Display2 = "Patient";

        //        else
        //            Display2 = r.ToString();

        //        content2 = new TextBoxContent() { contentOfTextbox = Display2 };
        //        TextList.Add(content2);
        //    }
        //}
    }
}
   
