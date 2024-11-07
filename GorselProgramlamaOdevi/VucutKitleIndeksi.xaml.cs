namespace GorselProgramlamaOdevi;

using Microsoft.Maui.Controls;
using System;

public partial class VucutKitleIndeksi : ContentPage
{
    public VucutKitleIndeksi()
    {
        InitializeComponent();
        BindingContext = new MVVM.ViewModels.VucutKitleIndeksiViewModel();
    }

}
