using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanetAppMAUI.Services;
using PlanetAppMAUI.Model;


namespace PlanetAppMAUI.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        private POTDService potdService;
        private POTD potd;
        public POTD Picture
        {
            get { return potd; }
            set
            {
                potd = value;
                OnPropertyChanged(nameof(Picture));
            }
        }


        public MainPageViewModel()
        {
            potdService = new POTDService();
            Task.Run(async () => await LoadBackgroundImage());
        }

        public async Task LoadBackgroundImage()
        {
            Picture = await potdService.GetPOTD();
        }
    }
}
