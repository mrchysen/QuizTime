using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Пространство с новыми Графическими элементами \\
namespace NewGUIElements
{
    /// <summary>
    /// Класс панели с градиентным светом
    /// </summary>
    class GradientPanel : Panel
    {
        // Св-ва \\
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        public float Angle { get; set; }

        // Методы \\
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, ColorTop, ColorBottom, Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb,ClientRectangle);
            base.OnPaint(e);
        } 
    }

    /// <summary>
    /// Класс заметки с градиентным светом
    /// </summary>
    class GradientLabel : Label
    {
        // Св-ва \\
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        // Методы \\
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, ColorTop, ColorBottom, 45);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, ClientRectangle);
            base.OnPaint(e);
        }
    }
}
