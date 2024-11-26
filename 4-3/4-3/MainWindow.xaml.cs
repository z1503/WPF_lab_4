using System;
using System.Windows;
using CityLibrary;

namespace CityApp
{
    public partial class MainWindow : Window
    {
        private City _city;

        public MainWindow()
        {
            InitializeComponent();
            _city = new City();
            DisplayCityInfo();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = NameInput.Text;
                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentException("Название города не может быть пустым.");

                int population;
                if (!int.TryParse(PopulationInput.Text, out population) || population <= 0) 
                    throw new ArgumentException("Численность населения должна быть положительным целым числом.");

                double area;
                if (!double.TryParse(AreaInput.Text, out area) || area <= 0)
                    throw new ArgumentException("Площадь должна быть положительным числом.");

                int landmarks;
                if (!int.TryParse(LandmarksInput.Text, out landmarks) || landmarks < 0)
                    throw new ArgumentException("Количество достопримечательностей не может быть отрицательным числом.");

                double dailyCost;
                if (!double.TryParse(DailyCostInput.Text, out dailyCost) || dailyCost <= 0)
                    throw new ArgumentException("Стоимость проживания должна быть положительным числом.");

                _city.Name = name;
                _city.Population = population;
                _city.Area = area;
                _city.Landmarks = landmarks;
                _city.DailyCost = dailyCost;

                DisplayCityInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DisplayCityInfo()
        {
            Output.Text = _city.ToString();
        }
    }
}
