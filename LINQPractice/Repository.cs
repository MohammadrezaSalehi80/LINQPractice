﻿
// See https://aka.ms/new-console-template for more information

public class Repository
{
    //create Test Data
    List<CarModel> _models;
    public Repository()
    {
        _models = new List<CarModel>();
        _models.Add(new CarModel()
        {
            Id = 1,
            Name = "Pride",
            Amount = 2000
        });

        _models.Add(new CarModel()
        {
            Id = 2,
            Name = "BMW",
            Amount = 20000
        });

        _models.Add(new CarModel()
        {
            Id = 2,
            Name = "Benz",
            Amount = 25000
        });


    }

    public List<CarModel> GetCars()
    {
        return _models;
    }

    public void Add(CarModel model)
    {
        _models.Add(model);
    }

}
