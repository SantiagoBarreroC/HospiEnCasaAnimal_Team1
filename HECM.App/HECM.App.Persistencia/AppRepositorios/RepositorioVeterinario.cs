using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;
using System;
using HECM.App.Persistencia;


namespace HECM.App.Persistencia{
    public class RepositorioVeterinario: IRepositorioVeterinario
    {
       private readonly HECM.App.Persistencia.AppContext _appContext;

       public RepositorioVeterinario(HECM.App.Persistencia.AppContext appContext)
       {
           _appContext=appContext;
       }
       Veterinario IRepositorioVeterinario.AddVeterinario (Veterinario veterinario)
       {
           var veterinarioAdicionado=_appContext.Veterinarios.Add(veterinario);
           _appContext.SaveChanges();
           return veterinarioAdicionado.Entity;
       }
       Veterinario IRepositorioVeterinario.UpdateVeterinario (Veterinario veterinario)
       {
           var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p => p.Id ==veterinario.Id);
           if (veterinarioEncontrado!=null)
           {
               veterinarioEncontrado.Id=veterinario.Id;
               veterinarioEncontrado.Nombre=veterinario.Nombre;
               veterinarioEncontrado.Apellidos=veterinario.Apellidos;
               veterinarioEncontrado.Telefono=veterinario.Telefono;
               veterinarioEncontrado.TarjetaProfesional=veterinario.TarjetaProfesional;
               veterinarioEncontrado.Especialidad=veterinario.Especialidad;

               _appContext.SaveChanges();
           }
           return veterinarioEncontrado;
       }
       void IRepositorioVeterinario.DeleteVeterinario (int IdVeterinario)
       {
           var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p => p.Id ==IdVeterinario);
           if (veterinarioEncontrado==null)
           return;
           _appContext.Veterinarios.Remove(veterinarioEncontrado);
           _appContext.SaveChanges();
       }
       Veterinario IRepositorioVeterinario.GetVeterinario (int IdVeterinario)
       {
           var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p => p.Id ==IdVeterinario);
           return veterinarioEncontrado;
       }
       IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinario()
       {
           return _appContext.Veterinarios;
       }
    }
}