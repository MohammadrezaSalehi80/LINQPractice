
// See https://aka.ms/new-console-template for more information

using System.Collections;

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

