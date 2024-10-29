
// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Diagnostics.CodeAnalysis;

var cars = new Repository();

var CarList = cars.GetCars();
var CarType = cars.GetCarType();

#region deferred and Immediat execution

////defferred
////var BestCar = cars.GetCars().Where(x => x.Amount > 2000);

////Immediat
//var BestCar = CarList.Where(x => x.Amount > 2000).ToList();

//foreach (var car in BestCar)
//{
//    Console.WriteLine(car.Name);
//}

//Console.WriteLine("------------------------------------------");

//cars.Add(new CarModel()
//{
//    Id = 4,
//    Name = "KIA",
//    Amount = 23000
//});

//foreach (var car in BestCar)
//{
//    Console.WriteLine(car.Name);
//}

#endregion

#region Filtering
//var TestWhere = CarList.Where(x => x.Name.StartsWith("P")).ToList();

//foreach (var car in CarList)
//{
//    Console.WriteLine(car.Name);
//}

//IList list = new ArrayList();

//list.Add("Ali");
//list.Add("Mohammad");
//list.Add("Alex");
//list.Add(2000);
//list.Add(4000);
//list.Add(4);
//list.Add(true);


//var TestOfType = list.OfType<int>();

//foreach (var item in TestOfType)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Sorting
//var TestOrderBy = CarList.OrderBy(x => x.Amount);
//Console.WriteLine("TestOrderBy");
//foreach (var Car in TestOrderBy)
//{
//    Console.WriteLine(Car.Name + "     " + Car.Amount.ToString());
//}


//var TestOrderByDescending = CarList.OrderByDescending(x => x.Amount);
//Console.WriteLine("TestOrderByDescending ");

//foreach (var Car in TestOrderByDescending)
//{
//    Console.WriteLine(Car.Name + "     " + Car.Amount.ToString());
//}


//var TestThenBy = CarList.OrderBy(x => x.Amount).ThenBy(x=>x.Name);
//Console.WriteLine("TestThenBy");

//foreach (var Car in TestThenBy)
//{
//    Console.WriteLine(Car.Name + "     " + Car.Amount.ToString());
//}

//var TestReverse = CarList.OrderBy(x => x.Amount).Reverse();
//Console.WriteLine("TestReverse");

//foreach (var Car in TestReverse)
//{
//    Console.WriteLine(Car.Name + "     " + Car.Amount.ToString());
//}

#endregion

#region Grouping

////Group By is Deferred
//var car = CarList.GroupBy(x=>x.Country);

//foreach (var Country in car)
//{
//    Console.WriteLine(Country.Key);

//    foreach (var CarItem in Country)
//    {
//        Console.WriteLine(CarItem.Name);
//    }

//    Console.WriteLine("------------------------");
//}


////Lookup is Immediat
//var car = CarList.ToLookup(x => x.Country);

//foreach (var Country in car)
//{
//    Console.WriteLine(Country.Key);

//    foreach (var CarItem in Country)
//    {
//        Console.WriteLine(CarItem.Name);
//    }

//    Console.WriteLine("------------------------");
//}


#endregion

#region Join

////jon
//var Car = CarList.Join(CarType, p => p.CarType, c => c.Id, (car, CarType) => new
//{
//    CarType = CarType.Name,
//    CarName = car.Name
//});

//foreach (var car in Car)
//{
//    Console.WriteLine(car.CarType + ":    " + car.CarName);
//}

////Grouping Join
//var Car = CarType.GroupJoin(CarList, p => p.Id, c => c.CarType, (carType, Car)=> new
//{
//    CarType = carType.Name,
//    CarName = Car.Select(carType => carType.Name)
//});

//foreach (var car in Car)
//{
//    Console.WriteLine(car.CarType);

//    foreach(var c in car.CarName)
//    {
//        Console.WriteLine(c);
//    }

//    Console.WriteLine("--------------------------------");
//}


#endregion

#region Projection

//var carName = CarList.Select(x => x.Name);

//foreach (var car in carName)
//{
//    Console.WriteLine(carName);
//}
//List<int> ints = new List<int>() { 1, 5, 8, 4, 6, 3, 8 };
//var c = ints.SelectMany(x => x % 2 == 0);

#endregion

#region Agreggate

//List<string> ProgramLang = new List<string>() { "C#", "PHP", "Java", "Python" };

//var aggregateTest = ProgramLang.Aggregate((s1, s2)=> s1 + "," + s2);

//Console.WriteLine(aggregateTest);

//var AverageTest = CarList.Average(x=>x.Amount);
//Console.WriteLine(AverageTest);

//var SumTest = CarList.Sum(x=>x.Amount);
//Console.WriteLine(SumTest);

//var MaxTest = CarList.Max(x=>x.Amount);
//Console.WriteLine(MaxTest);

//var MinTest = CarList.Min(x=>x.Amount);
//Console.WriteLine(MinTest);

//var CountTest = CarList.Count();
//Console.WriteLine(CountTest);

//var LongCountTest = CarList.LongCount();
//Console.WriteLine(LongCountTest);

#endregion

#region Quantifiers

//var AllTest = CarList.All(x => x.Amount >= 1000);
//Console.WriteLine(AllTest);

//var AnyTest = CarList.Any(x => x.Amount == 1000);
//Console.WriteLine(AnyTest);


#endregion

#region Element

//var ElementAt = CarList.ElementAt(0);
//Console.WriteLine(ElementAt.Name);

//var ElementAtOrDefault = CarList.ElementAtOrDefault(10);
//Console.WriteLine(ElementAtOrDefault.Name);

//var Frst = CarList.First();
//Console.WriteLine(Frst.Name);

//var FirstOrDefault = CarList.FirstOrDefault();
//Console.WriteLine(FirstOrDefault.Name);

//var Last = CarList.Last();
//Console.WriteLine(Last.Name);

//var LastOrDefault = CarList.LastOrDefault();
//Console.WriteLine(LastOrDefault.Name);

//var Single = CarList.Where(p=>p.Name.Contains("BMW")).Single();
//Console.WriteLine(Single.Name);

//var SingleOrDefault = CarList.Where(p => p.Name.Contains("BMW")).SingleOrDefault();
//Console.WriteLine(SingleOrDefault.Name);


#endregion

#region Set

//List<string> data1 = new List<string>() { "1", "2", "3", "3", "3", "4", "5", "5" };
//List<string> data2 = new List<string>() { "3", "3", "4", "5", "5" };
//Console.WriteLine("------------------------------------");
//var distinct = data1.Distinct().ToList();
//foreach (var item in distinct)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("------------------------------------");
//var Except = data1.Except(data2).ToList();
//foreach (var item in Except)
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine("------------------------------------");
//var Intersect = data1.Intersect(data2).ToList();
//foreach (var item in Intersect)
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine("------------------------------------");
//var Union = data1.Union(data2).ToList();
//foreach (var item in Union)
//{
//    Console.WriteLine(item);
//}



//Console.WriteLine("------------------------------------");
//var Concat = data1.Concat(data2).ToList();
//foreach (var item in Concat)
//{
//    Console.WriteLine(item);
//}


//For object in C# Use this Interface For Compare two List Of Object
//public class CarComparer : IEqualityComparer<CarModel>
//{
//    public bool Equals(CarModel? x, CarModel? y)
//    {
//        if (x.Amount > y.Amount) 
//            return true;

//        return false;
//    }

//    public int GetHashCode([DisallowNull] CarModel obj)
//    {
//        throw new NotImplementedException();
//    }
//}

#endregion

#region Partition

//List<int> ints = new List<int>() { 1, 4, 10, 11, 5, 8 };

////Skip number of element from 0 index
//var SkipTest = ints.Skip(3);
//Console.WriteLine("---------------------------------");
//foreach (var lst in SkipTest)
//{
//    Console.WriteLine(lst);
//}

//Console.WriteLine("---------------------------------");

//var SkipWhileTest = ints.SkipWhile(x => x < 11);
//foreach (var lst in SkipWhileTest)
//{
//    Console.WriteLine(lst);
//}


//Console.WriteLine("---------------------------------");

//var Take = ints.Take(3);
//foreach (var lst in Take)
//{
//    Console.WriteLine(lst);
//}

//Console.WriteLine("---------------------------------");

//var TakeWhile = ints.TakeWhile(x => x < 11);
//foreach (var lst in TakeWhile)
//{
//    Console.WriteLine(lst);
//}

#endregion

#region Equality

//var d1 = new List<int>() { 1, 2, 3 };
//var d2 = new List<int>() { 1, 4, 3 };

//Console.WriteLine(d1.SequenceEqual(d2));

#endregion

#region Generation 

//List<string> empty = new List<string>();

//var DefaultIfEmpty = empty.DefaultIfEmpty();

//var Range = Enumerable.Range(4, 20);

//foreach (var d in Range)
//{
//    Console.WriteLine(d);
//}
//Console.WriteLine("---------------------");

//var re = Enumerable.Repeat(4, 9);
//foreach (var d in re)
//{
//    Console.WriteLine(d);
//}

#endregion

#region Conversion

//List<string> CarNames = CarList.Select(x=>x.Name).ToList();

//var AsEnumerable = CarNames.AsEnumerable();

//var AsQueryable = CarNames.AsQueryable();

//var Cast = CarNames.Cast<CarModel>();

////ToArray
////ToList
////ToDictionary

#endregion