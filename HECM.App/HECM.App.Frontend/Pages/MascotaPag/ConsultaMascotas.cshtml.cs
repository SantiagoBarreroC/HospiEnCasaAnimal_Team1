using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HECM.App.Persistencia;
using HECM.App.Dominio;

namespace HECM.App.Frontend.Pages.MascotaPag
{
    public class ConsultaMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        public IEnumerable<Mascota> mascota {get;set;}
        public ConsultaMascotasModel(IRepositorioMascota _repoMascota)
        {
            this._repoMascota=_repoMascota;
        }
        public void OnGet()
        {
            mascota=_repoMascota.GetAllMascotas();
        }
    }
}
