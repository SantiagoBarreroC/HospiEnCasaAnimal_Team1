
using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;

namespace HECM.App.Persistencia
{   public interface IRepositorioMascota
    {
    IEnumerable<Mascota> GetAllMascotas ();
    Mascota AddMascota(Mascota mascota);
    Mascota UpdateMascota(Mascota mascota);
    void DeleteMascota(int IdMascota);
    Mascota GetMascota(int IdMascota);
    void AddSignoVital (int IdMascota, SignoVital signoVital);
    }
    
}