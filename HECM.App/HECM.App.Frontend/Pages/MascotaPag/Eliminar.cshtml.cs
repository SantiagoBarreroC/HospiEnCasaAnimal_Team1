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
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        public Mascota mascota {get;set;}
        public EliminarModel (IRepositorioMascota _repoMascota)
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
        public IActionResult OnPost(int id)
        {
            _repoMascota.DeleteMascota(id);
            return RedirectToPage("MascotaIndex");
        }
    }
}
