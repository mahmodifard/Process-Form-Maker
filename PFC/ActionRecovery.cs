using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar.Controls;
using Radio;
using pictureBox;
using CtrlCloneTst;
using System.Windows.Forms;
using mCheckBox;
using mLabels;



namespace PFC
{
    public class ActionRecovery
    {
        public Stack<Do> _undo;
        public Stack<Do> _redo;
        public int _actionType;
        public String type;
        GroupPanel Grp;
        FrmForProducer frm;
        ToolBox ToolBox;
 
        public ActionRecovery(GroupPanel Grp, FrmForProducer frm, ToolBox t)
        {
            this._undo = new Stack<Do>();
            this._redo = new Stack<Do>();
            this.Grp = Grp;
            this.frm = frm;
            this.ToolBox = t;

        }
        public void doing(int actionType, GComponents.GeneralComponent obj)
        {
            String name = obj.Name;
            String type = obj.GetType().ToString();

            GComponents.GeneralComponent ctrl = setProperty(obj);            

            ctrl.MouseDown += new MouseEventHandler(frm.MouseDowns);
            ctrl.Click     += new EventHandler(frm.ShowPropertiesOfSelectedControl);
            ctrl.MouseUp   += new System.Windows.Forms.MouseEventHandler(frm.MouseUps);

            this._undo.Push(new Do(name, type, actionType, ctrl));
          //  this._actionType = actionType;

            if (this._undo.Count >= 20)
            {
                this._undo.Reverse();
                this._undo.Pop();
                this._undo.Reverse();
            }
        }

        GComponents.GeneralComponent creatObject(String type)
        {
            GComponents.GeneralComponent Gcom = null;
            switch (type)
            {
                case "Txt.TxtBox":
                    {
                        Gcom = new Txt.TxtBox();

                    }
                    break;

                case "Radio.RadioControll":
                    {
                        Gcom = new RadioControll();

                    }
                    break;

                case "mCheckBox.myCheckBox":
                    {
                        Gcom = new myCheckBox();


                    }
                    break;

                case "pictureBox.myPic":
                    {
                        Gcom = new myPic();

                    }
                    break;

                case "mHLine.myHLine":
                    {

                        Gcom = new mHLine.myHLine();
                       
                    }
                    break;

                case "mLabels.myLabel":
                    {
                        Gcom = new myLabel();

                    }
                    break;
                case "GroupBoxs.myGroupBoxs":
                    {
                        Gcom = new GroupBoxs.myGroupBoxs();
                     
                    }
                    break;

            }
            return Gcom;
        }

        public GComponents.GeneralComponent setProperty(GComponents.GeneralComponent source)
        {
            GComponents.GeneralComponent gc = creatObject(source.GetType().ToString());
            
            gc.Name = source.Name;
            gc.Size = new System.Drawing.Size(((GComponents.GeneralComponent)source).Width, ((GComponents.GeneralComponent)source).Height);
            gc.Top = ((GComponents.GeneralComponent)source).Top ;
            gc.Left = ((GComponents.GeneralComponent)source).Left;
            gc.caption = ((GComponents.GeneralComponent)source).caption ;
            gc.setText(((GComponents.GeneralComponent)source).getText());
            gc.setFont(((GComponents.GeneralComponent)source).getFont());
            gc.setForeColor(((GComponents.GeneralComponent)source).getForeColor());          

            try
            {
                gc.setState(((GComponents.GeneralComponent)source).getState());
                ((mHLine.myHLine)gc).setBorderWidths(((mHLine.myHLine)source).getBorderWidth());               
            }
            catch{}
            return gc;
        }
        public void undo(RectTrackerSharp.RectTracker rectTracker)
        {

            if (_undo.Count == 0)
                return;

            try
            {
                // 1 Created
                if (_undo.Peek()._actionType == 1)
                {
                    Object o = serchObject(_undo.Peek()._name);
                    Grp.Controls.Remove(((GComponents.GeneralComponent)o));

                    if (Grp.Controls.Contains(rectTracker))
                        Grp.Controls.Remove(rectTracker);
                    ToolBox.Generalcomponent.Remove(((GComponents.GeneralComponent)o));

                    _undo.Pop();
                    _redo.Push(new Do(((GComponents.GeneralComponent)o).Name, ((GComponents.GeneralComponent)o).GetType().ToString(), 3, ((GComponents.GeneralComponent)o)));
                }
                // 2 changed
                else if (_undo.Peek()._actionType == 2)
                {
                    Object o = serchObject(_undo.Peek()._name);

                    Grp.Controls.Remove(((GComponents.GeneralComponent)o));
                    ToolBox.Generalcomponent.Remove(((GComponents.GeneralComponent)o));

                    Grp.Controls.Add(((GComponents.GeneralComponent)_undo.Peek()._object));
                    ToolBox.Generalcomponent.Add((((GComponents.GeneralComponent)_undo.Peek()._object)));
                    if (((GComponents.GeneralComponent)_undo.Peek()._object).GetType() != typeof(GroupBoxs.myGroupBoxs))
                        ((GComponents.GeneralComponent)_undo.Peek()._object).BringToFront();


                    if (Grp.Controls.Contains(rectTracker))
                        Grp.Controls.Remove(rectTracker);
                    rectTracker = new RectTrackerSharp.RectTracker((((GComponents.GeneralComponent)_undo.Peek()._object)));

                    _undo.Pop();
                    _redo.Push(new Do(((GComponents.GeneralComponent)o).Name, ((GComponents.GeneralComponent)o).GetType().ToString(), 2, ((GComponents.GeneralComponent)o)));

                }
                // 3 Deleted
                else if (_undo.Peek()._actionType == 3)
                {
                    Grp.Controls.Add(((GComponents.GeneralComponent)_undo.Peek()._object));
                    ToolBox.Generalcomponent.Add((((GComponents.GeneralComponent)_undo.Peek()._object)));

                    _undo.Peek()._actionType = 1;
                    _redo.Push(_undo.Pop());
                }
            }
            catch { }
        }

        public void redo(RectTrackerSharp.RectTracker rectTracker)
        {

            if (_redo.Count == 0)
                return;

            try
            {
                // 1 Created
                if (_redo.Peek()._actionType == 1)
                {
                    Object o = serchObject(_redo.Peek()._name);
                    Grp.Controls.Remove(((GComponents.GeneralComponent)o));

                    if (Grp.Controls.Contains(rectTracker))
                        Grp.Controls.Remove(rectTracker);
                    ToolBox.Generalcomponent.Remove(((GComponents.GeneralComponent)o));

                    _redo.Pop();
                    _undo.Push(new Do(((GComponents.GeneralComponent)o).Name, ((GComponents.GeneralComponent)o).GetType().ToString(), 3, ((GComponents.GeneralComponent)o)));
                }
                // 2 changed
                else if (_redo.Peek()._actionType == 2)
                {
                    Object o = serchObject(_redo.Peek()._name);

                    Grp.Controls.Remove(((GComponents.GeneralComponent)o));
                    Grp.Controls.Add(((GComponents.GeneralComponent)_redo.Peek()._object));

                    if (((GComponents.GeneralComponent)_redo.Peek()._object).GetType() != typeof(GroupBoxs.myGroupBoxs))
                        ((GComponents.GeneralComponent)_redo.Peek()._object).BringToFront();

                    ToolBox.Generalcomponent.Remove(((GComponents.GeneralComponent)o));
                    ToolBox.Generalcomponent.Add((((GComponents.GeneralComponent)_redo.Peek()._object)));
                    _redo.Pop();
                    _undo.Push(new Do(((GComponents.GeneralComponent)o).Name, ((GComponents.GeneralComponent)o).GetType().ToString(), 2, ((GComponents.GeneralComponent)o)));

                }
                // 3 Deleted
                else if (_redo.Peek()._actionType == 3)
                {
                    Grp.Controls.Add(((GComponents.GeneralComponent)_redo.Peek()._object));
                    ToolBox.Generalcomponent.Add((((GComponents.GeneralComponent)_redo.Peek()._object)));

                    _redo.Peek()._actionType = 1;
                    _undo.Push(_redo.Pop());
                }
            }
            catch { }

        }

        // +++++++++++++ END


        public Object serchObject(String name)
        {

            for (int i = 0; i < this.ToolBox.Generalcomponent.Count; i++)
            {
                if (((GComponents.GeneralComponent)ToolBox.Generalcomponent[i]).Name == name)
                {
                    return ToolBox.Generalcomponent[i];
                }
            }
            
            return null;
        }
    }
}
