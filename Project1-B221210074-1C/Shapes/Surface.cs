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
    public class Surface : Shape
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public Surface() { }

        public Surface(int centerX, int centerY, int centerZ, int width, int depth)
        {
            CenterX = centerX;
            CenterY = centerY;
            CenterZ = centerZ;
            Width = width;
            Depth = depth;
        }
    }
}
