using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;

namespace HECM.App.Persistencia{
    public interface IRepositorioHistoria
    {
       IEnumerable<Historia> GetAllHistorias ();
       Historia AddHistoria (Historia historia);
       Historia UpdateHistoria (Historia historia);
       void DeleteHistoria (int IdHistoria);
       Historia GetHistoria (int IdHistoria);     
    }   
}