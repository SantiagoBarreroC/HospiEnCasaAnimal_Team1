using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HECM.App.Dominio;
using HECM.App.Persistencia;

namespace HECM.App.Frontend.Pages.MascotaPag
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        public Mascota mascota{get;set;}
        public ActualizarModel(IRepositorioMascota _repoMascota)
        {
            this._repoMascota=_repoMascota;
        }
        public IActionResult OnGet(int id)
        {
            mascota=_repoMascota.GetMascota(id);
            if (mascota==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost(Mascota mascota)
        {
            _repoMascota.UpdateMascota(mascota);
            return RedirectToPage("MascotaIndex");
        }
    }
}
