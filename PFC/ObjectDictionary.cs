using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Txt;
using Radio;
using mLabels;
using mCheckBox;
using pictureBox;
using GroupBoxs;
using System.Drawing;



namespace PFC
{
    [Serializable]
    class ObjectDictionary
    {
        ObjectInfo[] objects;
        Size flage;
        
        public ObjectDictionary(Size flage, ArrayList TextBoxes, ArrayList RadioButtons, ArrayList CheckBoxes, ArrayList Images, ArrayList Finger,
            ArrayList Signuture, ArrayList Labels, ArrayList GroupBoxx)
        {
            this.flage = flage;
            int sum = TextBoxes.Count + RadioButtons.Count + CheckBoxes.Count +  Images.Count + Finger.Count + Signuture.Count + Labels.Count +
                GroupBoxx.Count ;

            this.objects = new ObjectInfo[sum];
            int counter = 0;
            double xx = 0;
            double yy =  0;
            double ww = 0;
            double hh = 0 ;
            for (int i = 0; i < TextBoxes.Count; i++)
            {
                xx = calculator(((TxtBox)TextBoxes[i]).Location.X, 1);
                yy = calculator(((TxtBox)TextBoxes[i]).Location.Y, 2);
                ww = calculator(((TxtBox)TextBoxes[i]).Width, 1);
                hh = calculator(((TxtBox)TextBoxes[i]).Height, 2);

                this.objects[counter++] = new ObjectInfo(((TxtBox)TextBoxes[i]).ToString(), ((TxtBox)TextBoxes[i]).caption, xx, yy, ww, hh);
            }

    
        }


        private double calculator(int p, int state)
        {
            if (state == 1)
                return (flage.Width / p);
            else
                return (flage.Height / p);

        }
    }
}

