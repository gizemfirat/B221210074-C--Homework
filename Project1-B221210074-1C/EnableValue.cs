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


namespace Project1_B221210074_1C
{
    public class EnableValue
    {
        public static void EnableDot1(NumericUpDown n1, NumericUpDown n2, NumericUpDown n3, NumericUpDown n4, NumericUpDown n5)
        {
            n1.Enabled = false;
            n2.Enabled = false;
            n3.Enabled = false;
            n4.Enabled = false;
            n5.Enabled = false;
        }

        public static void EnableDot2(NumericUpDown n1, NumericUpDown n2, NumericUpDown n3, NumericUpDown n4)
        {
            n1.Enabled = false;
            n2.Enabled = false;
            n3.Enabled = false;
            n4.Enabled = false;
        }

        public static void EnableHoop(NumericUpDown n1, NumericUpDown n2, NumericUpDown n3, NumericUpDown n4)
        {
            n1.Enabled = false;
            n2.Enabled = false;
            n3.Enabled = false;
            n4.Enabled = false;
        }

        public static void EnableRectangle(NumericUpDown n1, NumericUpDown n2, NumericUpDown n3)
        {
            n1.Enabled = false;
            n2.Enabled = false;
            n3.Enabled = false;
        }

        public static void EnableRectanglePrism(NumericUpDown n1)
        {
            n1.Enabled = false;
        }

        public static void EnableSphere(NumericUpDown n1, NumericUpDown n2, NumericUpDown n3)
        {
            n1.Enabled = false;
            n2.Enabled = false;
            n3.Enabled = false;
        }

        public static void EnableCylinder(NumericUpDown n1, NumericUpDown n2)
        {
            n1.Enabled = false;
            n2.Enabled = false;
        }

        public static void EnableSurface(NumericUpDown n1, NumericUpDown n2)
        {
            n1.Enabled = false;
            n2.Enabled = false;
        }
    }
}
