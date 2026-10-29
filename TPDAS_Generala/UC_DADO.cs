using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPDAS_Generala
{
    // Dado dibujado a mano: muestra los puntos del valor (0 = sin tirar)
    // y se resalta cuando el jugador lo retiene.
    public partial class UC_DADO : UserControl
    {
        private static readonly Color ColorCara = Color.White;
        private static readonly Color ColorBorde = Color.FromArgb(120, 144, 156);
        private static readonly Color ColorPunto = Color.FromArgb(38, 50, 56);
        private static readonly Color ColorRetenido = Color.FromArgb(255, 193, 7);
        private static readonly Color ColorCaraRetenido = Color.FromArgb(255, 248, 225);
        private static readonly Color ColorSinTirar = Color.FromArgb(236, 239, 241);

        public UC_DADO()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
        }

        private void UC_DADO_Load(object sender, EventArgs e)
        {

        }

        private int numero;
        public int Numero
        {
            get { return numero; }
            set
            {
                numero = value;
                Invalidate();
            }
        }

        private bool retenido;
        [DefaultValue(false)]
        public bool Retenido
        {
            get { return retenido; }
            set
            {
                retenido = value;
                Invalidate();
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int lado = Math.Min(Width, Height) - 8;
            Rectangle cara = new Rectangle((Width - lado) / 2, (Height - lado) / 2, lado, lado);
            int radio = lado / 5;

            using (GraphicsPath forma = Redondeado(cara, radio))
            {
                // sombra
                using (GraphicsPath sombra = Redondeado(new Rectangle(cara.X + 3, cara.Y + 4, cara.Width, cara.Height), radio))
                using (SolidBrush pincelSombra = new SolidBrush(Color.FromArgb(50, 0, 0, 0)))
                {
                    g.FillPath(pincelSombra, sombra);
                }

                Color fondo = numero == 0 ? ColorSinTirar : (retenido ? ColorCaraRetenido : ColorCara);
                using (SolidBrush pincel = new SolidBrush(fondo))
                {
                    g.FillPath(pincel, forma);
                }

                using (Pen borde = new Pen(retenido ? ColorRetenido : ColorBorde, retenido ? 4 : 2))
                {
                    g.DrawPath(borde, forma);
                }
            }

            if (numero >= 1 && numero <= 6)
            {
                DibujarPuntos(g, cara);
            }
            else
            {
                using (Font fuente = new Font("Segoe UI", lado / 3f, FontStyle.Bold, GraphicsUnit.Pixel))
                using (SolidBrush pincel = new SolidBrush(ColorBorde))
                {
                    StringFormat centro = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString("?", fuente, pincel, cara, centro);
                }
            }

            if (retenido)
            {
                using (Font fuente = new Font("Segoe UI", 8f, FontStyle.Bold))
                using (SolidBrush pincel = new SolidBrush(Color.FromArgb(130, 90, 0)))
                {
                    StringFormat abajo = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Far };
                    g.DrawString("RETENIDO", fuente, pincel, new RectangleF(cara.X, cara.Y, cara.Width, cara.Height - 2), abajo);
                }
            }

            if (!Enabled)
            {
                using (SolidBrush velo = new SolidBrush(Color.FromArgb(90, 255, 255, 255)))
                {
                    g.FillRectangle(velo, ClientRectangle);
                }
            }
        }

        private void DibujarPuntos(Graphics g, Rectangle cara)
        {
            float paso = cara.Width / 4f;
            float diametro = cara.Width / 6f;
            float izq = cara.X + paso, cen = cara.X + paso * 2, der = cara.X + paso * 3;
            float arr = cara.Y + paso, med = cara.Y + paso * 2, aba = cara.Y + paso * 3;

            List<PointF> puntos = new List<PointF>();
            switch (numero)
            {
                case 1:
                    puntos.Add(new PointF(cen, med));
                    break;
                case 2:
                    puntos.Add(new PointF(izq, arr)); puntos.Add(new PointF(der, aba));
                    break;
                case 3:
                    puntos.Add(new PointF(izq, arr)); puntos.Add(new PointF(cen, med)); puntos.Add(new PointF(der, aba));
                    break;
                case 4:
                    puntos.Add(new PointF(izq, arr)); puntos.Add(new PointF(der, arr));
                    puntos.Add(new PointF(izq, aba)); puntos.Add(new PointF(der, aba));
                    break;
                case 5:
                    puntos.Add(new PointF(izq, arr)); puntos.Add(new PointF(der, arr)); puntos.Add(new PointF(cen, med));
                    puntos.Add(new PointF(izq, aba)); puntos.Add(new PointF(der, aba));
                    break;
                case 6:
                    puntos.Add(new PointF(izq, arr)); puntos.Add(new PointF(der, arr));
                    puntos.Add(new PointF(izq, med)); puntos.Add(new PointF(der, med));
                    puntos.Add(new PointF(izq, aba)); puntos.Add(new PointF(der, aba));
                    break;
            }

            using (SolidBrush pincel = new SolidBrush(numero == 1 ? Color.FromArgb(198, 40, 40) : ColorPunto))
            {
                foreach (PointF p in puntos)
                {
                    g.FillEllipse(pincel, p.X - diametro / 2, p.Y - diametro / 2, diametro, diametro);
                }
            }
        }

        private static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            int d = radio * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
