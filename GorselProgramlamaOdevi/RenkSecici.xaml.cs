using System;

namespace GorselProgramlamaOdevi;

public partial class RenkSecici : ContentPage
{

    Boolean isRandom;
    String hexValue;
    public RenkSecici()
    {
        InitializeComponent();

      
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (!isRandom)
        {
            var red = sldRed.Value;
            var green = sldGreen.Value;
            var blue = sldBlue.Value;


            Color color = Color.FromRgb(red, green, blue);
            setColor(color);
        }


    }

    private void setColor(Color color)
    {
        btnRandom.BackgroundColor = color;
        Container.BackgroundColor = color;
        hexValue = color.ToHex();
        lblHex.Text = hexValue;

    }

    private void btnRandom_Clicked(object sender, EventArgs e)
    {
        isRandom = true;
        var random = new Random();
        var color = Color.FromRgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        setColor(color);

        sldRed.Value = color.Red;
        sldGreen.Value = color.Green;
        sldBlue.Value = color.Blue;
        isRandom = false;

    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(hexValue);
        await DisplayAlert("Kopyalandı", $"{hexValue}", "OK");


    }
}


