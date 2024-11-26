using System;

namespace CityLibrary
{
    public class City
    {
        private string _name;
        private int _population;
        private double _area;
        private int _landmarks;
        private double _dailyCost;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название города не может быть пустым.");
                _name = value;
            }
        }

        public int Population
        {
            get => _population;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Численность населения должна быть положительным числом.");
                _population = value;
            }
        }

        public double Area
        {
            get => _area;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Площадь должна быть положительным числом.");
                _area = value;
            }
        }

        public int Landmarks
        {
            get => _landmarks;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество достопримечательностей не может быть отрицательным.");
                _landmarks = value;
            }
        }

        public double DailyCost
        {
            get => _dailyCost;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Стоимость проживания должна быть положительным числом.");
                _dailyCost = value;
            }
        }

        public City(string name = "Неизвестный город", int population = 1, double area = 1.0, int landmarks = 0, double dailyCost = 1.0)
        {
            Name = name;
            Population = population;
            Area = area;
            Landmarks = landmarks;
            DailyCost = dailyCost;
        }

        public override string ToString()
        {
            return $"Город: {Name}, Население: {Population}, Площадь: {Area} кв.км, Достопримечательности: {Landmarks}, Стоимость проживания: {DailyCost} руб./день";
        }
    }
}
