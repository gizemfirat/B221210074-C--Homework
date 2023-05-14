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
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {

        }

        public Rectangle(int centerX, int centerY, int width, int height)
        {
            CenterX = centerX;
            CenterY = centerY;
            Width = width;
            Height = height;
        }
    }
}
