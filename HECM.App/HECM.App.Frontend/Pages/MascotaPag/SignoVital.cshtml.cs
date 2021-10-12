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
    public class SignoVitalModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        public Mascota mascota{get;set;}
        
        public SignoVital signoVital{get;set;}

        
        public SignoVitalModel(IRepositorioMascota _repoMascota)
        {
            this._repoMascota=_repoMascota;
        }
        public IActionResult OnGet(int id)
        {
            mascota=_repoMascota.GetMascota(id);
            if(mascota!=null)
            {
                return Page();
            }
            else
            {
               return NotFound(); 
            } 
        }
        public IActionResult OnPost(int Id, SignoVital signoVital)
        {
            _repoMascota.AddSignoVital(Id,signoVital);
            return RedirectToPage("MascotaIndex");
        }
    }
}
