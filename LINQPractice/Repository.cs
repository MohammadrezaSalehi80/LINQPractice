
// See https://aka.ms/new-console-template for more information

public class Repository
{
    //create Test Data
    List<CarType> _carType;
    List<CarModel> _models;
    public Repository()
    {
        _models = new List<CarModel>();
        _carType = new List<CarType>();
        _carType.Add(new CarType()
        {
            Id = 1,
            Name = "CityCar"
        });

        _carType.Add(new CarType()
        {
            Id = 2,
            Name = "Sedan"
        });


        _models.Add(new CarModel()
        {
            Id = 1,
            Name = "Pride",
            Amount = 2000,
            Country = "Iran",
            CarType = 1
        });

        _models.Add(new CarModel()
        {
            Id = 2,
            Name = "BMW",
            Amount = 20000,
            Country = "Germany",
            CarType = 2
        });

        _models.Add(new CarModel()
        {
            Id = 3,
            Name = "Benz",
            Amount = 25000,
            Country = "Germany",
            CarType = 2
        });

        _models.Add(new CarModel()
        {
            Id = 4,
            Name = "Peykan",
            Amount = 1000,
            Country = "Iran",
            CarType = 1
        });


    }

    public List<CarModel> GetCars()
    {
        return _models;
    }

    public List<CarType> GetCarType()
    {
        return _carType;
    }

    public void Add(CarModel model)
    {
        _models.Add(model);
    }

}
