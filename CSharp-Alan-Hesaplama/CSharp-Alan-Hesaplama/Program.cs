using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Alan_Hesaplama
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Alan Hesaplama Aracı");
			Console.WriteLine("\n###Şekil###\n");
			Console.WriteLine(
				"Üçgen      ==>> [1]" + "\n" +
				"Kare       ==>> [2]" + "\n" +
				"Dikdörtgen ==>> [3]" + "\n" +
				"Daire      ==>> [4]" + "\n");
			Console.Write("Seçiniz :: ");
			int alan = int.Parse(Console.ReadLine());
			switch (alan)
			{
				case 1:
					Console.WriteLine("\n");
					ucgenHesapla();
					break;
				case 2:
					Console.WriteLine("\n");
					kareHesapla();
					break;
				case 3:
					Console.WriteLine("\n");
					dikHesapla();
					break;
				case 4:
					Console.WriteLine("\n");
					daireHesapla();
					break;
				default:
					break;
			}
		}

		private static void daireHesapla()
		{
			Hesapla hesap = new Hesapla();
			Console.Write("Y.çapı   : ");
			int r = int.Parse(Console.ReadLine());
			Console.WriteLine("\nDairenin alanı: " + Math.Round((hesap.DAlani(r)), 5)  + " cm2");
			Console.ReadLine();
		}
		private static void dikHesapla()
		{
			Hesapla hesap = new Hesapla();
			Console.Write("Taban	: ");
			int DikA = int.Parse(Console.ReadLine());
			Console.Write("Yükselik : ");
			int DikH = int.Parse(Console.ReadLine());
			Console.WriteLine("\nDikdörtgenin alanı: " + hesap.DikAlani(DikA,DikH) + " cm2");
			Console.ReadLine();
		}
		private static void kareHesapla()
		{
			Hesapla hesap = new Hesapla();
			Console.Write("Taban	: ");
			int KareA = int.Parse(Console.ReadLine());
			Console.WriteLine("\nKarenin alanı: " + hesap.KAlani(KareA) + " cm2");
			Console.ReadLine();
		}
		private static void ucgenHesapla()
		{
			Hesapla hesap = new Hesapla();
			Console.Write("Taban    : ");
			int UcgenA = int.Parse(Console.ReadLine());
			Console.Write("Yükselik : ");
			int UcgenH = int.Parse(Console.ReadLine());
			Console.WriteLine("\nÜçgenin alanı: " + hesap.UAlani(UcgenA, UcgenH) + " cm2");
			Console.ReadLine();
		}
	}
}
