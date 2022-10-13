using PlanetAppMAUI.Model;
using PlanetAppMAUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetAppMAUI.ViewModel
{
    public class BodiesViewModel : BaseViewModel
    {
        private POTDService potdService;

        //public string URLs 

        public BodiesViewModel()
        {
            _ = potdService.Get();
        }
    }
}
