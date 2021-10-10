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
    public class CrearModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;

        public Mascota mascota{get;set;}
        public CrearModel(IRepositorioMascota _repoMascota)
        {
            this._repoMascota = _repoMascota;
        }
        public void OnGet()
        {
            mascota=new Mascota();
        }

        public IActionResult Onpost(Mascota mascota)
        {
            _repoMascota.AddMascota(mascota);
            return RedirectToPage("MascotaIndex");
        }
    }
}
