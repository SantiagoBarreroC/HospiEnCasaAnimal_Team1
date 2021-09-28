using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;
using System;
using HECM.App.Persistencia;


namespace HECM.App.Persistencia{
    public class RepositorioPropietario: IRepositorioPropietario
    {
       private readonly HECM.App.Persistencia.AppContext _appContext;

       public RepositorioPropietario(HECM.App.Persistencia.AppContext appContext)
       {
           _appContext=appContext;
       }
       PropietarioDesignado IRepositorioPropietario.AddPropietario (PropietarioDesignado propietario)
       {
           var propietarioAdicionado=_appContext.PropietariosDesignados.Add(propietario);
           _appContext.SaveChanges();
           return propietarioAdicionado.Entity;
       }
       PropietarioDesignado IRepositorioPropietario.UpdatePropietario (PropietarioDesignado propietario)
       {
           var propietarioEncontrado=_appContext.PropietariosDesignados.FirstOrDefault(p => p.Id ==propietario.Id);
           if (propietarioEncontrado!=null)
           {
               propietarioEncontrado.Nombre=propietario.Nombre;
               propietarioEncontrado.Apellidos=propietario.Apellidos;
               propietarioEncontrado.Telefono=propietario.Telefono;
               propietarioEncontrado.Correo=propietario.Correo;

               _appContext.SaveChanges();
           }
           return propietarioEncontrado;
       }
       void IRepositorioPropietario.DeletePropietario (int IdPropietario)
       {
           var propietarioEncontrado=_appContext.PropietariosDesignados.FirstOrDefault(p => p.Id ==IdPropietario);
           if (propietarioEncontrado==null)
           return;
           _appContext.PropietariosDesignados.Remove(propietarioEncontrado);
           _appContext.SaveChanges();
       }
       PropietarioDesignado IRepositorioPropietario.GetPropietario (int IdPropietario)
       {
           var propietarioEncontrado=_appContext.PropietariosDesignados.FirstOrDefault(p => p.Id ==IdPropietario);
           return propietarioEncontrado;
       }
       IEnumerable<PropietarioDesignado> IRepositorioPropietario.GetAllPropietarios()
       {
           return _appContext.PropietariosDesignados;
       }
    }
}