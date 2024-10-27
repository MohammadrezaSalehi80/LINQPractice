
// See https://aka.ms/new-console-template for more information

using System.Collections;

var cars = new Repository();

var CarList = cars.GetCars();

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