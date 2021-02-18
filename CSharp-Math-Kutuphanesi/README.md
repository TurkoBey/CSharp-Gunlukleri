
# C# Math Kütüphanesi

```csharp
Console.WriteLine("C# Math Kütüphanesi\n\n");
Console.WriteLine($"Pi       ==>> [{Math.PI}]" + " Pi sayısını veren fonksiyon. ''Double'' türünde değer alır.");
Console.WriteLine($"E        ==>> [{Math.E}]" + " E sapitini verir." + "\n");

Console.WriteLine($"Min      ==>> [{Math.Min(10, 50)}]" + " 10 ile 50 değerleri arasındaki 'minimum' değeri ekrana yazdırır.");
Console.WriteLine($"Max      ==>> [{Math.Max(10, 50)}]" + " 10 ile 50 değerleri arasındaki 'maksimum' değeri ekrana yazdırır." + "\n");

Console.WriteLine($"Ceiling  ==>> [{Math.Ceiling(10.23)}]" + " Double türünde değeri, üst tam sayıya yuvarlar. Örğ: '10.23' sayısını 11'e yuvarlar.");
Console.WriteLine($"Floor    ==>> [{Math.Floor(10.23)}]" + " Double türünde değeri, alt tam sayıya yuvarlar. Örğ: '10.23' sayısını 10'a yuvarlar." + "\n");

Console.WriteLine($"Abs      ==>> [{Math.Abs(-10)}]" + " Bir sayının mutlak değerini alır. Örğ: '-10' değerini mutlak değerinin ekrana yazdırır.");
Console.WriteLine($"Pow      ==>> [{Math.Pow(2, 4)}]" + " Bir sayının üstünü alır. Örğ: (2,4) = 16 değerini sonuçun ekrana yazdırır.");
Console.WriteLine($"Sqrt     ==>> [{Math.Sqrt(100)}]" + " Bir sayının karakökünü alır. Örğ: (100) = 10 değerini sonuçun ekrana yazdırır.");
Console.WriteLine($"Truncate ==>> [{Math.Truncate(15.49345)}]" + " Double veya Decimal türünden sayıların, virgülden sonraki kısmını atarak bize tam sayısını döndürür.. Örğ: (15.49345) = 15 değerini sonuçun ekrana yazdırır.\n");
Console.WriteLine($"Round    ==>> [{Math.Round(10.49)}]" + " Sayının sayının virgülden sonraki kısmına göre aşağı ya da yukarı yuvarlar. Örğ: (10.49) = 10 değerini sonuçun ekrana yazdırır.");
Console.WriteLine($"Round    ==>> [{Math.Round(10.51)}]" + " Sayının sayının virgülden sonraki kısmına göre aşağı ya da yukarı yuvarlar. Örğ: (10.51) = 11 değerini sonuçun ekrana yazdırır.");

Console.WriteLine("\n###Trigonometrik Fonksiyonlar###");
Console.WriteLine($"Sin      ==>> [{Math.Sin(90)}]" + " Açının sinüsünü verir.");
Console.WriteLine($"Cos      ==>> [{Math.Cos(90)}]" + " Açının kosinüsünü verir.");
Console.WriteLine($"Tan      ==>> [{Math.Tan(90)}]" + " Açının tanjantını verir.");

Console.WriteLine("\n###Hiperbolik Fonksiyonlar###");
Console.WriteLine($"Sin      ==>> [{Math.Sinh(90)}]" + " Açının hiperbolik sinüsünü hesaplar.");
Console.WriteLine($"Cos      ==>> [{Math.Cosh(90)}]" + " Açının hiperbolik kosinüsünü hesaplar.");
Console.WriteLine($"Tan      ==>> [{Math.Tanh(90)}]" + " hiperbolik tanjantını hesaplar.");

Console.WriteLine("\n###Logaritma Fonksiyonları###");
Console.WriteLine($"Sin      ==>> [{Math.Log10(10)}]" + " Sayının 10 tabanlı logaritmasını hesaplar.");
Console.WriteLine($"Cos      ==>> [{Math.Log(10)}]" + " E tabanındaki logaritmayı hesaplar.");
Console.WriteLine($"Tan      ==>> [{Math.Log(10, 2)}]" + " İki parametre ile kullanarak herhangi bir sayının logaritması herhangi bir tabanda alınabilir.");
		
Console.ReadLine();
