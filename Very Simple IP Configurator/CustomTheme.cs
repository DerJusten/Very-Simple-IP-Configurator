using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Very_Simple_IP_Configurator
{
    class CustomTheme
    {
        public static bool Darkmode { get; set; } = false;

        public static Color GetLabelColor()
        {
            if (Darkmode)
                return Color.White;
            else
                return Color.Black;
        }
        public static Color GetLabelErrorColor()
        {
            if (Darkmode)
                return Color.Red;
            else
                return Color.Red;
        }

        public static Color GetLabelWarningColor()
        {
            if (Darkmode)
                return Color.Orange;
            else
                return Color.Orange;
        }
        public static Color GetLabelNoErrorColor()
        {
            if (Darkmode)
                return Color.LightGreen;
            else
                return Color.Green;
        }
        public static Color GetTextBoxBackColor()
        {
            if (Darkmode)
                return Color.FromArgb(52, 52, 52);
            else
                return Color.White;
        }
        public static Color GetTextBoxBackColorError()
        {
            if (Darkmode)
                return Color.Brown;
            else
                return Color.LightCoral;
        }
        public static Color GetSeperatorBackColor()
        {
            if (Darkmode)
                return Color.FromArgb(40, 40, 40);
            else
                return Color.Transparent;
        }
        public static Color GetSeperatorForeColor()
        {
            if (Darkmode)
                return Color.Gray;
            else
                return SystemColors.ControlDark;
        }
        public static Color GetBackgroundColor()
        {
            if (Darkmode)
                return Color.FromArgb(52, 52, 52);
            else
                return Color.White;
        }
        public static Color GetHoverColor()
        {
            if (Darkmode)
                return Color.FromArgb(46, 46, 46);
            else
                return Color.Gray;
        }
        public static Color GetMenuStripColor()
        {
            if (Darkmode)
                return Color.FromArgb(40, 40, 40);
            else
                return Color.WhiteSmoke;
        }
        public static Color GetBorderColor()
        {
            if (Darkmode)
                return Color.FromArgb(46, 46, 46);
            else
                return Color.WhiteSmoke;
        }
        public static Color GetBackColor()
        {
            if (Darkmode)
                return Color.FromArgb(52, 52, 52);
            else
                return Color.White;
        }

        public static Color GetForeColor()
        {
            if (Darkmode)
                return Color.White;
            else
                return Color.Black;
        }



        public static void AdjustThemeToForm(Control ctrl)
        {
            List<Control> ctrlList = new List<Control>();
            GetAllControls(ctrl, ctrlList);
            Color foreClr, backClr, msColor;

            foreClr = GetForeColor();
            backClr = GetBackColor();
            msColor = GetMenuStripColor();

            // ctrl.BackColor = backClr;
            foreach (Control contrl in ctrlList)
            {
                if (contrl is MenuStrip)
                {
                    foreach (ToolStripMenuItem item in ((MenuStrip)contrl).Items)
                    {
                        item.BackColor = msColor;
                        item.ForeColor = foreClr;
                        foreach (ToolStripItem dropdown in item.DropDownItems)
                        {
                            dropdown.BackColor = msColor;
                            dropdown.ForeColor = foreClr;
                        }
                    }
                    contrl.BackColor = msColor;
                }
                else
                {
                    contrl.BackColor = backClr;
                }

                contrl.ForeColor = foreClr;
            }
            ctrl.BackColor = backClr;
        }
        public static void SwitchDarkMode(Control ctrl)
        {
            Darkmode = !Darkmode;
            AdjustThemeToForm(ctrl);

        }


        private static void GetAllControls(Control container, List<Control> ctrlList)
        {
            foreach (Control c in container.Controls)
            {
                ctrlList.Add(c);
                GetAllControls(c, ctrlList);

            }
        }

        //https://stackoverflow.com/questions/15926377/change-the-backcolor-of-the-toolstripseparator-control
        public class CustomToolStripSeperator : ToolStripSeparator
        {
            public CustomToolStripSeperator()
            {
                this.Paint += CustomToolStripSeperator_Paint;
            }
            private void CustomToolStripSeperator_Paint(object sender, PaintEventArgs e)
            {
                // Get the separator's width and height.
                ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
                int width = toolStripSeparator.Width;
                int height = toolStripSeparator.Height;

                // Choose the colors for drawing.
                // I've used Color.White as the foreColor.

                Color foreColor = GetSeperatorForeColor();
                // Color.Teal as the backColor.
                Color backColor = GetSeperatorBackColor();

                // Fill the background.
                e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);

                // Draw the line.

                e.Graphics.DrawLine(new Pen(foreColor), 4, height / 2, width - 4, height / 2);
            }
        }
        //MenuStrip
        public class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
            //https://stackoverflow.com/questions/26605368/change-the-color-of-the-arrow-near-the-menuitem-in-c-sharp
            protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
            {
                var tsMenuItem = e.Item as ToolStripMenuItem;
                if (tsMenuItem != null && Darkmode)
                    e.ArrowColor = Color.White;
                base.OnRenderArrow(e);
            }


        }
        public class MyColors : ProfessionalColorTable
        {

            private Color GetColorItemSelected()
            {
                if (Darkmode == true)
                    return Color.Gray;
                else
                    return Color.AliceBlue;
            }
            private Color GetColorPressed()
            {
                if (Darkmode == true)
                    return Color.Gray;
                else
                    return Color.AliceBlue;
            }


            public override Color MenuItemSelected
            {

                get { return GetColorItemSelected(); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return GetColorItemSelected(); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return GetColorItemSelected(); }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return GetColorPressed(); ; }
            }
            public override Color MenuItemPressedGradientMiddle
            {
                get { return GetColorPressed(); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return GetColorPressed(); }
            }
            //public override Color MenuItemBorder
            //{
            //    get { return GetColorPressed(); }
            //}
            //public override Color MenuBorder
            //{
            //    get { return GetColorPressed(); }
            //}
        }
    }
}
