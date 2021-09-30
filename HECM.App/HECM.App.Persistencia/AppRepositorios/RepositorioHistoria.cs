using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;
using System;
using HECM.App.Persistencia;


namespace HECM.App.Persistencia{
    public class RepositorioHistoria: IRepositorioHistoria
    {
       private readonly HECM.App.Persistencia.AppContext _appContext;

       public RepositorioHistoria(HECM.App.Persistencia.AppContext appContext)
       {
           _appContext=appContext;
       }
       Historia IRepositorioHistoria.AddHistoria (Historia historia)
       {
           var historiaAdicionado=_appContext.Historias.Add(historia);
           _appContext.SaveChanges();
           return historiaAdicionado.Entity;
       }
       Historia IRepositorioHistoria.UpdateHistoria (Historia historia)
       {
           var historiaEncontrado=_appContext.Historias.FirstOrDefault(p => p.Id ==historia.Id);
           if (historiaEncontrado!=null)
           {   
               historiaEncontrado.Id=historia.Id;
               historiaEncontrado.Entorno=historia.Entorno;
               historiaEncontrado.Diagnostico=historia.Diagnostico;
               
               _appContext.SaveChanges();
           }
           return historiaEncontrado;
       }
       void IRepositorioHistoria.DeleteHistoria (int IdHistoria)
       {
           var historiaEncontrado=_appContext.Historias.FirstOrDefault(p => p.Id ==IdHistoria);
           if (historiaEncontrado==null)
           return;
           _appContext.Historias.Remove(historiaEncontrado);
           _appContext.SaveChanges();
       }
       Historia IRepositorioHistoria.GetHistoria (int IdHistoria)
       {
           var historiaEncontrado=_appContext.Historias.FirstOrDefault(p => p.Id ==IdHistoria);
           return historiaEncontrado;
       }
       IEnumerable<Historia> IRepositorioHistoria.GetAllHistorias()
       {
           return _appContext.Historias;
       }
    }
}