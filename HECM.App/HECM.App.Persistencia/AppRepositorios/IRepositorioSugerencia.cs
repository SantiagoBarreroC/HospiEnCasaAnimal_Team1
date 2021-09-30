using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;

namespace HECM.App.Persistencia{
    public interface IRepositorioSugerencia
    {
       IEnumerable<SugerenciaCuidado> GetAllSugerencias ();
       SugerenciaCuidado AddSugerencia (SugerenciaCuidado sugerencia);
       SugerenciaCuidado UpdateSugerencia (SugerenciaCuidado sugerencia);
       void DeleteSugerencia (int IdSugerencia);
       SugerenciaCuidado GetSugerencia (int IdSugerencia);
    }
}  