using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HECM.App.Persistencia;
using HECM.App.Dominio;

namespace HECM.App.Frontend.Pages
{
    public class MascotaIndexModel : PageModel
    {
    private readonly IRepositorioMascota _repoMascota;
    public IEnumerable<Mascota> Mascotas {get;set;}

    public  MascotaIndexModel (IRepositorioMascota _repoMascota)
    {
       this._repoMascota= _repoMascota; 
    }
    public void OnGet()
        {
            Mascotas= _repoMascota.GetAllMascotas();
        }
    }
    
}
