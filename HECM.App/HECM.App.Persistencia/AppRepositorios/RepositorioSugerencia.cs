using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;
using System;
using HECM.App.Persistencia;


namespace HECM.App.Persistencia{
    public class RepositorioSugerencia: IRepositorioSugerencia 
    {
       private readonly AppContext _appContext= new AppContext();

       SugerenciaCuidado IRepositorioSugerencia.AddSugerencia (SugerenciaCuidado sugerencia)
       {
           var sugerenciaAdicionado=_appContext.SugerenciaCuidados.Add(sugerencia);
           _appContext.SaveChanges();
           return sugerenciaAdicionado.Entity;
       }
       SugerenciaCuidado IRepositorioSugerencia.UpdateSugerencia (SugerenciaCuidado sugerencia)
       {
           var sugerenciaEncontrado=_appContext.SugerenciaCuidados.FirstOrDefault(p => p.Id ==sugerencia.Id);
           if (sugerenciaEncontrado!=null)
           {   
               sugerenciaEncontrado.Id=sugerencia.Id;
               sugerenciaEncontrado.FechaHora=sugerencia.FechaHora;
               sugerenciaEncontrado.Descripcion=sugerencia.Descripcion;
               
               _appContext.SaveChanges();
           }
           return sugerenciaEncontrado;
       }
       void IRepositorioSugerencia.DeleteSugerencia (int IdSugerencia)
       {
           var sugerenciaEncontrado=_appContext.SugerenciaCuidados.FirstOrDefault(p => p.Id ==IdSugerencia);
           if (sugerenciaEncontrado==null)
           return;
           _appContext.SugerenciaCuidados.Remove(sugerenciaEncontrado);
           _appContext.SaveChanges();
       }
       SugerenciaCuidado IRepositorioSugerencia.GetSugerencia (int IdSugerencia)
       {
           var sugerenciaEncontrado=_appContext.SugerenciaCuidados.FirstOrDefault(p => p.Id ==IdSugerencia);
           return sugerenciaEncontrado;
       }
       IEnumerable<SugerenciaCuidado> IRepositorioSugerencia.GetAllSugerencias()
       {
           return _appContext.SugerenciaCuidados;
       }
    }
}