using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaOdevi.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]

    public class VucutKitleIndeksiModel
    {
        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result
        {
            get
            {
                return ((Weight / Height) / Height) * 10000;
            }
        }
        public string ResultText
        {
            get
            {
                string template = "BMI: #";
                if (Result <= 16)
                {
                    return template.Replace("#", "İleri Düzeyde Zayıf");
                }
                else if (Result > 16 && Result <= 17)
                {
                    return template.Replace("#", "Orta Düzeyde Zayıf");
                }
                else if (Result > 17 && Result <= 18.5)
                {
                    return template.Replace("#", "Hafif Düzeyde Zayıf");
                }
                else if (Result > 18.5 && Result <= 25)
                {
                    return template.Replace("#", "Normal Kilolu");
                }
                else if (Result > 25 && Result <= 30)
                {
                    return template.Replace("#", "Hafif şişman");
                }
                else if (Result > 30 && Result <= 35)
                {
                    return template.Replace("#", "1. Derecede Obez");
                }
                else if (Result > 35 && Result <= 40)
                {
                    return template.Replace("#", "2. Derecede Obez");
                }
                else
                {
                    return template.Replace("#", "3. Derecede Obez");
                }

            }
        }
    }
}
