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
    public class Dot : Shape
    {
        public Dot() { }

        public Dot(int centerX, int centerY) 
        {
            CenterX= centerX;
            CenterY= centerY;
        }

        public Dot(int centerX, int centerY, int centerZ)
        {
            CenterX= centerX;
            CenterY= centerY;
            CenterZ= centerZ;
        }
    }
}
