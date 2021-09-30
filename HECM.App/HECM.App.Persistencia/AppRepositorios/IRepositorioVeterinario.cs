using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;

namespace HECM.App.Persistencia{
    public interface IRepositorioVeterinario
    {
       IEnumerable<Veterinario> GetAllVeterinario ();
       Veterinario AddVeterinario (Veterinario veterinario);
       Veterinario UpdateVeterinario (Veterinario veterinario);
       void DeleteVeterinario (int IdVeterinario);
       Veterinario GetVeterinario (int IdVeterinario);
    }
}