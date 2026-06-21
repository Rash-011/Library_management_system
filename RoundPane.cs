using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms; // Added this to recognize 'Panel' and 'PaintEventArgs'

namespace Library_management_system
{
    // Added ": Panel" so this class inherits all Panel properties
    public class RoundedPanel : Panel
    {
        // Property to control the roundness of the corners
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public int CornerRadius { get; set; } = 30;

        protected override void OnPaint(PaintEventArgs e)
        {
            // If the panel is too small for the radius, do nothing to avoid a crash
            if (this.Width < 5 || this.Height < 5) return;

            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Create the rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            int r = CornerRadius;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // Define the arcs for the four corners
            path.AddArc(rect.X, rect.Y, r, r, 180, 90); // Top-left
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90); // Top-right
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90); // Bottom-left
            path.CloseFigure();

            // Apply the path to the panel's Region (this clips the background)
            this.Region = new Region(path);

            // Draw a border using the panel's background color or a specific color
            using (Pen pen = new Pen(this.BackColor, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}

