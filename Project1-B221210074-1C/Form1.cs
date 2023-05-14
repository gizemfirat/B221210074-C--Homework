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

using Project1_B221210074_1C.Shapes;

namespace Project1_B221210074_1C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetElement()
        {
            drawShapes.Invalidate();
            drawShapes.Update();
            pnl3dShape.Invalidate();
            pnl3dShape.Update();
            collisionResult.Text = string.Empty;

            foreach(Control control in pnlShape1.Controls) //for every control in pnlShape1
            {
                if (control is NumericUpDown) //if control is numericUpDown
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Enabled = true;
                    numericUpDown.Value = 0M;
                }
            }

            foreach (Control control in pnlShape2.Controls) //for every control in pnlShape2
            {
                if (control is NumericUpDown) //if control is numericUpDown
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Enabled = true;
                    numericUpDown.Value = 0M;
                }
            }
        }

        private void DR_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 1;
            firstShapeTag.Text = "First Shape : Dot(X,Y)";
            secondShapeTag.Text = "Second Shape : Rectangle(X,Y,Width,Height)";

            EnableValue.EnableDot1(shape1Z, shape1Rad, shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableRectangle(shape2Z, shape2Rad, shape2Dep);
        }

        private void DH_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 2;
            firstShapeTag.Text = "First Shape : Dot(X,Y)";
            secondShapeTag.Text = "Second Shape : Hoop(X,Y,Radius)";

            EnableValue.EnableDot1(shape1Z, shape1Rad, shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableHoop(shape2Z, shape2Wid, shape2He, shape2Dep);
        }

        private void RR_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 3;
            firstShapeTag.Text = "First Shape : Rectangle(X,Y,Width,Height)";
            secondShapeTag.Text = "Second Shape : Rectangle(X,Y,Width,Height)";

            EnableValue.EnableRectangle(shape1Z, shape1Rad, shape1Dep);
            EnableValue.EnableRectangle(shape2Z, shape2Rad, shape2Dep);
        }

        private void RH_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 4;
            firstShapeTag.Text = "First Shape : Rectangle(X,Y,Width,Height)";
            secondShapeTag.Text = "Second Shape : Hoop(X,Y,Radius)";

            EnableValue.EnableRectangle(shape1Z, shape1Rad, shape1Dep);
            EnableValue.EnableHoop(shape2Z, shape2Wid, shape2He, shape2Dep);
        }

        private void HH_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 5;
            firstShapeTag.Text = "First Shape : Hoop(X,Y,Radius)";
            secondShapeTag.Text = "Second Shape : Hoop(X,Y,Radius)";

            EnableValue.EnableHoop(shape1Z, shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableHoop(shape2Z, shape2Wid, shape2He, shape2Dep);
        }

        private void DSP_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 6;
            firstShapeTag.Text = "First Shape : Dot(X,Y,Z)";
            secondShapeTag.Text = "Second Shape : Sphere(X,Y,Z,Radius)";

            EnableValue.EnableDot2(shape1Rad, shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableSphere(shape2Wid, shape2He, shape2Dep);
        }

        private void DRP_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 7;
            firstShapeTag.Text = "First Shape : Dot(X,Y,Z)";
            secondShapeTag.Text = "Second Shape : Rec.Pris.(X,Y,Z,Width,Height,Depth)";

            EnableValue.EnableDot2(shape1Rad, shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableRectanglePrism(shape2Rad);
        }

        private void DC_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 8;
            firstShapeTag.Text = "First Shape : Dot(X,Y,Z)";
            secondShapeTag.Text = "Second Shape : Cylinder(X,Y,Z,Radius, Height)";

            EnableValue.EnableDot2(shape1Rad, shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableCylinder(shape2Wid, shape2Dep);
        }

        private void CC_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 9;
            firstShapeTag.Text = "First Shape : Cylinder(X,Y,Z,Radius,Height)";
            secondShapeTag.Text = "Second Shape : Cylinder(X,Y,Z,Radius,Height)";

            EnableValue.EnableCylinder(shape1Wid, shape1Dep);
            EnableValue.EnableCylinder(shape2Wid, shape2Dep);
        }

        private void SPSP_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 10;
            firstShapeTag.Text = "First Shape : Sphere(X,Y,Z,Radius)";
            secondShapeTag.Text = "Second Shape : Sphere(X,Y,Z,Radius)";

            EnableValue.EnableSphere(shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableSphere(shape2Wid, shape2He, shape2Dep);
        }

        private void SPC_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 11;
            firstShapeTag.Text = "First Shape : Sphere(X,Y,Z,Radius)";
            secondShapeTag.Text = "Second Shape : Cylinder(X,Y,Z,Radius,Height)";

            EnableValue.EnableSphere(shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableCylinder(shape2Wid, shape2Dep);
        }

        private void SFSP_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 12;
            firstShapeTag.Text = "First Shape : Surface(X,Y,Z,Width,Depth)";
            secondShapeTag.Text = "Second Shape : Sphere(X,Y,Z,Radius)";

            EnableValue.EnableSurface(shape1Rad, shape1He);
            EnableValue.EnableSphere(shape2Wid, shape2He, shape2Dep);
        }

        private void SFRP_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 13;
            firstShapeTag.Text = "First Shape : Surface(X,Y,Z,Width,Depth)";
            secondShapeTag.Text = "Second Shape : Rec.Pris.(X,Y,Z,Width,Height,Depth)";

            EnableValue.EnableSurface(shape1Rad, shape1He);
            EnableValue.EnableRectanglePrism(shape2Rad);
        }

        private void SFC_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 14;
            firstShapeTag.Text = "First Shape : Surface(X,Y,Z,Width,Depth)";
            secondShapeTag.Text = "Second Shape : Cylinder(X,Y,Z,Radius,Height)";

            EnableValue.EnableSurface(shape1Rad, shape1He);
            EnableValue.EnableCylinder(shape2Wid, shape2Dep);
        }

        private void SPRP_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 15;
            firstShapeTag.Text = "First Shape : Sphere(X,Y,Z,Width,Depth)";
            secondShapeTag.Text = "Second Shape : Rec.Pris.(X,Y,Z,Width,Height,Depth)";

            EnableValue.EnableSphere(shape1Wid, shape1He, shape1Dep);
            EnableValue.EnableRectanglePrism(shape2Rad);
        }

        private void RPRP_Click(object sender, EventArgs e)
        {
            ResetElement();
            controlChoice.Value = 16;
            firstShapeTag.Text = "First Shape : Rec.Pris.(X,Y,Z,Width,Height,Depth)";
            secondShapeTag.Text = "Second Shape : Rec.Pris.(X,Y,Z,Width,Height,Depth)";

            EnableValue.EnableRectanglePrism(shape1Rad);
            EnableValue.EnableRectanglePrism(shape2Rad);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            collisionResult.Controls.Clear();
            drawShapes.Invalidate();
            drawShapes.Update();
            pnl3dShape.Invalidate();
            pnl3dShape.Update();

            if (controlChoice.Value == 1) //if user push 'Dot-Rectangle Collision' button
            {
                var dot1 = new Dot((int)shape1X.Value, (int)shape1Y.Value);
                var rec1 = new Shapes.Rectangle((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Wid.Value, (int)shape2He.Value);

                var result = Collision.DRCollision(dot1, rec1);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);

                DrawShape.DrawDot(drawShapes, dot1);
                DrawShape.DrawRectangle(drawShapes, rec1.CenterX, rec1.CenterY, rec1.Width, rec1.Height);
            }

            else if (controlChoice.Value == 2) //if user push 'Dot-Hoop Collision' button
            {
                var dot1 = new Dot((int)shape1X.Value, (int)shape1Y.Value);
                var hoop1 = new Hoop((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Rad.Value);

                var distance = Distance.CalculateXYDistance(dot1, hoop1);
                var result = Collision.DHCollision(dot1, hoop1, distance);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawDot(drawShapes, dot1);
                DrawShape.DrawHoop(drawShapes, hoop1);
            }
            else if (controlChoice.Value == 3) //if user push 'Rectangle-Rectangle Collision' button
            {
                var rec1 = new Shapes.Rectangle((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Wid.Value, (int)shape1He.Value);
                var rec2 = new Shapes.Rectangle((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Wid.Value, (int)shape2He.Value);

                var result = Collision.RRCollision(rec1, rec2);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawRectangle(drawShapes, rec1.CenterX, rec1.CenterY, rec1.Width, rec1.Height);
                DrawShape.DrawRectangle(drawShapes, rec2.CenterX, rec2.CenterY, rec2.Width, rec2.Height);

            }
            else if (controlChoice.Value == 4) //if user push 'Rectangle-Hoop Collision' button
            {
                var rec1 = new Shapes.Rectangle((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Wid.Value, (int)shape1He.Value);
                var hoop1 = new Hoop((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Rad.Value);

                var distance = Distance.CalculateXYDistance(hoop1, rec1);
                var result = Collision.RHCollision(rec1, hoop1, distance);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawRectangle(drawShapes, rec1.CenterX, rec1.CenterY, rec1.Width, rec1.Height);
                DrawShape.DrawHoop(drawShapes, hoop1);
            }
            else if (controlChoice.Value == 5) //if user push 'Hoop-Hoop Collision' button
            {
                var hoop1 = new Hoop((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Rad.Value);
                var hoop2 = new Hoop((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Rad.Value);

                var distance = Distance.CalculateXYDistance(hoop1, hoop2);
                var result = Collision.HHCollision(hoop1, hoop2, distance);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawHoop (drawShapes, hoop1);
                DrawShape.DrawHoop(drawShapes, hoop2);
            }
            else if (controlChoice.Value == 6) //if user push 'Dot-Sphere Collision' button
            {
                var dot1 = new Dot((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value);
                var sphere1 = new Sphere((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Rad.Value);

                var distance = Distance.CalculateXYZDictance(dot1, sphere1);
                var result = Collision.DSPCollision(dot1, sphere1, distance);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawDot(drawShapes, dot1);
                DrawShape.DrawSphere(drawShapes, sphere1);
            }
            else if (controlChoice.Value == 7) //if user push 'Dot-Rectangle Prism Collision' button
            {
                var dot1 = new Dot((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value);
                var recp1 = new RectanglePrism((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Wid.Value, (int)shape2He.Value, (int)shape2Dep.Value);

                var result = Collision.DRPCollision(dot1, recp1);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawDot(drawShapes, dot1);
                DrawShape.DrawRectanglePrism(pnl3dShape, recp1);
                DrawShape.DrawRectangle(drawShapes, recp1.CenterX, recp1.CenterY, recp1.Width, recp1.Height);
            }
            else if (controlChoice.Value == 8) //if user push 'Dot-Cylinder Collision' button
            {
                var dot1 = new Dot((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value);
                var cylinder1 = new Cylinder((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Rad.Value, (int)shape2He.Value);

                var distance = Distance.CalculateXZDistance(dot1, cylinder1);
                var result = Collision.DCCollision(dot1, cylinder1, distance);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawDot(drawShapes, dot1);
                DrawShape.DrawCylinder(drawShapes, cylinder1);
            }
            else if (controlChoice.Value == 9) //if user push 'Cylinder-Cylinder Collision' button
            {
                var cylinder1 = new Cylinder((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value, (int)shape1Rad.Value, (int)shape1He.Value);
                var cylinder2 = new Cylinder((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Rad.Value, (int)shape2He.Value);

                var distance = Distance.CalculateXZDistance(cylinder1, cylinder2);
                var result = Collision.CCCollision(cylinder1, cylinder2, distance);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawCylinder(drawShapes, cylinder1);
                DrawShape.DrawCylinder(drawShapes, cylinder2);

            }
            else if (controlChoice.Value == 10) //if user push 'Sphere-Sphere Collision' button
            {
                var sphere1 = new Sphere((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value, (int)shape1Rad.Value);
                var sphere2 = new Sphere((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Rad.Value);

                var distance = Distance.CalculateXYZDictance(sphere1, sphere2);
                var result = Collision.SPSPCollision(sphere1, sphere2, distance);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawSphere(drawShapes, sphere1);
                DrawShape.DrawSphere(drawShapes, sphere2);
            }
            else if (controlChoice.Value == 11) //if user push 'Sphere-Cylinder Collision' button
            {
                var sphere1 = new Sphere((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value, (int)shape1Rad.Value);
                var cylinder1 = new Cylinder((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Rad.Value, (int)shape2He.Value);

                var distance = Distance.CalculateXZDistance(sphere1, cylinder1);
                var result = Collision.CSPCollision(cylinder1, sphere1, distance);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawSphere(drawShapes, sphere1);
                DrawShape.DrawCylinder(drawShapes, cylinder1);
            }
            else if (controlChoice.Value == 12) //if user push 'Surface-Sphere Collision' button
            {
                var surface1 = new Surface((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value, (int)shape1Wid.Value, (int)shape1Dep.Value);
                var sphere1 = new Sphere((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Rad.Value);

                var result = Collision.SFSPCollision(sphere1, surface1);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawLine(drawShapes, surface1);
                DrawShape.DrawSphere(drawShapes, sphere1);
                DrawShape.DrawSurface(pnl3dShape, surface1);
            }
            else if (controlChoice.Value == 13) //if user push 'Surface-Rectangle Prism Collision' button
            {
                var surface1 = new Surface((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value, (int)shape1Wid.Value, (int)shape1Dep.Value);
                var recp1 = new RectanglePrism((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Wid.Value, (int)shape2He.Value, (int)shape2Dep.Value);

                var result = Collision.RPSFCollision(recp1, surface1);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawLine(drawShapes, surface1); 
                DrawShape.DrawSurface (pnl3dShape, surface1);
                DrawShape.DrawRectanglePrism(pnl3dShape, recp1);
                DrawShape.DrawRectangle(drawShapes, recp1.CenterX, recp1.CenterY, recp1.Width, recp1.Height);
            }
            else if (controlChoice.Value == 14) //if user push 'Surface-Cylinder Collision' button
            {
                var surface1 = new Surface((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value, (int)shape1Wid.Value, (int)shape1Dep.Value);
                var cylinder1 = new Cylinder((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Rad.Value, (int)shape2He.Value);

                var result = Collision.CSFCollision(cylinder1, surface1);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawLine(drawShapes, surface1);
                DrawShape.DrawSurface(pnl3dShape, surface1);
                DrawShape.DrawCylinder(drawShapes, cylinder1);
            }
            else if (controlChoice.Value == 15) //if user push 'Sphere-Rectangle Prism Collision' button
            {
                var sphere1 = new Sphere((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value, (int)shape1Rad.Value);
                var recp1 = new RectanglePrism((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Wid.Value, (int)shape2He.Value, (int)shape2Dep.Value);

                var result = Collision.SPRPCollision(sphere1, recp1);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawSphere(drawShapes, sphere1);
                DrawShape.DrawRectangle(drawShapes, recp1.CenterX, recp1.CenterY, recp1.Width, recp1.Height);
                DrawShape.DrawRectanglePrism(pnl3dShape, recp1);
            }
            else if (controlChoice.Value == 16) //if user push 'Rectangle Prism-Rectangle Prism Collision' button
            {
                var recp1 = new RectanglePrism((int)shape1X.Value, (int)shape1Y.Value, (int)shape1Z.Value, (int)shape1Wid.Value, (int)shape1He.Value, (int)shape1Dep.Value);
                var recp2 = new RectanglePrism((int)shape2X.Value, (int)shape2Y.Value, (int)shape2Z.Value, (int)shape2Wid.Value, (int)shape2He.Value, (int)shape2Dep.Value);

                var result = Collision.RPRPCollision(recp1, recp2);
                collisionResult.Visible = true;
                collisionResult.Text = Result.ShowResult(result);
                DrawShape.DrawRectangle(drawShapes, recp1.CenterX, recp1.CenterY, recp1.Width, recp1.Height);
                DrawShape.DrawRectanglePrism(pnl3dShape, recp1);
                DrawShape.DrawRectangle(drawShapes, recp2.CenterX, recp2.CenterY, recp2.Width, recp2.Height);
                DrawShape.DrawRectanglePrism(pnl3dShape, recp2);
            }

        }
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculateButton.PerformClick();
        }
    }
}