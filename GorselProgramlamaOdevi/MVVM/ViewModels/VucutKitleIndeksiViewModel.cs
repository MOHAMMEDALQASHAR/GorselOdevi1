using GorselProgramlamaOdevi.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaOdevi.MVVM.ViewModels
{
    public class VucutKitleIndeksiViewModel
    {
        public VucutKitleIndeksiModel VKIM { get; set; }

        public VucutKitleIndeksiViewModel()
        {
            VKIM = new VucutKitleIndeksiModel();
            VKIM.Height = 170;
            VKIM.Weight = 70;
        }


    }
}
