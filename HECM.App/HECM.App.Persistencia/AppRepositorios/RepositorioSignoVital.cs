using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;
using System;
using HECM.App.Persistencia;


namespace HECM.App.Persistencia{
    public class RepositorioSignoVital: IRepositorioSignoVital
    {
       private readonly HECM.App.Persistencia.AppContext _appContext;

       public RepositorioSignoVital(HECM.App.Persistencia.AppContext appContext)
       {
           _appContext=appContext;
       }
       SignoVital IRepositorioSignoVital.AddSignoVital (SignoVital signoVital)
       {
           var signoVitalAdicionado=_appContext.SignosVitales.Add(signoVital);
           _appContext.SaveChanges();
           return signoVitalAdicionado.Entity;
       }
       SignoVital IRepositorioSignoVital.UpdateSignoVital (SignoVital signoVital)
       {
           var signoVitalEncontrado=_appContext.SignosVitales.FirstOrDefault(p => p.Id ==signoVital.Id);
           if (signoVitalEncontrado!=null)
           {
               signoVitalEncontrado.Id=signoVital.Id;
               signoVitalEncontrado.FechaHora=signoVital.FechaHora;
               signoVitalEncontrado.FrecuenciaRespiratoria=signoVital.FrecuenciaRespiratoria;
               signoVitalEncontrado.FrecuenciaCardiaca=signoVital.FrecuenciaCardiaca;
               signoVitalEncontrado.Temperatura=signoVital.Temperatura;
               

               _appContext.SaveChanges();
           }
           return signoVitalEncontrado;
       }
       void IRepositorioSignoVital.DeleteSignoVital (int IdSignoVital)
       {
           var signoVitalEncontrado=_appContext.SignosVitales.FirstOrDefault(p => p.Id ==IdSignoVital);
           if (signoVitalEncontrado==null)
           return;
           _appContext.SignosVitales.Remove(signoVitalEncontrado);
           _appContext.SaveChanges();
       }
       SignoVital IRepositorioSignoVital.GetSignoVital (int IdSignoVital)
       {
           var signoVitalEncontrado=_appContext.SignosVitales.FirstOrDefault(p => p.Id ==IdSignoVital);
           return signoVitalEncontrado;
       }
       IEnumerable<SignoVital> IRepositorioSignoVital.GetAllSignoVital()
       {
           return _appContext.SignosVitales;
       }
    }
}