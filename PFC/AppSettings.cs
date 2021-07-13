using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Txt;
using Radio;
using mLabels;
using mCheckBox;
using pictureBox;
using GroupBoxs;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using mHLine;


namespace PFC
{

    public class AppSettings
    {
        private string name = "", Caption,neveshteh="";
        int width;
        int height;
        int X;
        int y;
        object SelectedObject;
        string Type = "";
        GroupPanel groupPanel = null;
        RectTrackerSharp.RectTracker Rect = null;
        public AppSettings(object OB, string T, GroupPanel GP, RectTrackerSharp.RectTracker RC)
        {
            SelectedObject = OB;
            Type = T;
            groupPanel = GP;
            Rect = RC;

        }
        //public string نام
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //        if (groupPanel.Controls.Contains(Rect))
        //            groupPanel.Controls.Remove(Rect);
        //        if (Type == "txt")
        //        {
        //            ((TxtBox)SelectedObject).Name = value;
        //            Rect = new RectTrackerSharp.RectTracker(((TxtBox)SelectedObject));

        //        }
        //        else if (Type == "radio")
        //        {
        //            ((RadioControll)SelectedObject).Name = value;
        //            Rect = new RectTrackerSharp.RectTracker(((RadioControll)SelectedObject));
        //        }
        //        else if (Type == "label")
        //        {
        //            ((myLabel)SelectedObject).Name = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myLabel)SelectedObject));

        //        }
        //        else if (Type == "check")
        //        {
        //            ((myCheckBox)SelectedObject).Name = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myCheckBox)SelectedObject));

        //        }
        //        else if (Type == "group")
        //        {
        //            ((myGroupBoxs)SelectedObject).Name = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myGroupBoxs)SelectedObject));

        //        }
        //        else if (Type == "picture")
        //        {
        //            ((myPic)SelectedObject).Name = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myPic)SelectedObject));

        //        }
        //        else if (Type == "line")
        //        {
                    
                


        //                ((myHLine)SelectedObject).Name = value;
        //                Rect = new RectTrackerSharp.RectTracker(((myHLine)SelectedObject));
              
        //        }
        //    }

        //}

        //public string عنوان
        //{
        //    get
        //    {
        //        return Caption;
        //    }
        //    set
        //    {
        //        Caption = value;
        //        if (groupPanel.Controls.Contains(Rect))
        //            groupPanel.Controls.Remove(Rect);
        //        if (Type == "txt")
        //        {
        //            ((TxtBox)SelectedObject).caption = value;
        //            Rect = new RectTrackerSharp.RectTracker(((TxtBox)SelectedObject));



        //        }
        //        else if (Type == "radio")
        //        {
        //            ((RadioControll) SelectedObject).caption = value;
        //            Rect = new RectTrackerSharp.RectTracker(((RadioControll)SelectedObject));
                   

        //        }
        //        else if (Type == "label")
        //        {
        //            ((myLabel)SelectedObject).caption = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myLabel)SelectedObject));


        //        }
        //        else if (Type == "check")
        //        {
        //            ((myCheckBox)SelectedObject).caption = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myCheckBox)SelectedObject));

        //        }
        //        else if (Type == "group")
        //        {
        //            ((myGroupBoxs)(((nGroupBox)SelectedObject).Parent)).caption = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myGroupBoxs)SelectedObject));


        //        }
        //        else if (Type == "picture")
        //        {
        //            ((myPic)SelectedObject).caption = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myPic)SelectedObject));

        //        }
        //        else if (Type == "line")
        //        {




        //            ((myHLine)SelectedObject).caption = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myHLine)SelectedObject));

        //        }


        //    }

        //}

        //public int طول
        //{
        //    get { return width; }
        //    set
        //    {

        //        width = value;
        //        if (groupPanel.Controls.Contains(Rect))
        //            groupPanel.Controls.Remove(Rect);

        //        if (Type == "txt")
        //        {
        //            ((TxtBox)SelectedObject).Width = value;
        //            Rect = new RectTrackerSharp.RectTracker(((TxtBox)SelectedObject));

        //        }
        //        else if (Type == "radio")
        //        {
        //            ((nRadio)SelectedObject).Parent.Width = value;
        //            Rect = new RectTrackerSharp.RectTracker(((RadioControll)SelectedObject));


        //        }
        //        else if (Type == "label")
        //        {
        //            ((nLabel)SelectedObject).Parent.Width = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myLabel)SelectedObject));


        //        }
        //        else if (Type == "check")
        //        {
        //            ((nCheckBox)SelectedObject).Parent.Width = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myCheckBox)SelectedObject));

        //        }
        //        else if (Type == "group")
        //        {
        //            ((myGroupBoxs)(((nGroupBox)SelectedObject).Parent)).Width = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myGroupBoxs)SelectedObject));

        //        }
        //        else if (Type == "picture")
        //        {
        //            ((myPic)SelectedObject).Width = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myPic)SelectedObject));

        //        }
        //        else if (Type == "line")
        //        {

        //            ((myHLine)SelectedObject).Width = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myHLine)SelectedObject));

        //        }


        //    }
        //}
        //public int ارتفاع
        //{
        //    get { return height; }
        //    set
        //    {
        //        height = value;
        //        if (groupPanel.Controls.Contains(Rect))
        //            groupPanel.Controls.Remove(Rect);
        //        if (Type == "txt")
        //        {
        //            ((TxtBox)SelectedObject).Height = value;

        //            Rect = new RectTrackerSharp.RectTracker(((TxtBox)SelectedObject));
                    
        //        }
        //        else if (Type == "radio")
        //        {
        //            ((nRadio)SelectedObject).Parent.Height = value;
        //            Rect = new RectTrackerSharp.RectTracker(((RadioControll)SelectedObject));


        //        }
        //        else if (Type == "label")
        //        {
        //            ((nLabel)SelectedObject).Parent.Height = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myLabel)SelectedObject));


        //        }
        //        else if (Type == "check")
        //        {
        //            ((nCheckBox)SelectedObject).Parent.Height = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myCheckBox)SelectedObject));

        //        }
        //        else if (Type == "group")
        //        {
        //            ((myGroupBoxs)(((nGroupBox)SelectedObject).Parent)).Height = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myGroupBoxs)SelectedObject));

        //        }
        //        else if (Type == "picture")
        //        {
        //            ((myPic)SelectedObject).Height = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myPic)SelectedObject));

        //        }
        //        else if (Type == "line")
        //        {

        //            ((myHLine)SelectedObject).Height = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myHLine)SelectedObject));

        //        }

        //    }
        //}
        //public int موقعیت_X
        //{
        //    get { return X;
        //    }
        //    set
        //    {
        //        X = value;
        //        if (groupPanel.Controls.Contains(Rect))
        //            groupPanel.Controls.Remove(Rect);
        //        if (Type == "txt")
        //        {
        //            ((TxtBox)SelectedObject).Left = value;
        //            Rect = new RectTrackerSharp.RectTracker(((TxtBox)SelectedObject));


        //        }
        //        else if (Type == "radio")
        //        {
        //            ((nRadio)SelectedObject).Parent.Left = value;
        //            Rect = new RectTrackerSharp.RectTracker(((RadioControll)SelectedObject));


        //        }
        //        else if (Type == "label")
        //        {
        //            ((nLabel)SelectedObject).Parent.Left = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myLabel)SelectedObject));


        //        }
        //        else if (Type == "check")
        //        {
        //            ((nCheckBox)SelectedObject).Parent.Left = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myCheckBox)SelectedObject));
        //        }
        //        else if (Type == "group")
        //        {
        //            ((myGroupBoxs)(((nGroupBox)SelectedObject).Parent)).Left = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myGroupBoxs)SelectedObject));

        //        }
        //        else if (Type == "picture")
        //        {
        //            ((myPic)SelectedObject).Left = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myPic)SelectedObject));

        //        }
        //        else if (Type == "line")
        //        {

        //            ((myHLine)SelectedObject).Left = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myHLine)SelectedObject));

        //        }

        //    }
        //}
        //public int موقعیت_y
        //{
        //    get { return y; }
        //    set
        //    {
        //        y = value;
        //        if (groupPanel.Controls.Contains(Rect))
        //            groupPanel.Controls.Remove(Rect);
        //        if (Type == "txt")
        //        {
        //            ((TxtBox)SelectedObject).Top = value;
        //            Rect = new RectTrackerSharp.RectTracker(((TxtBox)SelectedObject));


        //        }
        //        else if (Type == "radio")
        //        {
        //            ((nRadio)SelectedObject).Parent.Top = value;
        //            Rect = new RectTrackerSharp.RectTracker(((RadioControll)SelectedObject));


        //        }
        //        else if (Type == "label")
        //        {
        //            ((nLabel)SelectedObject).Parent.Top = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myLabel)SelectedObject));


        //        }
        //        else if (Type == "check")
        //        {
        //            ((nCheckBox)SelectedObject).Parent.Top = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myCheckBox)SelectedObject));
        //        }
        //        else if (Type == "group")
        //        {
        //            ((myGroupBoxs)(((nGroupBox)SelectedObject).Parent)).Top = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myGroupBoxs)(((nGroupBox)SelectedObject).Parent)));

        //        }
        //        else if (Type == "picture")
        //        {
        //            ((myPic)SelectedObject).Top = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myPic)SelectedObject));

        //        }
        //        else if (Type == "line")
        //        {

        //            ((myHLine)SelectedObject).Top = value;
        //            Rect = new RectTrackerSharp.RectTracker(((myHLine)SelectedObject));

        //        }

        //    }
        //}

        //public string نوشته
        //{
        //    get { return neveshteh; }
        //    set
        //    {
        //        neveshteh = value;
        //        if (groupPanel.Controls.Contains(Rect))
        //            groupPanel.Controls.Remove(Rect);
               
        //        if (Type == "txt")
        //        {
        //            neveshteh = "";

        //        }

        //        else if (Type == "radio")
        //        {
        //            ((RadioControll) SelectedObject).setText(value);
        //            Rect = new RectTrackerSharp.RectTracker(((RadioControll)SelectedObject));


        //        }
        //        else if (Type == "label")
        //        {
        //           ((myLabel)SelectedObject).setText(value);
        //            Rect = new RectTrackerSharp.RectTracker(((myLabel)SelectedObject));


        //        }
        //        else if (Type == "check")
        //        {
        //            (((myCheckBox)SelectedObject)).setText(value);
        //            Rect = new RectTrackerSharp.RectTracker(((myCheckBox)SelectedObject));
        //        }
        //        else if (Type == "group")
        //        {
        //            ((myGroupBoxs)(SelectedObject)).setText(value);
        //            Rect = new RectTrackerSharp.RectTracker(((myGroupBoxs)(SelectedObject)));

        //        }
        //        else if (Type == "picture")
        //        {
        //            ((myPic)SelectedObject).setTex(value);
        //            Rect = new RectTrackerSharp.RectTracker(((myPic)SelectedObject));

        //        }
        //        else if (Type == "line")
        //        {
        //            if (value == "1")
        //                ((myHLine)SelectedObject).setHorizental();
        //            else
        //                ((myHLine)SelectedObject).setVertical();

        //            Rect = new RectTrackerSharp.RectTracker(((myHLine)SelectedObject));

        //        }

        //    }
        //}
    }

}
