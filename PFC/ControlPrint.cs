using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace PrintControl
{
    public partial class ControlPrint : PrintDocument
    {
        private Control m_ctrl;

        private bool stretch;

        /// <summary>
        /// Set true to stretch the control to fill a single printed page
        /// </summary>
        public bool StretchControl
        {
            set { stretch = value; }
            get { return stretch; }
        }

        private int width;
        private int height;
        /// <summary>
        /// Printed Height
        /// </summary>
        public int PrintWidth
        {
            set { width = value; }
            get { return width; }
        }

        /// <summary>
        /// Printed Width
        /// </summary>
        public int PrintHeight
        {
            set { height = value; }
            get { return height; }
        }
        
        public ControlPrint()
        {
          
            m_ctrl = new Control();
            stretch = false;
            width = m_ctrl.Width;
            height = m_ctrl.Height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="print">The control you wish to print</param>
        public ControlPrint(Control print)
        {
            
            SetControl(print);
            stretch = false;
        }

    

        /// <summary>
        /// 
        /// </summary>
        /// <param name="print">The control you wish to print</param>
        /// <param name="Stretch">Set true to stretch the control to fill a single printed page</param>
        public ControlPrint(Control print, bool Str)
        {
           
            SetControl(print);
            stretch = Str;
        }

        public ControlPrint(IContainer container)
        {
            container.Add(this);
       
            m_ctrl = new Control();
            stretch = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="print">The control you wish to print</param>
        public void SetControl(Control print)
        {
            m_ctrl = print;
            CalculateSize();
            printedheight = 0;
        }

        /// <summary>
        /// Force the control to a specified height & width
        /// </summary>
        /// <param name="print">The control you wish to print</param>
        /// <param name="Width">Control's width</param>
        /// <param name="Height">Control's height</param>
        public void SetControl(Control print, int Width, int Height)
        {
            m_ctrl = print;
            width = Width;
            height = Height;
            printedheight = 0;
        }

        private int printedheight;
        private void ControlPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            Size OldSize = new Size(m_ctrl.Width, m_ctrl.Height);
            Rectangle rect = new Rectangle(e.PageSettings.Bounds.Location.X + 40, e.PageSettings.Bounds.Location.Y + 40,
                            e.PageSettings.Bounds.Width - 80, e.PageSettings.Bounds.Height - 100);
            DockStyle OldDock = m_ctrl.Dock;
            m_ctrl.Dock = DockStyle.None;
            m_ctrl.Size = new Size(width, height);
            int printwidth = width;
            int printheight = height;

            if (printwidth > rect.Width)
            {
                printheight = (int)(((float)rect.Width / (float)printwidth) * printheight);
                printwidth = rect.Width;
            }

            if (printheight - printedheight > rect.Height - 25 && !stretch)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            Bitmap b = new Bitmap(width, height);
            m_ctrl.DrawToBitmap(b, new Rectangle(0, 0, width, height));
            if (stretch)
            {
                GraphicsUnit gp = GraphicsUnit.Point;
                e.Graphics.DrawImage(b, rect, b.GetBounds(ref gp), gp);
                e.HasMorePages = false;
            }
            else
            {
                e.Graphics.DrawImage(b, new Rectangle(40, 65 - printedheight, printwidth, printheight));
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, rect.Width + 100, 40));
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(0, rect.Height + 40, rect.Width + 100, 80));
            }
            if (e.HasMorePages)
            {
                printedheight += rect.Height - 25;
            }
            m_ctrl.Dock = OldDock;
            m_ctrl.Size = new Size(OldSize.Width, OldSize.Height);
        }

        /// <summary>
        /// Draw the control fully to a bitmap & apply it
        /// </summary>
        /// <returns></returns>
        public Bitmap GetBitmap()
        {
            DockStyle OldDock = m_ctrl.Dock;
            m_ctrl.Dock = DockStyle.None;
            Size OldSize = new Size(m_ctrl.Width, m_ctrl.Height);
            m_ctrl.Size = new Size(width, height);
            Bitmap b = new Bitmap(width, height);
            m_ctrl.DrawToBitmap(b, m_ctrl.ClientRectangle);
            m_ctrl.Dock = OldDock;
            m_ctrl.Size = new Size(OldSize.Width, OldSize.Height);
            return b;
        }

        public void CalculateSize()
        {
            m_ctrl.Dock = DockStyle.None;
            m_ctrl.SuspendLayout();
            Size NewSize = m_ctrl.GetPreferredSize(Size.Empty);
            width = NewSize.Width;
            height = NewSize.Height;
            m_ctrl.ResumeLayout();
        }
    }
}
