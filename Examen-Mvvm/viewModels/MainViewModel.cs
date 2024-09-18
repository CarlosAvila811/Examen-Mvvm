using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace Examne_Mvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double producto1;

        [ObservableProperty]
        private double producto2;

        [ObservableProperty]
        private double producto3;

        [ObservableProperty]
        private double subtotal;

        [ObservableProperty]
        private double descuento;

        [ObservableProperty]
        private double totalPagar;

        [RelayCommand]
        public void Calcular()
        {
            // Calcular subtotal
            Subtotal = Producto1 + Producto2 + Producto3;

            // Determinar descuento
            if (Subtotal >= 10000)
                Descuento = Subtotal * 0.30;
            else if (Subtotal >= 5000)
                Descuento = Subtotal * 0.20;
            else if (Subtotal >= 1000)
                Descuento = Subtotal * 0.10;
            else
                Descuento = 0;

            // Calcular total a pagar
            TotalPagar = Subtotal - Descuento;
        }

        [RelayCommand]
        public void Limpiar()
        {
            Producto1 = Producto2 = Producto3 = 0;
            Subtotal = Descuento = TotalPagar = 0;
        }
    }
}
