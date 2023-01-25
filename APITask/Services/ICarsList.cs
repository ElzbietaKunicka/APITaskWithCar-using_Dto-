﻿namespace APITask.Services
{
    public interface ICarsList
    {
        List<Car> GetALLCars();
        List<Car> GetCarsByColor(string color);
        void AddNewCarToList(CarDto carDto);
        void UpdateCar(int id, string color, string brand);
        void DeleteCarById(int id);


    }
}
