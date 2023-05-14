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
    public class Distance
    {
        public static double CalculateXYDistance(Shape shape1, Shape shape2)
        {
            return Math.Sqrt(Math.Pow(shape1.CenterX - shape2.CenterX, 2) + Math.Pow(shape1.CenterY - shape2.CenterY, 2));
        }

        public static double CalculateXZDistance(Shape shape1, Shape shape2) 
        {
            return Math.Sqrt(Math.Pow(shape1.CenterX - shape2.CenterX, 2) + Math.Pow(shape1.CenterZ - shape2.CenterZ, 2));
        }

        public static double CalculateXYZDictance(Shape shape1, Shape shape2)
        {
            return Math.Sqrt(Math.Pow(shape1.CenterX - shape2.CenterX, 2) + Math.Pow(shape1.CenterY - shape2.CenterY, 2) + Math.Pow(shape1.CenterZ - shape2.CenterZ, 2));
        }
    }
}
