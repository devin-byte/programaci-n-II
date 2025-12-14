using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AreaRectanguloApp.Models;

namespace AreaRectanguloApp.ViewModels
{
    public partial class RectanguloViewModel : ObservableObject
    {
        private Rectangulo rectangulo = new Rectangulo();

        [ObservableProperty]
        private double baseRectangulo;

        [ObservableProperty]
        private double altura;

        [ObservableProperty]
        private double area;

        [RelayCommand]
        private void CalcularArea()
        {
            rectangulo.Base = BaseRectangulo;
            rectangulo.Altura = Altura;

            Area = rectangulo.Base * rectangulo.Altura;
        }
    }
}
