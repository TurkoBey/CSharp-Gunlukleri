using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Degiskenler
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("C# Değişkenler\n\n");
			Console.WriteLine($"byte    ==>> [{byte.MinValue}] ile [{byte.MaxValue}] arasındaki değerleri tutabilir.\n");
			Console.WriteLine($"short   ==>> [{short.MinValue}] ile [{short.MaxValue}] arasındaki değerleri tutabilir.");

			Console.WriteLine($"ushort  ==>> [{ushort.MinValue}] ile [{ushort.MaxValue}] arasındaki değerleri tutabilir.\n");
			Console.WriteLine($"int     ==>> [{int.MinValue}] ile [{int.MaxValue}] arasındaki değerleri tutabilir.");

			Console.WriteLine($"uint    ==>> [{uint.MinValue}] ile [{uint.MaxValue}] arasındaki değerleri tutabilir.\n");
			Console.WriteLine($"long    ==>> [{long.MinValue}] ile [{long.MaxValue}] arasındaki değerleri tutabilir.");

			Console.WriteLine($"ulong   ==>> [{ulong.MinValue}] ile [{ulong.MaxValue}] arasındaki değerleri tutabilir.\n");
			Console.WriteLine($"float   ==>> [{float.MinValue}] ile [{float.MaxValue}] arasındaki değerleri tutabilir.");

			Console.WriteLine($"double  ==>> [{double.MinValue}] ile [{double.MaxValue}] arasındaki değerleri tutabilir.\n");

			Console.WriteLine($"bool    ==>> [{bool.TrueString}] ile [{bool.FalseString}] değerlerini tutabilir.\n");
			
			Console.WriteLine($"char    ==>> [Örğ: char='s'] tek karakter değerleri tutabilir.\n");
			
			Console.WriteLine($"string  ==>> [Örğ: string={"\"Bu bir metindir.\""}]");
			Console.ReadLine();
		}
	}
}
