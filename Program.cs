using System;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;

namespace ClassObjectsConstructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Task1
			//1) Person classı olsun
			//Name, Surname, Age, İsAdult propertyləri olsun. Və name, surname, age parametrlərini qəbul edən Constructoru olsun.
			//Obyekt yarananda əgər yaşı 18dən böyükdürsə İsAdult - ı true əks halda false olsun.
			Person person = new Person("Ali", "Aliyev", 13);
			//Console.WriteLine(person.CheckUser);
			if (person.Age >= 18)
			{
				person.IsAdult = true;
			}
			else
			{
				person.IsAdult = false;
			}
			Console.WriteLine(person.IsAdult);
			#endregion
			#region Task2
			//2) Brend,Model,İl,FuelType və Rəng property-ləri olan Car klasınız olsun
			//Object yarananda Brend,Model,FuelType,İl və Rəng attributlarını ötürün.
			// Objectdə PrintInfo Metodunuz olsun onu call edən zaman
			//bütün məlumatları ekrana çap etsin
			Car car = new Car("Bmw","BMW",3,"dizel","black");
			car.PrintInfo();
			#endregion
			#region Task3
			//3) Car və Motorcycle adlı klasınız olsun və Model,Brend,Year,MaxSpeed propertyləri olsun
			//bundan əlavə Car klasının NumSeats,Motorcycle klasının isə HasSidecar propertyisi olsun
			//Obyekt yarandıqdan sonra Əgər sürət 110 - dan böyükdürsə ekrana "Suret oldurur" əks halda "Bele davam edin"
			//yazısı çap olunsun
			Car1 car1 = new Car1(230);
			if (car1.MaxSpeed > 100)
			{
				Console.WriteLine("Suret oldurur");
			}
			else
			{
				Console.WriteLine("Bele davam edin");
			}
			Motorcycle motorcycle = new Motorcycle(20);
			if (motorcycle.MaxSpeed > 100)
			{
				Console.WriteLine("Suret oldurur");
			}
			else
			{
				Console.WriteLine("Bele davam edin");
			}
			#endregion
			#region Task4
			//4) User classı olsun, içində fantaziyanıza görə propertylər və əsasstring Name;
			//string Password; Propertyləri olsun. Və public bool IsPasswordValid() methodu olsun.
			//Bu method, əgər passvordun uzunluğu 6dan qısadırsa, və ya passwordun daxilində rəqəm yoxdursa və ya əgər Passvordun daxilində Name vardırsa false,
			//əks halda true return eləsin.Valid password uzunluğu 6dan uzun, içində rəqəm olan və userin adının passvordun içində keçmədiyi passvorddur.
			User user = new User("Aygun", "Murad.123");
            Console.WriteLine(user.IsPasswordValid());
			#endregion
		}
	}
}