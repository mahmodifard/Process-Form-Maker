using System;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CtrlCloneTst
{
    #region ControlFactory
    /// <summary>
    /// Summary description for FormControlFactory.
    /// </summary>
    public class ControlFactory
    {
        public ControlFactory()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static Control CreateControl(string ctrlName, string partialName)
        {
            try
            {
                Control ctrl;
                switch (ctrlName)
                {
                    case "Label":
                        ctrl = new Label();
                        break;
                    case "TextBox":
                        ctrl = new TextBox();
                        break;
                    case "PictureBox":
                        ctrl = new PictureBox();
                        break;
                    case "ListView":
                        ctrl = new ListView();
                        break;
                    case "ComboBox":
                        ctrl = new ComboBox();
                        break;
                    case "Button":
                        ctrl = new Button();
                        break;
                    case "CheckBox":
                        ctrl = new CheckBox();
                        break;
                    case "MonthCalender":
                        ctrl = new MonthCalendar();
                        break;
                    case "DateTimePicker":
                        ctrl = new DateTimePicker();
                        break;
                    default:
                        Assembly controlAsm = Assembly.LoadWithPartialName(partialName);
                        Type controlType = controlAsm.GetType(partialName + "." + ctrlName);
                        ctrl = (Control)Activator.CreateInstance(controlType);
                        break;

                }
                return ctrl;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("create control failed:" + ex.Message);
                return new Control();
            }
        }

        public static void SetControlProperties(Control ctrl, Hashtable propertyList)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(ctrl);

            foreach (PropertyDescriptor myProperty in properties)
            {
                if (propertyList.Contains(myProperty.Name))
                {
                    Object obj = propertyList[myProperty.Name];
                    try
                    {
                        myProperty.SetValue(ctrl, obj);
                    }
                    catch (Exception ex)
                    {
                        //do nothing, just continue
                        System.Diagnostics.Trace.WriteLine(ex.Message);
                    }

                }

            }








        }


        public static GComponents.GeneralComponent CloneCtrl(Object ctrl)
        {

            CBFormCtrl cbCtrl = new CBFormCtrl(ctrl);
            GComponents.GeneralComponent newCtrl = new GComponents.GeneralComponent();

            ControlFactory.SetControlProperties(newCtrl, cbCtrl.PropertyList);

            return ((GComponents.GeneralComponent)newCtrl);
        }


        public static void CopyCtrl2ClipBoard(Control ctrl)
        {
            CBFormCtrl cbCtrl = new CBFormCtrl(ctrl);
            IDataObject ido = new DataObject();

            ido.SetData(CBFormCtrl.Format.Name, true, cbCtrl);
            Clipboard.SetDataObject(ido, false);

        }

        public static Control GetCtrlFromClipBoard()
        {
            Control ctrl = new Control();

            IDataObject ido = Clipboard.GetDataObject();
            if (ido.GetDataPresent(CBFormCtrl.Format.Name))
            {
                CBFormCtrl cbCtrl = ido.GetData(CBFormCtrl.Format.Name) as CBFormCtrl;

                ctrl = ControlFactory.CreateControl(cbCtrl.CtrlName, cbCtrl.PartialName);
                ControlFactory.SetControlProperties(ctrl, cbCtrl.PropertyList);

            }
            return ctrl;
        }


    }

    #endregion

    #region Clipboard Support
    /// <summary>
    /// Summary description for CBFormCtrl.
    /// </summary>
    [Serializable()]
    public class CBFormCtrl//clipboard form control
    {
        private static DataFormats.Format format;
        private string ctrlName;
        private string partialName;
        private Hashtable propertyList = new Hashtable();

        static CBFormCtrl()
        {
            // Registers a new data format with the windows Clipboard
            format = DataFormats.GetFormat(typeof(CBFormCtrl).FullName);
        }

        public static DataFormats.Format Format
        {
            get
            {
                return format;
            }
        }
        public string CtrlName
        {
            get
            {
                return ctrlName;
            }
            set
            {
                ctrlName = value;
            }
        }

        public string PartialName
        {
            get
            {
                return partialName;
            }
            set
            {
                partialName = value;
            }
        }

        public Hashtable PropertyList
        {
            get
            {
                return propertyList;
            }

        }


        public CBFormCtrl()
        {

        }
        public static Hashtable GetProperty(GComponents.GeneralComponent ctrl)
        {
            //string ctrlName;
            //string partialName;
            //Hashtable propertyList = new Hashtable();

            //CBFormCtrl cb = new CBFormCtrl();
            //cb.CtrlName = ctrl.GetType().Name;
            //cb.PartialName = ctrl.GetType().Namespace;

            //PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(ctrl);

            //foreach (PropertyDescriptor myProperty in properties)
            //{
            //    try
            //    {
            //        if (myProperty.PropertyType.IsSerializable)
            //        {
                                               
            //            String v = myProperty.GetValue(ctrl).ToString() ;                        
            //            propertyList.Add(myProperty.Name, myProperty.GetValue(ctrl));
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        System.Diagnostics.Trace.WriteLine(ex.Message);
            //        //do nothing, just continue
            //    }

            //}
            Hashtable propertyList = new Hashtable();
           
            propertyList.Add("Width", ((GComponents.GeneralComponent)ctrl).Width);
            propertyList.Add("Height", ((GComponents.GeneralComponent)ctrl).Height);
            propertyList.Add("Top", ((GComponents.GeneralComponent)ctrl).Top);
            propertyList.Add("Left", ((GComponents.GeneralComponent)ctrl).Left);
         
           // --------------------- for scaling
            float w = PFC.FrmForProducer.FTR.X - PFC.FrmForProducer.FTL.X;
            float h = PFC.FrmForProducer.FDL.Y - PFC.FrmForProducer.FTL.Y;

            propertyList.Add("Width2", ( (float) (w/(float)((GComponents.GeneralComponent)ctrl).Width)));
            propertyList.Add("Height2", ( (float) (h/(float)  ((GComponents.GeneralComponent)ctrl).Height)));
            propertyList.Add("Top2", ( ( (GComponents.GeneralComponent)ctrl).Top - PFC.FrmForProducer.FTL.Y) / h );
            propertyList.Add("Left2", ( ( (GComponents.GeneralComponent)ctrl).Left - PFC.FrmForProducer.FTL.X) / w );

            // --------------------



            propertyList.Add("caption", ((GComponents.GeneralComponent)ctrl).caption);
            propertyList.Add("Text", ((GComponents.GeneralComponent)ctrl).getText());
            propertyList.Add("Font", ((GComponents.GeneralComponent)ctrl).getFont());
            propertyList.Add("ForeColor", ((GComponents.GeneralComponent)ctrl).getForeColor());

            //(GComponents.GeneralComponent)ctrl).getType();
            propertyList.Add("Type", (""));
           
            try
            {
                propertyList.Add("LineState", ((GComponents.GeneralComponent)ctrl).getState());
                propertyList.Add("Borderwidth", ((mHLine.myHLine)ctrl).getBorderWidth());
            }
            catch
            {
 
            }


            return propertyList;
        }
        public CBFormCtrl(Object ctrl)
        {
            CtrlName = ctrl.GetType().Name;
            PartialName = ctrl.GetType().Namespace;

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(ctrl);

            foreach (PropertyDescriptor myProperty in properties)
            {
                try
                {
                    if (myProperty.PropertyType.IsSerializable)
                        propertyList.Add(myProperty.Name, myProperty.GetValue(ctrl));
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine(ex.Message);
                    //do nothing, just continue
                }

            }



        }


    }
    #endregion
}
