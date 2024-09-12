// See https://aka.ms/new-console-template for more information

// c# dilinde tarih ve zaman işlemleri için bir değişken tipi vardır. Bu değişken tipinin adı Datetime'dır

// Bugünün tarihi almak!!
//string nowDate  = DateTime.Now.ToString();
//Console.WriteLine(nowDate);


Console.WriteLine("To Long Date String:"+DateTime.Now.ToLongDateString());
Console.WriteLine("To Log Time String : "+ DateTime.Now.ToLongTimeString());

// Tarih veya zamana ekleme yapılabilir.

//Console.WriteLine("Tarihe ekleme yada çıkartma yapabilirsiniz : "+DateTime.Now.AddYears(17));

Console.WriteLine("10 gün önceki tarihi ver : "+DateTime.Now.AddDays(-10).ToLongDateString());

// Bir tarihi datetime olarak tanımlayabilirsin.

//DateTime date = new DateTime(2000,12,1);
//Console.WriteLine("Custom Tarih Ayarladım : "+date.ToLongDateString());

// sadece günü alalım
//Console.WriteLine("Sadece gün değerini alalım : "+date.Day);

// Değerleri türkçe vermesi için => GLobalization Değerlerini değiştiririz.

//Console.WriteLine("Micro Saniyeyi alalım : "+DateTime.Now.Microsecond);

// iki tarihi birbirinden çıkartalım

//DateTime firstDate = new DateTime(1923,10,29);
//DateTime now = DateTime.Now;

//TimeSpan ile iki tarihi birbirinden çıkartıp farkı alabiliriz.
//TimeSpan fark = now-firstDate;
// bu iki tarih arasındaki farkı, ay, yıl ve, gün olarak gösterelim

//Console.WriteLine("Fark gün  : "+fark.TotalDays);

//Console.WriteLine("Fark Saat  : "+fark.TotalHours);


// Örnek uygulama,
// Ekrandan ay yıl ve gün bilgisi alıp, bu bilgiler
// ile bir datetime tanımlayıp, bugünden timespan ile çıkartıp, 
//ekrana kaç yıldır kaç gündür ve kaç dakikadır yaşadığınızı yazdıran bir uygulama yapınız
// Version 1 
/*Console.WriteLine("Doğum yılınızı giriniz");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Doğum ayınızı giriniz");
int mouth = int.Parse(Console.ReadLine());
Console.WriteLine("Doğum gününüzü giriniz");
int day = int.Parse(Console.ReadLine());
// Datetime oluşturalım

DateTime birthDate =new DateTime(year,mouth,day);
// Şimdiki zamanı alıyorum

// bugün ile doğum tarihi arasındaki farkı alıyorum 
TimeSpan fark  = DateTime.Now-birthDate;

Console.WriteLine("{0} yıldır dünyadasınız",fark.TotalDays/365);
Console.WriteLine("{0} gündür dünyadasınız",fark.Days);
Console.WriteLine("{0} dakikadır dünyadasınız",fark.TotalMinutes);
*/


//Version 2
// Örnek 21.11.1982
Console.WriteLine("Lütfen doğum tarihinizi giriniz(Örnek : gün.ay.yıl)");
string birthDateString = Console.ReadLine(); 
int day = Convert.ToInt32(birthDateString.Substring(0, 2));
int mouth=Convert.ToInt32(birthDateString.Substring(3,2));
int year=Convert.ToInt32(birthDateString.Substring(6,4));

DateTime birthDate = new DateTime(year,mouth,day);
TimeSpan fark = DateTime.Now-birthDate;
Console.WriteLine("{0} yıldır dünyadasınız",fark.TotalDays/365);

// iki türkiyede çalışan programın entegrasyonun
// iki farklı ülkede çalışan entegrasyon

Console.WriteLine(DateTime.UtcNow.ToString());





