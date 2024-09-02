
using Patikafy;

List<Singer> singer = new List<Singer>
{
    new Singer("Ajda Pekkan", new List<string> {"Pop"}, 1968, 20000000),
    new Singer("Sezen Aksu", new List<string> {"Pop", "Türk Halk Müziği"}, 1971, 10000000),
    new Singer("Funda Arar", new List<string> {"Pop"}, 1999, 3000000),
    new Singer("Sertab Erener", new List<string> {"Pop"}, 1994, 5000000),
    new Singer("Sıla", new List<string> {"Pop"}, 2009, 3000000),
    new Singer("Serdar Ortaç", new List<string> {"Pop"}, 1994, 10000000),
    new Singer("Tarkan", new List<string> {"Pop"}, 1992, 40000000),
    new Singer("Hande Yener", new List<string> {"Pop"}, 1999, 700000),
    new Singer("Hadise", new List<string> {"Pop"}, 2005, 5000000),
    new Singer("Gülben Ergen", new List<string> {"Pop","Türk Halk Müziği"}, 1997, 10000000),
    new Singer("Neşet Ertaş", new List<string> {"Türk Halk Müziği" , "Türk Sanat Müziği"}, 1960, 2000000),
};

var singerStartsWithS = singer.Where(s => s.FullName.StartsWith("S"));
Console.WriteLine("---------------- Adı S ile Başlayan Şarkıcılar ----------------\n");

foreach (var s in singerStartsWithS)
    Console.WriteLine(s.FullName);

var singersWithHighSales = singer.Where(s => s.AlbumSales > 10000000);

Console.WriteLine("\n---------------- Albüm Satışları 10 Milyon Üzeri Olanlar ----------------\n");

foreach (var s in singersWithHighSales) Console.WriteLine(s.FullName);

var singersBefore2000AndPop = singer
                              .Where(s => s.ReleaseYear < 2000 && s.Genre.Contains("Pop"))
                              .OrderBy(s => s.ReleaseYear)
                              .ThenBy(s => s.FullName);

Console.WriteLine("\n---------------- 2000ler Öncesi Çıkış Yapan Pop Şarkıcılar ----------------\n");

foreach(var s in singersBefore2000AndPop)  Console.WriteLine(s.ReleaseYear + " - " +s.FullName);

var topSellerSinger = singer.OrderByDescending(s => s.AlbumSales).First();

Console.WriteLine("\n---------------- En Çok Albüm Satan Şarkıcı ----------------\n");

Console.WriteLine(topSellerSinger.FullName + " - " + topSellerSinger.AlbumSales);

var newestSinger = singer.OrderByDescending (s => s.ReleaseYear).First();
var oldestSinger = singer.OrderBy(s => s.ReleaseYear).First();

Console.WriteLine("\n---------------- En Yeni Çıkış Yapan Şarkıcı ----------------\n");

Console.WriteLine(newestSinger.FullName + " - " + newestSinger.ReleaseYear);

Console.WriteLine("\n---------------- En Eski Çıkış Yapan Şarkıcı ----------------\n");

Console.WriteLine(oldestSinger.FullName + " - " + oldestSinger.ReleaseYear);


