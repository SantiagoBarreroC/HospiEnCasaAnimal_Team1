using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;

namespace HECM.App.Persistencia{
    public interface IRepositorioSignoVital
    {
       IEnumerable<SignoVital> GetAllSignoVital ();
       SignoVital AddSignoVital (SignoVital signoVital);
       SignoVital UpdateSignoVital(SignoVital signoVital);
       void DeleteSignoVital (int IdSignoVital);
       SignoVital GetSignoVital(int IdSignoVital);
    }
}