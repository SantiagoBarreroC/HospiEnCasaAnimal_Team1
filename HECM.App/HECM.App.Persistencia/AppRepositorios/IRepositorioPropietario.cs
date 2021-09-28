using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;

namespace HECM.App.Persistencia{
    public interface IRepositorioPropietario
    {
       IEnumerable<PropietarioDesignado> GetAllPropietarios ();
       PropietarioDesignado AddPropietario (PropietarioDesignado propietario);
       PropietarioDesignado UpdatePropietario (PropietarioDesignado propietario);
       void DeletePropietario (int IdPropietario);
       PropietarioDesignado GetPropietario (int IdPropietario);
    }
}