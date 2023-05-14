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
    public class Cylinder : Shape
    {
        public int Radius { get; set; }
        public int Height { get; set; }

        public Cylinder()
        {

        }

        public Cylinder(int centerX, int centerY, int centerZ, int radius, int height)
        {
            Radius = radius;
            Height = height;
            CenterX = centerX;
            CenterY = centerY;
            CenterZ = centerZ;
        }
    }
}
