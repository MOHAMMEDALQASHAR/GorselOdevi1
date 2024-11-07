using Microsoft.Maui.Controls;
using System;

namespace GorselProgramlamaOdevi
{
    public partial class KrediHesaplama : ContentPage
    {
        public KrediHesaplama()
        {
            InitializeComponent();
        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                
            }
        }
        void OnCalculateClicked(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountEntry.Text);
            double interestRate = Convert.ToDouble(InterestRateEntry.Text) / 100;
            int termInMonths = Convert.ToInt32(TermEntry.Text);

            double brutFaiz = ((interestRate + (interestRate * 0.15) + (interestRate * 0.10)) / 100);
            double taksit = ((Math.Pow(1 + brutFaiz, termInMonths) * brutFaiz) / (Math.Pow(1 + brutFaiz, termInMonths) - 1)) * amount;
            double toplam = taksit * termInMonths;
            double toplamFaiz = toplam - amount; 

            
            taksit = Math.Round(taksit, 2);
            toplam = Math.Round(toplam, 2);
            toplamFaiz = Math.Round(toplamFaiz, 2);

            MonthlyPaymentLabel.Text = $"Aylýk Taksit   : {taksit}";
            TotalPaymentLabel.Text = $"Toplam Ödeme   : {toplam}";
            TotalInterestLabel.Text = $"Toplam Faiz  : {toplamFaiz}";
        }

    }
}
