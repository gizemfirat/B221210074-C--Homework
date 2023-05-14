/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          PROGRAMLAMAYA GİRİŞİ DERSİ
**	
**				ÖDEV NUMARASI…...: Proje1
**				ÖĞRENCİ ADI...............: ZEYNEP GİZEM FIRAT
**				ÖĞRENCİ NUMARASI.: B221210074
**				DERS GRUBU…………: 1C
****************************************************************************/

namespace Project1_B221210074_1C.Shapes
{
    public class DrawShape
    {
        public static void DrawDot(Panel choosePanel, Dot dot1)
        {
            Graphics g = choosePanel.CreateGraphics();
            g.FillEllipse(Brushes.BlueViolet, dot1.CenterX, dot1.CenterY, 5, 5);
            g.Dispose();
        }

        public static void DrawRectangle(Panel choosePanel, int centerX, int centerY, int width, int height)
        {
            Graphics g = choosePanel.CreateGraphics();
            g.DrawRectangle(Pens.Black, centerX - width / 2, centerY - height / 2, width, height);
            g.Dispose();
        }

        public static void DrawHoop(Panel choosePanel, Hoop hoop1) 
        {
            Graphics g = choosePanel.CreateGraphics();
            g.DrawEllipse(Pens.Red, hoop1.CenterX - hoop1.Radius, hoop1.CenterY - hoop1.Radius, hoop1.Radius * 2, hoop1.Radius * 2);
            g.Dispose();
        }

        public static void DrawSphere(Panel choosenPanel, Sphere sphere1)
        {
            Graphics g = choosenPanel.CreateGraphics();
            g.DrawEllipse(Pens.Red, sphere1.CenterX - sphere1.Radius, sphere1.CenterY - sphere1.Radius, sphere1.Radius * 2, sphere1.Radius * 2);
            g.Dispose();

            Graphics g1 = choosenPanel.CreateGraphics();
            g1.DrawEllipse(Pens.Red, sphere1.CenterX - sphere1.Radius, sphere1.CenterY - 10, sphere1.Radius * 2, 20);
            g1.Dispose();
        }

        public static void DrawRectanglePrism(Panel choosenPanel, RectanglePrism recp1)
        {
            Graphics g = choosenPanel.CreateGraphics();
            g.DrawRectangle(Pens.CadetBlue, recp1.CenterX - 3 * (recp1.Width / 2), recp1.CenterY - 3 * (recp1.Height / 2), recp1.Width, recp1.Height);
            g.Dispose();

            Graphics g1 = choosenPanel.CreateGraphics();
            g1.DrawRectangle(Pens.CadetBlue, recp1.CenterX - recp1.Width / 4, recp1.CenterY - recp1.Height / 4, recp1.Width, recp1.Height);
            g1.Dispose();

            Graphics g2 = choosenPanel.CreateGraphics();
            g2.DrawLine(Pens.CadetBlue, recp1.CenterX - 3 * (recp1.Width / 2), recp1.CenterY - 3 * (recp1.Height / 2), recp1.CenterX - recp1.Width / 4, recp1.CenterY - recp1.Height / 4);
            g2.Dispose();

            Graphics g3 = choosenPanel.CreateGraphics();
            g3.DrawLine(Pens.CadetBlue, recp1.CenterX - 3 * (recp1.Width / 2), recp1.CenterY - recp1.Height / 2, recp1.CenterX - recp1.Width / 4, recp1.CenterY + 3 * (recp1.Height / 4));
            g3.Dispose();

            Graphics g4 = choosenPanel.CreateGraphics();
            g4.DrawLine(Pens.CadetBlue, recp1.CenterX - recp1.Width / 2, recp1.CenterY - 3 * (recp1.Height / 2), recp1.CenterX + 3 * (recp1.Width / 4), recp1.CenterY - recp1.Height / 4);
            g4.Dispose();

            Graphics g5 = choosenPanel.CreateGraphics();
            g5.DrawLine(Pens.CadetBlue, recp1.CenterX + recp1.Width / 4, recp1.CenterY + recp1.Height / 4, recp1.CenterX + 3 * (recp1.Width / 4), recp1.CenterY + 3 * (recp1.Height / 4));
            g5.Dispose();
        }

        public static void DrawCylinder(Panel choosenPanel, Cylinder cylinder1)
        {
            Graphics g = choosenPanel.CreateGraphics();
            g.DrawEllipse(Pens.BlueViolet, cylinder1.CenterX - cylinder1.Radius, cylinder1.CenterY - cylinder1.Height / 2 - 10, cylinder1.Radius * 2, 20);
            g.Dispose();

            Graphics g1 = choosenPanel.CreateGraphics();
            g1.DrawLine(Pens.BlueViolet, cylinder1.CenterX - cylinder1.Radius, cylinder1.CenterY - cylinder1.Height / 2, cylinder1.CenterX - cylinder1.Radius, cylinder1.CenterY + cylinder1.Height / 2);
            g1.Dispose();

            Graphics g2 = choosenPanel.CreateGraphics();
            g2.DrawLine(Pens.BlueViolet, cylinder1.CenterX + cylinder1.Radius, cylinder1.CenterY - cylinder1.Height / 2, cylinder1.CenterX + cylinder1.Radius, cylinder1.CenterY + cylinder1.Height / 2);
            g2.Dispose();

            Graphics g3 = choosenPanel.CreateGraphics();
            g3.DrawEllipse(Pens.BlueViolet, cylinder1.CenterX - cylinder1.Radius, cylinder1.CenterY + cylinder1.Height / 2 - 10, cylinder1.Radius * 2, 20);
            g3.Dispose();
        }

        public static void DrawSurface(Panel choosenPanel, Surface surface1)
        {
            Graphics g = choosenPanel.CreateGraphics();
            g.DrawLine(Pens.DarkGreen, surface1.CenterX - surface1.Width / 2, surface1.CenterY, surface1.CenterX + surface1.Width / 2, surface1.CenterY);
            g.Dispose();

            Graphics g1 = choosenPanel.CreateGraphics();
            g1.DrawLine(Pens.DarkGreen, surface1.CenterX - surface1.Width, surface1.CenterY - surface1.Depth / 2, surface1.CenterX, surface1.CenterY - surface1.Depth / 2);
            g1.Dispose();

            Graphics g2 = choosenPanel.CreateGraphics();
            g2.DrawLine(Pens.DarkGreen, surface1.CenterX - surface1.Width, surface1.CenterY - surface1.Depth / 2, surface1.CenterX - surface1.Width / 2, surface1.CenterY);
            g2.Dispose();

            Graphics g3 = choosenPanel.CreateGraphics();
            g3.DrawLine(Pens.Magenta, surface1.CenterX, surface1.CenterY - surface1.Depth / 2, surface1.CenterX + surface1.Width / 2, surface1.CenterY);
            g3.Dispose();
        }

        public static void DrawLine(Panel choosenPanel, Surface surface1)
        {
            Graphics g = choosenPanel.CreateGraphics();
            g.DrawLine(Pens.DarkGreen, surface1.CenterX - surface1.Width / 2, surface1.CenterY, surface1.CenterX + surface1.Width / 2, surface1.CenterY);
            g.Dispose();
        }
    }
}
