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
    public class Collision
    {
        public static bool DRCollision(Dot dot1, Shapes.Rectangle rec1)
        {
            if (dot1.CenterX <= rec1.CenterX + rec1.Width / 2 && dot1.CenterX >= rec1.CenterX - rec1.Width / 2) //if dot's x is between rectangle's edge
            {
                if (dot1.CenterY <= rec1.CenterY + rec1.Height / 2 && dot1.CenterY >= rec1.CenterY - rec1.Height / 2) //if dot's y is between rectangle's edge
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool DHCollision(Dot dot1, Hoop hoop1, double distance)
        {
            if (distance <= hoop1.Radius) //if distance is smaller than radius
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RRCollision(Shapes.Rectangle rec1, Shapes.Rectangle rec2)
        {
            if (Math.Abs(rec1.CenterX - rec2.CenterX) <= (rec1.Width + rec2.Width) / 2 && Math.Abs(rec1.CenterY - rec2.CenterY) <= (rec1.Height + rec2.Height) / 2) //if rec1 and rec2 coordinates are between their edges
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RHCollision(Shapes.Rectangle rec1, Hoop hoop1, double distance)
        {
            if (distance <= hoop1.Radius || distance <= rec1.Width || distance <= rec1.Height) //if hoop and rectangle intersect
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HHCollision(Hoop hoop1, Hoop hoop2, double distance)
        {
            if (distance < hoop1.Radius + hoop2.Radius) //if distance is smaller than radius1 + radius2
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DSPCollision(Dot dot1, Sphere sphere1, double distance)
        {
            if (distance <= sphere1.Radius) //if distance is smaller than sphere's radius
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DRPCollision(Dot dot1, RectanglePrism recp1)
        {
            if (dot1.CenterX <= recp1.CenterX + recp1.Width / 2 && dot1.CenterX >= recp1.CenterX - recp1.Width / 2) //if dot's x is between rectangle's edge
            {
                if (dot1.CenterY <= recp1.CenterY + recp1.Height / 2 && dot1.CenterY >= recp1.CenterY - recp1.Height / 2) //if dot's y is between rectangle's edge
                {
                    if (dot1.CenterZ <= recp1.CenterZ + recp1.Depth / 2 && dot1.CenterZ >= recp1.CenterZ - recp1.Depth / 2) //if dot's z is between rectangle's edge
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool DCCollision(Dot dot1, Cylinder cylinder1, double distance)
        {
            if (distance <= cylinder1.Radius && dot1.CenterY <= cylinder1.CenterY + cylinder1.Height / 2 && dot1.CenterY >= cylinder1.CenterY - cylinder1.Height / 2) //if dot and cylinder instersect
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CCCollision(Cylinder cylinder1, Cylinder cylinder2, double distance)
        {
            if (distance < cylinder1.Radius + cylinder2.Radius && Math.Abs(cylinder1.CenterY - cylinder2.CenterY) < (cylinder1.Height + cylinder2.Height) / 2) //if two cylinder intersect
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SPSPCollision(Sphere sphere1, Sphere sphere2, double distance)
        {
            if (distance < sphere1.Radius + sphere2.Radius) // if distance is smaller than radius1 + radius2
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CSPCollision(Cylinder cylinder1, Sphere sphere1, double distance)
        {
            if (distance < cylinder1.Radius + sphere1.Radius && Math.Abs(cylinder1.CenterY - sphere1.CenterY) < sphere1.Radius + cylinder1.Height / 2) //if cylinder and sphere intersect
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SFSPCollision(Sphere sphere1, Surface surface1)
        {
            if (Math.Abs(sphere1.CenterX - surface1.CenterX) < sphere1.Radius + surface1.Width / 2) //if they intersect in x-plane
            {
                if (surface1.CenterY <= sphere1.CenterY + sphere1.Radius && surface1.CenterY >= sphere1.CenterY - sphere1.Radius) //if they intersect in y-plane
                {
                    if (Math.Abs(sphere1.CenterZ - surface1.CenterZ) < sphere1.Radius + surface1.Depth / 2) //if the intersect in z-plane
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool RPSFCollision(RectanglePrism recp1, Surface surface1)
        {
            if (Math.Abs(recp1.CenterX - surface1.CenterX) < (recp1.Width + surface1.Width) / 2) //if they intersect in x-plane
            {
                if (surface1.CenterY <= recp1.CenterY + recp1.Height / 2 && surface1.CenterY >= recp1.CenterY - recp1.Height / 2) //if they intersect in y-plane
                {
                    if (Math.Abs(recp1.CenterZ - surface1.CenterZ) < (recp1.Depth + surface1.Depth) / 2) //if they intersect in z-plane
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool CSFCollision(Cylinder cylinder1, Surface surface1)
        {
            if (Math.Abs(cylinder1.CenterX - surface1.CenterX) < cylinder1.Radius + surface1.Width / 2) //if they intersect in x-plane
            {
                if (surface1.CenterY <= cylinder1.CenterY + cylinder1.Height / 2 && surface1.CenterY >= cylinder1.CenterY - cylinder1.Height / 2) //if they intersect in y-plane
                {
                    if (Math.Abs(surface1.CenterZ - cylinder1.CenterZ) < cylinder1.Radius + surface1.Depth / 2) //if they intersect in z-plane
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool SPRPCollision(Sphere sphere1, RectanglePrism recp1)
        {
            if (Math.Abs(sphere1.CenterX - recp1.CenterX) < sphere1.Radius + recp1.Width / 2) //if they intersect in x-plane
            {
                if (Math.Abs(sphere1.CenterY - recp1.CenterY) < sphere1.Radius + recp1.Height / 2) //if they intersect in y-plane
                {
                    if (Math.Abs(sphere1.CenterZ - recp1.CenterZ) < sphere1.Radius + recp1.Depth / 2) //if they intersect in z-plane
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool RPRPCollision(RectanglePrism recp1, RectanglePrism recp2)
        {
            if (Math.Abs(recp1.CenterX - recp2.CenterX) < (recp1.Width + recp2.Width) / 2) //if they intersect in x-plane
            {
                if (Math.Abs(recp1.CenterY - recp2.CenterY) < (recp1.Height + recp2.Height) / 2) //if they intersect in y-plane
                {
                    if (Math.Abs(recp1.CenterZ - recp2.CenterZ) < (recp1.Depth + recp2.Depth) / 2) //if they intersect in z-plane
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
