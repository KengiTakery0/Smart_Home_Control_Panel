using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SmartHomeHub.Controls
{
    public class ToggleButtons : CheckBox
    {
        private Color onBackColor = Color.MediumPurple;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.DarkGray;
        private Color offToggleColor = Color.WhiteSmoke;
        private bool solydStyle = true;

        [Category("Toggle Colors")]
        public Color OnBackColor { get { return onBackColor; } set { onBackColor = value; this.Invalidate(); } }
        [Category("Toggle Colors")]
        public Color OnToggleColor { get { return onToggleColor; } set { onToggleColor = value; this.Invalidate(); } }
        [Category("Toggle Colors")]
        public Color OffBackColor { get { return offBackColor; } set { offBackColor = value; this.Invalidate(); } }
        [Category("Toggle Colors")]
        public Color OffToggleColor { get { return offToggleColor; } set { offToggleColor = value; this.Invalidate(); } }
        [Category("Toggle Colors")]
        [DefaultValue(true)]
        public bool SolydStyle { get { return solydStyle; } set { solydStyle = value; this.Invalidate(); } }
      
        public ToggleButtons()
        {
            this.MinimumSize = new Size(45, 22);

        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90,180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)//On
            {
                if (solydStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(onBackColor,2),GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
                
            }
            else//Off
            {
                if (solydStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(OffBackColor,2),GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
