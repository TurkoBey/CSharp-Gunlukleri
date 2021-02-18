using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Switch_Case
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Switch-Case kullanım örneği\nBasit bir hesap makinesi yapalım\n");
			Console.WriteLine("" +
				"1 ==> Toplama" + "\n" +
				"2 ==> Çıkartma" + "\n" +
				"3 ==> Bölme" + "\n" +
				"4 ==> Çarpma");
			
			int deger = Convert.ToInt32(Console.ReadLine());
			switch (deger)
			{
				case 1:
					Console.WriteLine("Toplama işlemi için 2 adet sayi giriniz...");
					Console.Write("Sayi 1 giriniz :: ");
					int sayi1 = Convert.ToInt32(Console.ReadLine());
					Console.Write("Sayi 2 giriniz :: ");
					int sayi2 = Convert.ToInt32(Console.ReadLine());
					int sonuc1 = sayi1 + sayi2;
					Console.WriteLine("Sonuç ==>> " + sonuc1);
					break;
				case 2:
					Console.WriteLine("Çıkarma işlemi için 2 adet sayi giriniz...");
					Console.Write("Sayi 1 giriniz :: ");
					int sayi3 = Convert.ToInt32(Console.ReadLine());
					Console.Write("Sayi 2 giriniz :: ");
					int sayi4 = Convert.ToInt32(Console.ReadLine());
					int sonuc2 = sayi3 - sayi4;
					Console.WriteLine("Sonuç ==>> " + sonuc2);
					break;
				case 3:
					Console.WriteLine("Bölme işlemi için 2 adet sayi giriniz...");
					Console.Write("Sayi 1 giriniz :: ");
					int sayi5 = Convert.ToInt32(Console.ReadLine());
					Console.Write("Sayi 2 giriniz :: ");
					int sayi6 = Convert.ToInt32(Console.ReadLine());
					int sonuc3 = sayi5 / sayi6;
					Console.WriteLine("Sonuç ==>> " + sonuc3);
					break;
				case 4:
					Console.WriteLine("Bölme işlemi için 2 adet sayi giriniz...");
					Console.Write("Sayi 1 giriniz :: ");
					int sayi7 = Convert.ToInt32(Console.ReadLine());
					Console.Write("Sayi 2 giriniz :: ");
					int sayi8 = Convert.ToInt32(Console.ReadLine());
					int sonuc4 = sayi7 * sayi8;
					Console.WriteLine("Sonuç ==>> " + sonuc4);
					break;
				default:
					break;
			}
			Console.ReadLine();
		}
	}
}
